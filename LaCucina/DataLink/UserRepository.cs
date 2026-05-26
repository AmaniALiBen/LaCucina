using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LaCucina.DataLink
{
    public class UserRepository
    {
        // ================= GET ALL =================
        public List<User> GetAll()
        {
            string query = @"
            SELECT user_id, username, user_role, password_hash, is_active, is_deleted
            FROM users
            WHERE is_deleted = 0";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            List<User> users = new List<User>();

            foreach (DataRow row in dt.Rows)
            {
                users.Add(Map(row));
            }

            return users;
        }

        // ================= GET BY ID =================
        public User GetById(int id)
        {
            string query = @"
            SELECT user_id, username, user_role, password_hash, is_active, is_deleted
            FROM users
            WHERE user_id = " + id;

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            return Map(dt.Rows[0]);
        }

        // ================= GET BY USERNAME =================
        public User GetByUsername(string username)
        {
            string query = @"
            SELECT user_id, username, user_role, password_hash, is_active, is_deleted
            FROM users
            WHERE username = '" + username + @"' AND is_deleted = 0";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            return Map(dt.Rows[0]);
        }

        // ================= ADD =================
        public void Add(User user)
        {
            string query = $@"
            INSERT INTO users (username, user_role, password_hash, is_active, is_deleted)
            VALUES (
                '{user.Username}',
                {(int)user.UserRole},
                '{user.PasswordHash}',
                {(user.IsActive ? 1 : 0)},
                0
            )";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // ================= UPDATE =================
        public void Update(User user)
        {
            string query = $@"
            UPDATE users
            SET 
                username = '{user.Username}',
                user_role = {(int)user.UserRole},
                password_hash = '{user.PasswordHash}',
                is_active = {(user.IsActive ? 1 : 0)}
            WHERE user_id = {user.Id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // ================= DELETE (SOFT) =================
        public void Delete(int id)
        {
            string query = $@"
            UPDATE users
            SET is_deleted = 1
            WHERE user_id = {id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // ================= MAP =================
        private User Map(DataRow row)
        {
            return new User
            {
                Id = Convert.ToInt32(row["user_id"]),
                Username = row["username"].ToString(),
                UserRole = (User.Role)Convert.ToInt32(row["user_role"]),
                PasswordHash = row["password_hash"].ToString(),
                IsActive = Convert.ToBoolean(row["is_active"]),
                IsDeleted = Convert.ToBoolean(row["is_deleted"])
            };
        }
    }
}