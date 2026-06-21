using LaCucina;
using LaCucina.DataLink;
using LaCucina.Models;
using LaCucina.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Security.Cryptography;
using System.Text;
namespace LaCucinaTests
{
    [TestFixture]
    public class LoginServiceTests
    {
        [Test]
        public void ConfirmLogin_UserNotFound_ReturnsNull()
        {
            // Arrange
            var mockRepo = new Mock<UserRepository>();
            mockRepo.Setup(r => r.GetByUsername("ghost")).Returns((User)null);

            var service = new LoginService(mockRepo.Object);

            // Act
            var result = service.ConfirmLogin("ghost", "anypassword");

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public void ConfirmLogin_ValidCredentials_ReturnsUser()
        {
            // Arrange
            var realUser = new User
            {
                Username = "admin",
                PasswordHash = Hash("secret123"),
                IsActive = true,
                IsDeleted = false
            };

            var mockRepo = new Mock<UserRepository>();
            mockRepo.Setup(r => r.GetByUsername("admin")).Returns(realUser);

            var service = new LoginService(mockRepo.Object);

            // Act
            var result = service.ConfirmLogin("admin", "secret123");

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Username, Is.EqualTo("admin"));
        }

        [Test]
        public void ConfirmLogin_DeletedUser_ReturnsNull()
        {
            // Arrange
            var realUser = new User
            {
                Username = "admin",
                PasswordHash = Hash("secret123"),
                IsActive = true,
                IsDeleted = true
            };

            var mockRepo = new Mock<UserRepository>();
            mockRepo.Setup(r => r.GetByUsername("admin")).Returns(realUser);

            var service = new LoginService(mockRepo.Object);

            // Act
            var result = service.ConfirmLogin("admin", "secret123");

            // Assert
            Assert.That(result, Is.Null);
           
        }
        [Test]
        public void ConfirmLogin_InactiveUser_ReturnsNull()
        {
            // Arrange
            var inactiveUser = new User
            {
                Username = "admin",
                PasswordHash = Hash("secret123"),
                IsActive = false,
                IsDeleted = false
            };
            var mockRepo = new Mock<UserRepository>();
            mockRepo.Setup(r => r.GetByUsername("admin")).Returns(inactiveUser);
            var service = new LoginService(mockRepo.Object);

            // Act
            var result = service.ConfirmLogin("admin", "secret123");

            // Assert
            Assert.That(result, Is.Null);
        }
        [Test]
        public void ConfirmLogin_WrongPassword_ReturnsNull()
        {
            // Arrange
            var user = new User
            {
                Username = "admin",
                PasswordHash = Hash("correctpassword"),
                IsActive = true,
                IsDeleted = false
            };
            var mockRepo = new Mock<UserRepository>();
            mockRepo.Setup(r => r.GetByUsername("admin")).Returns(user);
            var service = new LoginService(mockRepo.Object);

            // Act
            var result = service.ConfirmLogin("admin", "wrongpassword");

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public void ConfirmLogin_ValidCredentials_SetsSessionCurrentUser()
        {
            // Arrange
            var user = new User
            {
                Username = "admin",
                PasswordHash = Hash("secret123"),
                IsActive = true,
                IsDeleted = false
            };
            var mockRepo = new Mock<UserRepository>();
            mockRepo.Setup(r => r.GetByUsername("admin")).Returns(user);
            var service = new LoginService(mockRepo.Object);

            // Act
            service.ConfirmLogin("admin", "secret123");

            // Assert
            Assert.That(Session.CurrentUser, Is.EqualTo(user));
        }


        private string Hash(string password)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}