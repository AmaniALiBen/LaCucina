using LaCucina;
using LaCucina.DataLink;
using LaCucina.Models;
using LaCucina.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LaCucinaTests
{
    [TestFixture]
    public class OrdersServiceTests
    {
        [Test]
        public void GetWaiters_ReturnsWaitersFromRepo()
        {
            // Arrange
            var fakeWaiters = new List<string> { "Ali", "Sara" };

            var mockRepo = new Mock<OrdersRepository>();
            mockRepo.Setup(r => r.GetWaiters()).Returns(fakeWaiters);

            var service = new OrdersService(mockRepo.Object);

            // Act
            var result = service.GetWaiters();

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result, Contains.Item("Ali"));
        }

        [Test]
        public void GetTables_ReturnsTablesFromRepo()
        {
            // Arrange
            var fakeTables = new List<string> { "Table 1", "Table 2" };

            var mockRepo = new Mock<OrdersRepository>();
            mockRepo.Setup(r => r.GetTables()).Returns(fakeTables);

            var service = new OrdersService(mockRepo.Object);

            // Act
            var result = service.GetTables();

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void GetOrders_ReturnsOrdersFromRepo()
        {
            // Arrange
            var from = new DateTime(2026, 1, 1);
            var to = new DateTime(2026, 1, 31);

            var fakeOrders = new List<OrderRowDto>
            {
                new OrderRowDto { OrderId = 1, IsTakeaway = false, TableNumber = "5", WaiterName = "Ali", TotalAmount = 50.0m },
                new OrderRowDto { OrderId = 2, IsTakeaway = true, WaiterName = "Sara", TotalAmount = 30.0m }
            };

            var mockRepo = new Mock<OrdersRepository>();
            mockRepo.Setup(r => r.GetOrders(from, to, null)).Returns(fakeOrders);

            var service = new OrdersService(mockRepo.Object);

            // Act
            var result = service.GetOrders(from, to);

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].WaiterName, Is.EqualTo("Ali"));
        }

        [Test]
        public void GetOrderDetail_ReturnsDetailFromRepo()
        {
            // Arrange
            var fakeDetail = new OrderDetailDto
            {
                OrderId = 7,
                IsTakeaway = false,
                TableNumber = "3",
                TotalAmount = 75.5m
            };

            var mockRepo = new Mock<OrdersRepository>();
            mockRepo.Setup(r => r.GetOrderDetail(7)).Returns(fakeDetail);

            var service = new OrdersService(mockRepo.Object);

            // Act
            var result = service.GetOrderDetail(7);

            // Assert
            Assert.That(result.OrderId, Is.EqualTo(7));
            Assert.That(result.TotalAmount, Is.EqualTo(75.5m));
        }
    }
}