using LaCucina;
using LaCucina.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucinaTests
{
    internal class ItemModifierServiceTests
    {

        [Test]
        public void GetItemCustomizationDetails_ReturnsDetailsFromRepo()
        {
            // Arrange
            var fakeDetails = new ItemDetails
            {
                ItemName = "Margherita Pizza"
            };

            var mockRepo = new Mock<ItemRepository>();
            mockRepo.Setup(r => r.GetItemDetailsWithIngredients(5)).Returns(fakeDetails);

            var service = new ItemModifierService(mockRepo.Object);

            // Act
            var result = service.GetItemCustomizationDetails(5);

            // Assert
            Assert.That(result.ItemName, Is.EqualTo("Margherita Pizza"));
        }
    }
}
