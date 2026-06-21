using LaCucina;
using LaCucina.DataLink;
using LaCucina.Services;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

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

        [Test]
        public void GetItemsByCategory_ReturnsItemsFromRepo()
        {
            // Arrange
            var fakeItems = new List<Item>
            {
                new Item(1, "Pizza", 1, 12.99, true),
                new Item(2, "Burger", 1, 8.99, true)
            };

            var mockCategoryRepo = new Mock<CategoryRepository>();
            var mockItemRepo = new Mock<ItemRepository>();
            mockItemRepo.Setup(r => r.GetByCategory(1)).Returns(fakeItems);
            var mockIngredientsRepo = new Mock<menuItemIngredientsRepository>();

            var service = new MenuService(mockCategoryRepo.Object, mockItemRepo.Object, mockIngredientsRepo.Object);

            // Act
            var result = service.GetItemsByCategory(1);

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].Name, Is.EqualTo("Pizza"));
        }

        [Test]
        public void GetInStockItemsByCategory_ReturnsActiveItemsFromRepo()
        {
            // Arrange
            var fakeItems = new List<Item>
            {
                new Item(1, "Pizza", 1, 12.99, true)
            };

            var mockCategoryRepo = new Mock<CategoryRepository>();
            var mockItemRepo = new Mock<ItemRepository>();
            mockItemRepo.Setup(r => r.GetActiveItemsByCategory(1)).Returns(fakeItems);
            var mockIngredientsRepo = new Mock<menuItemIngredientsRepository>();

            var service = new MenuService(mockCategoryRepo.Object, mockItemRepo.Object, mockIngredientsRepo.Object);

            // Act
            var result = service.GetInStockItemsByCategory(1);

            // Assert
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].Name, Is.EqualTo("Pizza"));
        }

        [Test]
        public void DeleteItem_ItemNotFound_ReturnsFalse()
        {
            // Arrange
            var mockCategoryRepo = new Mock<CategoryRepository>();
            var mockItemRepo = new Mock<ItemRepository>();
            mockItemRepo.Setup(r => r.GetById(99)).Returns((Item)null);
            var mockIngredientsRepo = new Mock<menuItemIngredientsRepository>();

            var service = new MenuService(mockCategoryRepo.Object, mockItemRepo.Object, mockIngredientsRepo.Object);

            // Act
            var result = service.DeleteItem(99);

            // Assert
            Assert.That(result, Is.False);
            mockItemRepo.Verify(r => r.Delete(99), Times.Never);
        }

        [Test]
        public void DeleteItem_ItemFound_ReturnsTrueAndDeletes()
        {
            // Arrange
            var existingItem = new Item(5, "Pasta", 1, 10.50, true);

            var mockCategoryRepo = new Mock<CategoryRepository>();
            var mockItemRepo = new Mock<ItemRepository>();
            mockItemRepo.Setup(r => r.GetById(5)).Returns(existingItem);
            var mockIngredientsRepo = new Mock<menuItemIngredientsRepository>();

            var service = new MenuService(mockCategoryRepo.Object, mockItemRepo.Object, mockIngredientsRepo.Object);

            // Act
            var result = service.DeleteItem(5);

            // Assert
            Assert.That(result, Is.True);
            mockItemRepo.Verify(r => r.Delete(5), Times.Once);
            mockIngredientsRepo.Verify(r => r.DeleteAllByMenuItem(5), Times.Once);
        }
    }
}