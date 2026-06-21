using LaCucina.DataLink;
using LaCucina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaCucina
{
    public class UserManagementService
    {
        public UserRepository repo;

        public UserManagementService() : this(new UserRepository()) { }

        public UserManagementService(UserRepository repo)
        {
            this.repo = repo;
        }

        public List<User> GetAllUsers() => repo.GetAll();

        public User GetUserById(int id) => repo.GetById(id);

        public string AddUser(string username, string password, string confirmPassword, Role role, bool isActive)
        {
            username = username.Trim();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
                return "Fill all fields";

            if (repo.GetByUsername(username) != null)
                return "Username already exists";

            if (password != confirmPassword)
                return "Password mismatch";

            User user = new User
            {
                Username = username,
                PasswordHash = HashPassword(password),
                UserRole = role,
                IsActive = isActive,
                IsDeleted = false
            };

            repo.Add(user);
            return null;
        }

        public bool DeleteUser(int id)
        {
            User user = repo.GetById(id);
            if (user == null) return false;
            repo.Delete(id);
            return true;
        }

        public List<User> SearchUsers(List<User> users, string search)
        {
            search = search.ToLower().Trim();
            if (string.IsNullOrWhiteSpace(search)) return users;
            return users.Where(u => u.Username.ToLower().StartsWith(search)).ToList();
        }

        public List<User> FilterByStatus(List<User> users, string status)
        {
            if (status == "Active") return users.Where(u => u.IsActive).ToList();
            if (status == "inActive") return users.Where(u => !u.IsActive).ToList();
            return users;
        }

        public List<User> FilterByRole(List<User> users, string role)
        {
            return users.Where(u => u.UserRole.ToString() == role).ToList();
        }

        public (bool success, string error) UpdateUser(User user, string confirmPassword)
        {
            if (user == null) return (false, "User is null");

            if (string.IsNullOrWhiteSpace(user.Username))
                return (false, "Username is required");

            User existing = repo.GetByUsername(user.Username);
            if (existing != null && existing.Id != user.Id)
                return (false, "Username already exists");

            if (!string.IsNullOrWhiteSpace(user.PasswordHash))
            {
                if (user.PasswordHash != confirmPassword)
                    return (false, "Password mismatch");

                user.PasswordHash = HashPassword(user.PasswordHash);
            }
            else
            {
                User oldUser = repo.GetById(user.Id);
                user.PasswordHash = oldUser.PasswordHash;
            }

            repo.Update(user);
            return (true, null);
        }

        private string HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}