using LaCucina;
using Moq;
using NUnit.Framework;

namespace LaCucinaTests
{
    [TestFixture]
    public class DiscountsManagerTests
    {
        // ────────── DateLogic ──────────

        [Test]
        public void DateLogic_EndAfterStart_ReturnsTrue()
        {
            var manager = new DiscountsManager(new Mock<DiscountRepository>().Object);

            var result = manager.DateLogic("2024-01-01", "2024-06-01");

            Assert.That(result, Is.True);
        }

        [Test]
        public void DateLogic_EndEqualsStart_ReturnsTrue()
        {
            var manager = new DiscountsManager(new Mock<DiscountRepository>().Object);

            var result = manager.DateLogic("2024-03-15", "2024-03-15");

            Assert.That(result, Is.True);
        }

        [Test]
        public void DateLogic_EndBeforeStart_ReturnsFalse()
        {
            var manager = new DiscountsManager(new Mock<DiscountRepository>().Object);

            var result = manager.DateLogic("2024-06-01", "2024-01-01");

            Assert.That(result, Is.False);
        }

        [Test]
        public void DateLogic_InvalidDateString_ReturnsFalse()
        {
            var manager = new DiscountsManager(new Mock<DiscountRepository>().Object);

            var result = manager.DateLogic("not-a-date", "2024-01-01");

            Assert.That(result, Is.False);
        }

        // ────────── AddDiscount ──────────

        [Test]
        public void AddDiscount_ValidDates_ReturnsTrue()
        {
            var mockRepo = new Mock<DiscountRepository>();
            var manager = new DiscountsManager(mockRepo.Object);

            var result = manager.AddDiscount("Summer Sale", Discounts.Type.Percentage,
                10.0, "2024-06-01", "2024-08-31", true);

            Assert.That(result, Is.True);
            mockRepo.Verify(r => r.Add(It.IsAny<Discounts>()), Times.Once);
        }

        [Test]
        public void AddDiscount_InvalidDates_ReturnsFalse()
        {
            var mockRepo = new Mock<DiscountRepository>();
            var manager = new DiscountsManager(mockRepo.Object);

            var result = manager.AddDiscount("Bad Discount", Discounts.Type.Percentage,
                10.0, "2024-12-01", "2024-01-01", true);

            Assert.That(result, Is.False);
            mockRepo.Verify(r => r.Add(It.IsAny<Discounts>()), Times.Never);
        }

        // ────────── UpdateDB ──────────

        [Test]
        public void UpdateDB_ValidKeyAndDiscount_ReturnsTrue()
        {
            var mockRepo = new Mock<DiscountRepository>();
            var manager = new DiscountsManager(mockRepo.Object);

            var discount = new Discounts("Winter Sale", Discounts.Type.Fixed,
                5.0, "2024-11-01", "2024-12-31", true, false);

            var result = manager.UpdateDB(1, discount);

            Assert.That(result, Is.True);
            mockRepo.Verify(r => r.Update(1, discount), Times.Once);
        }

        [Test]
        public void UpdateDB_KeyIsZero_ReturnsFalse()
        {
            var mockRepo = new Mock<DiscountRepository>();
            var manager = new DiscountsManager(mockRepo.Object);

            var discount = new Discounts("Test", Discounts.Type.Fixed,
                5.0, "2024-01-01", "2024-12-31", true, false);

            var result = manager.UpdateDB(0, discount);

            Assert.That(result, Is.False);
            mockRepo.Verify(r => r.Update(It.IsAny<int>(), It.IsAny<Discounts>()), Times.Never);
        }

        [Test]
        public void UpdateDB_NullDiscount_ReturnsFalse()
        {
            var mockRepo = new Mock<DiscountRepository>();
            var manager = new DiscountsManager(mockRepo.Object);

            var result = manager.UpdateDB(1, null);

            Assert.That(result, Is.False);
            mockRepo.Verify(r => r.Update(It.IsAny<int>(), It.IsAny<Discounts>()), Times.Never);
        }

        [Test]
        public void UpdateDB_InvalidDates_ReturnsFalse()
        {
            var mockRepo = new Mock<DiscountRepository>();
            var manager = new DiscountsManager(mockRepo.Object);

            var discount = new Discounts("Bad", Discounts.Type.Fixed,
                5.0, "2024-12-01", "2024-01-01", true, false);

            var result = manager.UpdateDB(1, discount);

            Assert.That(result, Is.False);
            mockRepo.Verify(r => r.Update(It.IsAny<int>(), It.IsAny<Discounts>()), Times.Never);
        }

        // ────────── DeleteDiscount ──────────

        [Test]
        public void DeleteDiscount_ValidKey_ReturnsTrue()
        {
            var mockRepo = new Mock<DiscountRepository>();
            var manager = new DiscountsManager(mockRepo.Object);

            var result = manager.DeleteDiscount(5);

            Assert.That(result, Is.True);
            mockRepo.Verify(r => r.Delete(5), Times.Once);
        }

        [Test]
        public void DeleteDiscount_KeyIsZero_ReturnsFalse()
        {
            var mockRepo = new Mock<DiscountRepository>();
            var manager = new DiscountsManager(mockRepo.Object);

            var result = manager.DeleteDiscount(0);

            Assert.That(result, Is.False);
            mockRepo.Verify(r => r.Delete(It.IsAny<int>()), Times.Never);
        }
    }
}