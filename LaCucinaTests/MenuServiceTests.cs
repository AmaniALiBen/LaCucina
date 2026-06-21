using LaCucina;
using LaCucina.DataLink;
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
    [TestFixture]
    public class MenuServiceTests
    {
        [Test]
        public void GetCategories_ReturnsCategoriesFromRepo()
        {
            // Arrange
            var fakeCategories = new List<Categories>
    {
       new Categories(1, "Drinks"),
        new Categories(2, "Desserts")
    };

            var mockCategoryRepo = new Mock<CategoryRepository>();
            mockCategoryRepo.Setup(r => r.GetAll()).Returns(fakeCategories);

            var mockItemRepo = new Mock<ItemRepository>();
            var mockIngredientsRepo = new Mock<menuItemIngredientsRepository>();

            var service = new MenuService(mockCategoryRepo.Object, mockItemRepo.Object, mockIngredientsRepo.Object);

            // Act
            var result = service.GetCategories();

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].name, Is.EqualTo("Drinks"));
        }
    }
}
