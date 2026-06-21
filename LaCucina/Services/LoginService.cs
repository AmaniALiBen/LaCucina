using LaCucina.DataLink;
using System;
using System.Security.Cryptography;
using System.Text;

namespace LaCucina.Services
{
    public class LoginService
    {
        private readonly UserRepository repo;

        public LoginService() : this(new UserRepository()) { }

        public LoginService(UserRepository repo)
        {
            this.repo = repo;
        }

        public User ConfirmLogin(string username, string password)
        {
            User user = repo.GetByUsername(username);

            if (user == null)
                return null;

            if (user.IsDeleted || !user.IsActive)
                return null;

            string hashedInput = HashPassword(password);

            if (hashedInput != user.PasswordHash)
                return null;

            Session.CurrentUser = user;
            return user;
        }

       

        private string HashPassword(string password)
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