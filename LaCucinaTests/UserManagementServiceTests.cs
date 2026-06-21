using LaCucina;
using LaCucina.DataLink;
using LaCucina.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace LaCucinaTests
{
    [TestFixture]
    public class UserManagementServiceTests
    {
        private Mock<UserRepository> mockRepo;
        private UserManagementService service;

        private User MakeUser(int id, string username, bool isActive = true, Role role = Role.Waiter)
            => new User { Id = id, Username = username, IsActive = isActive, UserRole = role, IsDeleted = false, PasswordHash = "hash" };

        [SetUp]
        public void Setup()
        {
            mockRepo = new Mock<UserRepository>();
            service = new UserManagementService(mockRepo.Object);
        }

        // ── GetAllUsers ──────────────────────────────────────────────────

        [Test]
        public void GetAllUsers_ReturnsAllUsers()
        {
            var users = new List<User> { MakeUser(1, "alice"), MakeUser(2, "bob") };
            mockRepo.Setup(r => r.GetAll()).Returns(users);

            var result = service.GetAllUsers();

            Assert.That(result.Count, Is.EqualTo(2));
        }

        // ── GetUserById ──────────────────────────────────────────────────

        [Test]
        public void GetUserById_ExistingId_ReturnsUser()
        {
            mockRepo.Setup(r => r.GetById(1)).Returns(MakeUser(1, "alice"));

            var result = service.GetUserById(1);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Username, Is.EqualTo("alice"));
        }

        [Test]
        public void GetUserById_NotFound_ReturnsNull()
        {
            mockRepo.Setup(r => r.GetById(99)).Returns((User)null);

            var result = service.GetUserById(99);

            Assert.That(result, Is.Null);
        }

        // ── AddUser ──────────────────────────────────────────────────────

        [Test]
        public void AddUser_ValidData_ReturnsNull()
        {
            mockRepo.Setup(r => r.GetByUsername("alice")).Returns((User)null);

            var result = service.AddUser("alice", "pass123", "pass123", Role.Waiter, true);

            Assert.That(result, Is.Null);
            mockRepo.Verify(r => r.Add(It.IsAny<User>()), Times.Once);
        }

        [Test]
        public void AddUser_EmptyUsername_ReturnsError()
        {
            var result = service.AddUser("  ", "pass123", "pass123", Role.Waiter, true);

            Assert.That(result, Is.EqualTo("Fill all fields"));
            mockRepo.Verify(r => r.Add(It.IsAny<User>()), Times.Never);
        }

        [Test]
        public void AddUser_EmptyPassword_ReturnsError()
        {
            var result = service.AddUser("alice", "", "pass123", Role.Waiter, true);

            Assert.That(result, Is.EqualTo("Fill all fields"));
            mockRepo.Verify(r => r.Add(It.IsAny<User>()), Times.Never);
        }

        [Test]
        public void AddUser_DuplicateUsername_ReturnsError()
        {
            mockRepo.Setup(r => r.GetByUsername("alice")).Returns(MakeUser(1, "alice"));

            var result = service.AddUser("alice", "pass123", "pass123", Role.Waiter, true);

            Assert.That(result, Is.EqualTo("Username already exists"));
            mockRepo.Verify(r => r.Add(It.IsAny<User>()), Times.Never);
        }

        [Test]
        public void AddUser_PasswordMismatch_ReturnsError()
        {
            mockRepo.Setup(r => r.GetByUsername("alice")).Returns((User)null);

            var result = service.AddUser("alice", "pass123", "different", Role.Waiter, true);

            Assert.That(result, Is.EqualTo("Password mismatch"));
            mockRepo.Verify(r => r.Add(It.IsAny<User>()), Times.Never);
        }

        [Test]
        public void AddUser_TrimsUsername_BeforeValidation()
        {
            mockRepo.Setup(r => r.GetByUsername("alice")).Returns((User)null);

            var result = service.AddUser("  alice  ", "pass123", "pass123", Role.Waiter, true);

            Assert.That(result, Is.Null);
            mockRepo.Verify(r => r.Add(It.Is<User>(u => u.Username == "alice")), Times.Once);
        }

        // 🔴 INTENTIONALLY FAILING: AddUser does `username.Trim()` before
        // checking for null, so a null username throws a
        // NullReferenceException instead of returning "Fill all fields".
        [Test]
        public void AddUser_NullUsername_ReturnsError()
        {
            var result = service.AddUser(null, "pass123", "pass123", Role.Waiter, true);

            Assert.That(result, Is.EqualTo("Fill all fields"));
            mockRepo.Verify(r => r.Add(It.IsAny<User>()), Times.Never);
        }

        // ── DeleteUser ───────────────────────────────────────────────────

        [Test]
        public void DeleteUser_ExistingUser_ReturnsTrue()
        {
            mockRepo.Setup(r => r.GetById(1)).Returns(MakeUser(1, "alice"));

            var result = service.DeleteUser(1);

            Assert.That(result, Is.True);
            mockRepo.Verify(r => r.Delete(1), Times.Once);
        }

        [Test]
        public void DeleteUser_NotFound_ReturnsFalse()
        {
            mockRepo.Setup(r => r.GetById(99)).Returns((User)null);

            var result = service.DeleteUser(99);

            Assert.That(result, Is.False);
            mockRepo.Verify(r => r.Delete(It.IsAny<int>()), Times.Never);
        }

        // ── SearchUsers ──────────────────────────────────────────────────

        [Test]
        public void SearchUsers_MatchingPrefix_ReturnsFiltered()
        {
            var users = new List<User> { MakeUser(1, "alice"), MakeUser(2, "bob"), MakeUser(3, "albert") };

            var result = service.SearchUsers(users, "al");

            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void SearchUsers_EmptySearch_ReturnsAll()
        {
            var users = new List<User> { MakeUser(1, "alice"), MakeUser(2, "bob") };

            var result = service.SearchUsers(users, "");

            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void SearchUsers_NoMatch_ReturnsEmpty()
        {
            var users = new List<User> { MakeUser(1, "alice"), MakeUser(2, "bob") };

            var result = service.SearchUsers(users, "xyz");

            Assert.That(result.Count, Is.EqualTo(0));
        }

        // 🔴 INTENTIONALLY FAILING: `search.ToLower()` runs before any null
        // check, so a null search term throws a NullReferenceException
        // instead of being treated like an empty search.
        [Test]
        public void SearchUsers_NullSearchTerm_DoesNotThrow()
        {
            var users = new List<User> { MakeUser(1, "alice"), MakeUser(2, "bob") };

            Assert.DoesNotThrow(new TestDelegate(() => service.SearchUsers(users, null)));
        }

        // 🔴 INTENTIONALLY FAILING: `users.Where(...)` is called directly on
        // the list with no null guard, so a null user list throws an
        // ArgumentNullException instead of returning an empty result.
        [Test]
        public void SearchUsers_NullUserList_DoesNotThrow()
        {
            Assert.DoesNotThrow(new TestDelegate(() => service.SearchUsers(null, "al")));
        }

        // ── FilterByStatus ───────────────────────────────────────────────

        [Test]
        public void FilterByStatus_Active_ReturnsOnlyActive()
        {
            var users = new List<User> { MakeUser(1, "alice", true), MakeUser(2, "bob", false) };

            var result = service.FilterByStatus(users, "Active");

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].Username, Is.EqualTo("alice"));
        }

        [Test]
        public void FilterByStatus_Inactive_ReturnsOnlyInactive()
        {
            var users = new List<User> { MakeUser(1, "alice", true), MakeUser(2, "bob", false) };

            var result = service.FilterByStatus(users, "inActive");

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].Username, Is.EqualTo("bob"));
        }

        [Test]
        public void FilterByStatus_All_ReturnsAll()
        {
            var users = new List<User> { MakeUser(1, "alice", true), MakeUser(2, "bob", false) };

            var result = service.FilterByStatus(users, "All");

            Assert.That(result.Count, Is.EqualTo(2));
        }

        // 🔴 INTENTIONALLY FAILING: when status is "Active" or "inActive",
        // `users.Where(...)` is called with no null guard on the list, so a
        // null user list throws an ArgumentNullException.
        [Test]
        public void FilterByStatus_NullList_DoesNotThrow()
        {
            Assert.DoesNotThrow(new TestDelegate(() => service.FilterByStatus(null, "Active")));
        }

        // ── FilterByRole ─────────────────────────────────────────────────

        [Test]
        public void FilterByRole_Waiter_ReturnsOnlyWaiters()
        {
            var users = new List<User>
            {
                MakeUser(1, "alice", true, Role.Waiter),
                MakeUser(2, "bob",   true, Role.Chef),
                MakeUser(3, "carol", true, Role.Waiter)
            };

            var result = service.FilterByRole(users, "Waiter");

            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void FilterByRole_Chef_ReturnsOnlyChefs()
        {
            var users = new List<User>
            {
                MakeUser(1, "alice", true, Role.Waiter),
                MakeUser(2, "bob",   true, Role.Chef)
            };

            var result = service.FilterByRole(users, "Chef");

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].Username, Is.EqualTo("bob"));
        }

        // ── UpdateUser ───────────────────────────────────────────────────

        [Test]
        public void UpdateUser_NullUser_ReturnsFalse()
        {
            var (success, error) = service.UpdateUser(null, "pass");

            Assert.That(success, Is.False);
        }

        [Test]
        public void UpdateUser_EmptyUsername_ReturnsFalse()
        {
            var user = MakeUser(1, "");

            var (success, error) = service.UpdateUser(user, "pass");

            Assert.That(success, Is.False);
            Assert.That(error, Is.EqualTo("Username is required"));
        }

        [Test]
        public void UpdateUser_DuplicateUsername_ReturnsFalse()
        {
            var user = MakeUser(1, "alice");
            mockRepo.Setup(r => r.GetByUsername("alice")).Returns(MakeUser(2, "alice"));

            var (success, error) = service.UpdateUser(user, "pass");

            Assert.That(success, Is.False);
            Assert.That(error, Is.EqualTo("Username already exists"));
        }

        [Test]
        public void UpdateUser_PasswordMismatch_ReturnsFalse()
        {
            var user = MakeUser(1, "alice");
            user.PasswordHash = "newpass";
            mockRepo.Setup(r => r.GetByUsername("alice")).Returns((User)null);

            var (success, error) = service.UpdateUser(user, "different");

            Assert.That(success, Is.False);
            Assert.That(error, Is.EqualTo("Password mismatch"));
        }

        [Test]
        public void UpdateUser_ValidWithNewPassword_ReturnsTrue()
        {
            var user = MakeUser(1, "alice");
            user.PasswordHash = "newpass";
            mockRepo.Setup(r => r.GetByUsername("alice")).Returns((User)null);

            var (success, error) = service.UpdateUser(user, "newpass");

            Assert.That(success, Is.True);
            mockRepo.Verify(r => r.Update(user), Times.Once);
        }

        [Test]
        public void UpdateUser_NoPasswordChange_KeepsOldHash()
        {
            var user = MakeUser(1, "alice");
            user.PasswordHash = "";
            var oldUser = MakeUser(1, "alice");
            oldUser.PasswordHash = "oldhash";

            mockRepo.Setup(r => r.GetByUsername("alice")).Returns((User)null);
            mockRepo.Setup(r => r.GetById(1)).Returns(oldUser);

            var (success, _) = service.UpdateUser(user, "");

            Assert.That(success, Is.True);
            Assert.That(user.PasswordHash, Is.EqualTo("oldhash"));
            mockRepo.Verify(r => r.Update(user), Times.Once);
        }

        // 🔴 INTENTIONALLY FAILING: when no password change is requested,
        // the service looks up the old user by Id to keep the existing hash.
        // If that lookup returns null (deleted/stale Id), the code throws a
        // NullReferenceException on `oldUser.PasswordHash` instead of
        // returning (false, "User not found").
        [Test]
        public void UpdateUser_UserDoesNotExist_ReturnsFalse()
        {
            var user = MakeUser(99, "alice");
            user.PasswordHash = "";

            mockRepo.Setup(r => r.GetByUsername("alice")).Returns((User)null);
            mockRepo.Setup(r => r.GetById(99)).Returns((User)null);

            var (success, _) = service.UpdateUser(user, "");

            Assert.That(success, Is.False);
            mockRepo.Verify(r => r.Update(It.IsAny<User>()), Times.Never);
        }
    }
}