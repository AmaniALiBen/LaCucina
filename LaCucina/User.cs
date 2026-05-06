using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina
{
    public class User
    {
       public enum Role
        { Admin,
          Owner,
          Waiter,
          Chef

        };
        public Role role; 
        public bool isActive;
        public string username;
        public string password;
        public bool isDeleted;
       public  User(string username,string password,bool isActive , Role role,bool isDeleted)
        {
            this.username = username;  
            this.password = password;
            this.isActive = isActive;
            this.role = role;
            this.isDeleted = isDeleted;
        }
    }
}
