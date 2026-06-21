using LaCucina;
using LaCucina.DataLink;
using LaCucina.Models;
using LaCucina.Services;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

namespace LaCucinaTests
{
    [TestFixture]
    public class FloorPlanServiceTests
    {
        private Mock<TableRepository> mockTableRepo;
        private Mock<SpaceRepository> mockSpaceRepo;
        private FloorPlanService service;

        private Table MakeTable(int id, string tableNum, int spaceId)
            => new Table(id, tableNum, 4, TableFormat.circular, new Point(0, 0), spaceId, TableStatus.vacant);

        [SetUp]
        public void Setup()
        {
            mockTableRepo = new Mock<TableRepository>();
            mockSpaceRepo = new Mock<SpaceRepository>();
            service = new FloorPlanService(mockTableRepo.Object, mockSpaceRepo.Object);
        }

        // ── GetSpaces ────────────────────────────────────────────────────

        [Test]
        public void GetSpaces_ReturnsAllSpaces()
        {
            var spaces = new List<spaces>
            {
                new spaces(1, "Main Hall"),
                new spaces(2, "Terrace")
            };
            mockSpaceRepo.Setup(r => r.GetAll()).Returns(spaces);

            var result = service.GetSpaces();

            Assert.That(result.Count, Is.EqualTo(2));
        }

        // ── GetTablesBySpace ─────────────────────────────────────────────

        [Test]
        public void GetTablesBySpace_ReturnsTables()
        {
            var tables = new List<Table> { MakeTable(1, "A1", 1), MakeTable(2, "A2", 1) };
            mockTableRepo.Setup(r => r.GetBySpace(1)).Returns(tables);

            var result = service.GetTablesBySpace(1);

            Assert.That(result.Count, Is.EqualTo(2));
        }

        // ── GetTableById ─────────────────────────────────────────────────

        [Test]
        public void GetTableById_ExistingId_ReturnsTable()
        {
            var table = MakeTable(3, "B1", 1);
            mockTableRepo.Setup(r => r.GetById(3)).Returns(table);

            var result = service.GetTableById(3);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.id, Is.EqualTo(3));
        }

        [Test]
        public void GetTableById_NotFound_ReturnsNull()
        {
            mockTableRepo.Setup(r => r.GetById(99)).Returns((Table)null);

            var result = service.GetTableById(99);

            Assert.That(result, Is.Null);
        }

        // ── DeleteTable ──────────────────────────────────────────────────

        [Test]
        public void DeleteTable_CallsRepoDelete()
        {
            service.DeleteTable(5);

            mockTableRepo.Verify(r => r.Delete(5), Times.Once);
        }

        // ── AddTable ─────────────────────────────────────────────────────

        [Test]
        public void AddTable_CallsRepoAdd()
        {
            var table = MakeTable(0, "C1", 1);

            service.AddTable(table);

            mockTableRepo.Verify(r => r.Add(table), Times.Once);
        }

        // ── UpdateTable ──────────────────────────────────────────────────

        [Test]
        public void UpdateTable_CallsRepoUpdate()
        {
            var table = MakeTable(2, "B2", 1);

            service.UpdateTable(table);

            mockTableRepo.Verify(r => r.Update(table), Times.Once);
        }

        // ── editLocation ─────────────────────────────────────────────────

        [Test]
        public void EditLocation_CallsRepoWithCorrectCoordinates()
        {
            service.editLocation(1, new Point(100, 200));

            mockTableRepo.Verify(r => r.editLocation(1, 100, 200), Times.Once);
        }

        // ── GetTablesWithReadyItems ──────────────────────────────────────

        [Test]
        public void GetTablesWithReadyItems_ReturnsTableIds()
        {
            var ids = new List<int> { 1, 3, 7 };
            mockTableRepo.Setup(r => r.GetTablesWithReadyItems()).Returns(ids);

            var result = service.GetTablesWithReadyItems();

            Assert.That(result, Is.EqualTo(ids));
        }

        // ── MarkReadyItemsAsDelivered ────────────────────────────────────

        [Test]
        public void MarkReadyItemsAsDelivered_ReturnsTrue_WhenSuccessful()
        {
            mockTableRepo.Setup(r => r.MarkReadyItemsAsDelivered(2)).Returns(true);

            var result = service.MarkReadyItemsAsDelivered(2);

            Assert.That(result, Is.True);
        }

        [Test]
        public void MarkReadyItemsAsDelivered_ReturnsFalse_WhenFails()
        {
            mockTableRepo.Setup(r => r.MarkReadyItemsAsDelivered(99)).Returns(false);

            var result = service.MarkReadyItemsAsDelivered(99);

            Assert.That(result, Is.False);
        }

        // ── ValidateTable ────────────────────────────────────────────────

        [Test]
        public void ValidateTable_EmptyTableNum_ReturnsError()
        {
            var table = MakeTable(0, "   ", 1);

            var result = service.ValidateTable(table);

            Assert.That(result, Is.EqualTo("Table number is required"));
        }

        [Test]
        public void ValidateTable_TableNumTooLong_ReturnsError()
        {
            mockTableRepo.Setup(r => r.GetBySpace(1)).Returns(new List<Table>());
            var table = MakeTable(0, "ABCD", 1);

            var result = service.ValidateTable(table);

            Assert.That(result, Is.EqualTo("Table number is too long"));
        }

        [Test]
        public void ValidateTable_DuplicateTableNum_ReturnsError()
        {
            var existing = MakeTable(10, "A1", 1);
            mockTableRepo.Setup(r => r.GetBySpace(1)).Returns(new List<Table> { existing });
            var newTable = MakeTable(99, "A1", 1);

            var result = service.ValidateTable(newTable);

            Assert.That(result, Is.EqualTo("Table number already exists"));
        }

        [Test]
        public void ValidateTable_EditSameTable_ReturnsNull()
        {
            var existing = MakeTable(10, "A1", 1);
            mockTableRepo.Setup(r => r.GetBySpace(1)).Returns(new List<Table> { existing });
            var sameTable = MakeTable(10, "A1", 1);

            var result = service.ValidateTable(sameTable, isEdit: true);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void ValidateTable_ValidNewTable_ReturnsNull()
        {
            mockTableRepo.Setup(r => r.GetBySpace(1)).Returns(new List<Table>());
            var table = MakeTable(0, "B3", 1);

            var result = service.ValidateTable(table);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void ValidateTable_TrimsWhitespace_BeforeValidation()
        {
            mockTableRepo.Setup(r => r.GetBySpace(1)).Returns(new List<Table>());
            var table = MakeTable(0, " A1 ", 1);

            var result = service.ValidateTable(table);

            Assert.That(result, Is.Null);
            Assert.That(table.tableNum, Is.EqualTo("A1"));
        }
    }
}