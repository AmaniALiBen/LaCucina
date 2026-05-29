using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaCucina.Models;

namespace LaCucina
{
    public class User
    {
       
        public int Id { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public Role UserRole { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public User()
        {
        }

        public User(int id,string username, string passwordHash, Role role, bool isActive)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            UserRole = role;
            IsActive = isActive;
            IsDeleted = false;
        }
    }
}
