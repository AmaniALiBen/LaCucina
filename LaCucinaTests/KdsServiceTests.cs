using LaCucina.DataLink;
using LaCucina.Models;
using LaCucina.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Data;

namespace LaCucinaTests
{
    [TestFixture]
    public class KdsServiceTests
    {
        private Mock<KdsRepository> mockRepo;
        private KdsService service;

        [SetUp]
        public void Setup()
        {
            mockRepo = new Mock<KdsRepository>();
            service = new KdsService(mockRepo.Object);
        }

        // ── Helper: بناء DataTable فيه batch واحد وitem واحد ────────────

        private DataTable MakeBatchTable(
            int batchId = 1, int orderId = 10,
            string tableNumber = "T1", string spaceName = "Main",
            int batchStatus = 0, int orderItemId = 100,
            string menuItemName = "Pizza", int quantity = 2,
            int itemStatus = 0, string noteText = null,
            string ingredientName = null)
        {
            var dt = new DataTable();
            dt.Columns.Add("batch_id", typeof(int));
            dt.Columns.Add("order_id", typeof(int));
            dt.Columns.Add("table_number", typeof(string));
            dt.Columns.Add("space_name", typeof(string));
            dt.Columns.Add("sent_at", typeof(DateTime));
            dt.Columns.Add("batch_status", typeof(int));
            dt.Columns.Add("order_item_id", typeof(int));
            dt.Columns.Add("menu_item_name", typeof(string));
            dt.Columns.Add("quantity", typeof(int));
            dt.Columns.Add("item_status", typeof(int));
            dt.Columns.Add("note_text", typeof(string));
            dt.Columns.Add("ingredient_name", typeof(string));

            var row = dt.NewRow();
            row["batch_id"] = batchId;
            row["order_id"] = orderId;
            row["table_number"] = tableNumber;
            row["space_name"] = spaceName;
            row["sent_at"] = DateTime.Now;
            row["batch_status"] = batchStatus;
            row["order_item_id"] = orderItemId;
            row["menu_item_name"] = menuItemName;
            row["quantity"] = quantity;
            row["item_status"] = itemStatus;
            row["note_text"] = (object)noteText ?? DBNull.Value;
            row["ingredient_name"] = (object)ingredientName ?? DBNull.Value;
            dt.Rows.Add(row);

            return dt;
        }

        // ── GetActiveBatches ─────────────────────────────────────────────

        [Test]
        public void GetActiveBatches_SingleRow_ReturnsBatch()
        {
            mockRepo.Setup(r => r.GetActiveBatchesRaw()).Returns(MakeBatchTable());

            var result = service.GetActiveBatches();

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].BatchId, Is.EqualTo(1));
            Assert.That(result[0].TableNumber, Is.EqualTo("T1"));
        }

        [Test]
        public void GetActiveBatches_SingleRow_ReturnsCorrectItem()
        {
            mockRepo.Setup(r => r.GetActiveBatchesRaw()).Returns(MakeBatchTable(menuItemName: "Burger", quantity: 3));

            var result = service.GetActiveBatches();

            Assert.That(result[0].Items.Count, Is.EqualTo(1));
            Assert.That(result[0].Items[0].MenuItemName, Is.EqualTo("Burger"));
            Assert.That(result[0].Items[0].Quantity, Is.EqualTo(3));
        }

        [Test]
        public void GetActiveBatches_WithRemovedIngredient_AddsToList()
        {
            mockRepo.Setup(r => r.GetActiveBatchesRaw())
                    .Returns(MakeBatchTable(ingredientName: "Onion"));

            var result = service.GetActiveBatches();

            Assert.That(result[0].Items[0].RemovedIngredients, Contains.Item("No Onion"));
        }

        [Test]
        public void GetActiveBatches_NullIngredient_DoesNotAdd()
        {
            mockRepo.Setup(r => r.GetActiveBatchesRaw())
                    .Returns(MakeBatchTable(ingredientName: null));

            var result = service.GetActiveBatches();

            Assert.That(result[0].Items[0].RemovedIngredients.Count, Is.EqualTo(0));
        }

        [Test]
        public void GetActiveBatches_NullNote_SetsNoteTextToNull()
        {
            mockRepo.Setup(r => r.GetActiveBatchesRaw())
                    .Returns(MakeBatchTable(noteText: null));

            var result = service.GetActiveBatches();

            Assert.That(result[0].Items[0].NoteText, Is.Null);
        }

        [Test]
        public void GetActiveBatches_WithNote_SetsNoteText()
        {
            mockRepo.Setup(r => r.GetActiveBatchesRaw())
                    .Returns(MakeBatchTable(noteText: "Extra spicy"));

            var result = service.GetActiveBatches();

            Assert.That(result[0].Items[0].NoteText, Is.EqualTo("Extra spicy"));
        }

        [Test]
        public void GetActiveBatches_EmptyTable_ReturnsEmptyList()
        {
            var empty = new DataTable();
            // نفس الكولومنز بدون rows
            foreach (var col in MakeBatchTable().Columns)
                empty.Columns.Add(((DataColumn)col).ColumnName, ((DataColumn)col).DataType);

            mockRepo.Setup(r => r.GetActiveBatchesRaw()).Returns(empty);

            var result = service.GetActiveBatches();

            Assert.That(result.Count, Is.EqualTo(0));
        }

        // ── GetKitchenLoad ───────────────────────────────────────────────

        [Test]
        public void GetKitchenLoad_ReturnsCorrectItems()
        {
            var dt = new DataTable();
            dt.Columns.Add("menu_item_id", typeof(int));
            dt.Columns.Add("menu_item_name", typeof(string));
            dt.Columns.Add("total_quantity", typeof(int));
            dt.Rows.Add(1, "Pizza", 5);
            dt.Rows.Add(2, "Pasta", 3);

            mockRepo.Setup(r => r.GetKitchenLoadRaw()).Returns(dt);

            var result = service.GetKitchenLoad();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].MenuItemName, Is.EqualTo("Pizza"));
            Assert.That(result[1].TotalQuantity, Is.EqualTo(3));
        }

        // ── GetTotalItemsInQueue ─────────────────────────────────────────

        [Test]
        public void GetTotalItemsInQueue_ReturnsCount()
        {
            mockRepo.Setup(r => r.GetTotalItemsInQueue()).Returns(7);

            var result = service.GetTotalItemsInQueue();

            Assert.That(result, Is.EqualTo(7));
        }

        // ── MarkItemDone ─────────────────────────────────────────────────

        [Test]
        public void MarkItemDone_CallsRepo()
        {
            service.MarkItemDone(42);

            mockRepo.Verify(r => r.MarkItemDone(42), Times.Once);
        }

        // ── MarkBatchReady ───────────────────────────────────────────────

        [Test]
        public void MarkBatchReady_CallsRepo()
        {
            service.MarkBatchReady(5);

            mockRepo.Verify(r => r.MarkBatchReady(5), Times.Once);
        }

        // ── CountPendingItems ────────────────────────────────────────────

        [Test]
        public void CountPendingItems_ReturnsCount()
        {
            mockRepo.Setup(r => r.CountPendingItems(3)).Returns(2);

            var result = service.CountPendingItems(3);

            Assert.That(result, Is.EqualTo(2));
        }

        // ── MarkAllItemsDone ─────────────────────────────────────────────

        [Test]
        public void MarkAllItemsDone_CallsRepo()
        {
            service.MarkAllItemsDone(10);

            mockRepo.Verify(r => r.MarkAllItemsDone(10), Times.Once);
        }
    }
}