using CustomControls.RJControls;
using LaCucina.DataLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaCucina.Models;

namespace LaCucina
{
    public class UserManagementService
    {
        public UserRepository repo = new UserRepository();
        public List<User> GetAllUsers()
        {
            return repo.GetAll();
        }
        public User GetUserById(int id)
        {
            return repo.GetById(id);
        }

        public string AddUser(
                string username,
                string password,
                string confirmPassword,
                Role role,
                bool isActive)
            {
                username = username.Trim();

                if (string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(confirmPassword))
                {
                    return "Fill all fields";
                }

                if (repo.GetByUsername(username) != null)
                {
                    return "Username already exists";
                }

                if (password != confirmPassword)
                {
                    return "Password mismatch";
                }

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

            private string HashPassword(string password)
            {
                using (var sha = System.Security.Cryptography.SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(password);

                    byte[] hash = sha.ComputeHash(bytes);

                    return Convert.ToBase64String(hash);
                }
            }

        public bool DeleteUser(int id)
        {
            User user = repo.GetById(id);

            if (user == null)
                return false;

            repo.Delete(id);

            return true;
        }
        public List<User> SearchUsers(List<User> users, string search)
        {
            search = search.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(search))
                return users;

            return users
                .Where(u => u.Username
                .ToLower()
                .StartsWith(search))
                .ToList();
        }

        public List<User> FilterByStatus(List<User> users, string status)
        {
            if (status == "Active")
                return users.Where(u => u.IsActive).ToList();

            if (status == "inActive")
                return users.Where(u => !u.IsActive).ToList();

            return users;
        }
        public List<User> FilterByRole(List<User> users, string role)
        {
            return users
                .Where(u => u.UserRole.ToString() == role)
                .ToList();
        }
        public bool UpdateUser(User user, string confirmPassword)
        {
            if (user == null)
                return false;

            if (string.IsNullOrWhiteSpace(user.Username))
            {
                MessageBox.Show("Username is required");

                return false;
            }

            User existing = repo.GetByUsername(user.Username);

            if (existing != null && existing.Id != user.Id)
            {
                MessageBox.Show("Username already exists");

                return false;
            }

            if (!string.IsNullOrWhiteSpace(user.PasswordHash))
            {
                if (user.PasswordHash != confirmPassword)
                {
                    MessageBox.Show("Password mismatch");

                    return false;
                }

                user.PasswordHash = HashPassword(user.PasswordHash);
            }
            else
            {
                User oldUser = repo.GetById(user.Id);

                user.PasswordHash = oldUser.PasswordHash;
            }

            repo.Update(user);

            return true;
        }
        
    }
}
