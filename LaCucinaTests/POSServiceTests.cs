using LaCucina.DataLink;
using LaCucina.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data;

namespace LaCucinaTests
{
    [TestFixture]
    public class POSServiceTests
    {
        private Mock<POSRepository> mockRepo;
        private POSService service;

        [SetUp]
        public void Setup()
        {
            mockRepo = new Mock<POSRepository>();
            service = new POSService(mockRepo.Object);
        }

        // ── ProcessAndSendOrder ──────────────────────────────────────────

        [Test]
        public void ProcessAndSendOrder_ValidOrder_ReturnsTrue()
        {
            var items = new List<MemoryOrderItem> { new MemoryOrderItem { MenuItemId = 1, Quantity = 2 } };
            int dummyOrderId;

            mockRepo.Setup(r => r.SaveFullOrderTransaction(
                1, 5, items, 50.0, 45.0, null, null, 0, false, out dummyOrderId))
                .Returns(true);

            var result = service.ProcessAndSendOrder(1, 5, items, 50.0, 45.0, null, null, 0, false, out int orderId);

            Assert.That(result, Is.True);
        }

        [Test]
        public void ProcessAndSendOrder_RepoFails_ReturnsFalse()
        {
            var items = new List<MemoryOrderItem>();
            int dummyOrderId;

            mockRepo.Setup(r => r.SaveFullOrderTransaction(
                0, 0, items, 0, 0, null, null, 0, false, out dummyOrderId))
                .Returns(false);

            var result = service.ProcessAndSendOrder(0, 0, items, 0, 0, null, null, 0, false, out int orderId);

            Assert.That(result, Is.False);
        }

        [Test]
        public void ProcessAndSendOrder_TakeAway_ReturnsTrue()
        {
            var items = new List<MemoryOrderItem> { new MemoryOrderItem { MenuItemId = 3, Quantity = 1 } };
            int dummyOrderId;

            mockRepo.Setup(r => r.SaveFullOrderTransaction(
                0, 2, items, 20.0, 20.0, null, null, 0, true, out dummyOrderId))
                .Returns(true);

            var result = service.ProcessAndSendOrder(0, 2, items, 20.0, 20.0, null, null, 0, true, out int orderId);

            Assert.That(result, Is.True);
        }

        // ── LoadOpenOrder ────────────────────────────────────────────────

        [Test]
        public void LoadOpenOrder_ReturnsItems()
        {
            int dummyOrderId = 10;
            double dummyTotal = 100.0;
            var expectedItems = new List<MemoryOrderItem>
            {
                new MemoryOrderItem { MenuItemId = 1, Quantity = 2 },
                new MemoryOrderItem { MenuItemId = 2, Quantity = 1 }
            };

            mockRepo.Setup(r => r.GetActiveOrderItemsByTable(3, out dummyOrderId, out dummyTotal))
                    .Returns(expectedItems);

            var result = service.LoadOpenOrder(3, out int openOrderId, out double currentTotal);

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(openOrderId, Is.EqualTo(10));
            Assert.That(currentTotal, Is.EqualTo(100.0));
        }

        [Test]
        public void LoadOpenOrder_NoOpenOrder_ReturnsEmptyList()
        {
            int dummyOrderId = 0;
            double dummyTotal = 0;

            mockRepo.Setup(r => r.GetActiveOrderItemsByTable(99, out dummyOrderId, out dummyTotal))
                    .Returns(new List<MemoryOrderItem>());

            var result = service.LoadOpenOrder(99, out int openOrderId, out double currentTotal);

            Assert.That(result.Count, Is.EqualTo(0));
            Assert.That(openOrderId, Is.EqualTo(0));
        }

        // ── CompleteOrderPayment ─────────────────────────────────────────

        [Test]
        public void CompleteOrderPayment_ValidOrder_ReturnsTrue()
        {
            mockRepo.Setup(r => r.PayAndCloseOrder(7)).Returns(true);

            var result = service.CompleteOrderPayment(7);

            Assert.That(result, Is.True);
            mockRepo.Verify(r => r.PayAndCloseOrder(7), Times.Once);
        }

        [Test]
        public void CompleteOrderPayment_InvalidOrder_ReturnsFalse()
        {
            mockRepo.Setup(r => r.PayAndCloseOrder(99)).Returns(false);

            var result = service.CompleteOrderPayment(99);

            Assert.That(result, Is.False);
        }

        // ── UpdateOrderDiscount ──────────────────────────────────────────

        [Test]
        public void UpdateOrderDiscount_ValidData_ReturnsTrue()
        {
            mockRepo.Setup(r => r.UpdateOrderDiscountDetails(1, 100.0, 90.0, 2, 0, 10.0))
                    .Returns(true);

            var result = service.UpdateOrderDiscount(1, 100.0, 90.0, 2, 0, 10.0);

            Assert.That(result, Is.True);
            mockRepo.Verify(r => r.UpdateOrderDiscountDetails(1, 100.0, 90.0, 2, 0, 10.0), Times.Once);
        }

        [Test]
        public void UpdateOrderDiscount_NoDiscount_ReturnsTrue()
        {
            mockRepo.Setup(r => r.UpdateOrderDiscountDetails(1, 100.0, 100.0, null, null, 0))
                    .Returns(true);

            var result = service.UpdateOrderDiscount(1, 100.0, 100.0, null, null, 0);

            Assert.That(result, Is.True);
        }

        [Test]
        public void UpdateOrderDiscount_RepoFails_ReturnsFalse()
        {
            mockRepo.Setup(r => r.UpdateOrderDiscountDetails(99, 0, 0, null, null, 0))
                    .Returns(false);

            var result = service.UpdateOrderDiscount(99, 0, 0, null, null, 0);

            Assert.That(result, Is.False);
        }

        // ── GetDiscountsForForm ──────────────────────────────────────────

        [Test]
        public void GetDiscountsForForm_ReturnsDataTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("discount_id", typeof(int));
            dt.Columns.Add("discount_name", typeof(string));
            dt.Columns.Add("discount_type", typeof(byte));
            dt.Columns.Add("discount_amount", typeof(double));
            dt.Rows.Add(1, "Summer Sale", 0, 10.0);
            dt.Rows.Add(2, "Happy Hour", 1, 5.0);

            mockRepo.Setup(r => r.GetActiveDiscountsForToday()).Returns(dt);

            var result = service.GetDiscountsForForm();

            Assert.That(result.Rows.Count, Is.EqualTo(2));
            Assert.That(result.Rows[0]["discount_name"].ToString(), Is.EqualTo("Summer Sale"));
        }

        [Test]
        public void GetDiscountsForForm_NoDiscounts_ReturnsEmptyTable()
        {
            var dt = new DataTable();
            mockRepo.Setup(r => r.GetActiveDiscountsForToday()).Returns(dt);

            var result = service.GetDiscountsForForm();

            Assert.That(result.Rows.Count, Is.EqualTo(0));
        }
    }
}