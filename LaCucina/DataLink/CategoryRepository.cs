using LaCucina;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LaCucina
{
 
    public class CategoryRepository
    {
        public DataTable GetAll()
        {
            string query = "SELECT * FROM categories";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public void Add(string name)
        {
            string query =
                $"INSERT INTO categories (category_name) VALUES ('{name}')";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        public void Delete(int id)
        {
            string query =
                $"DELETE FROM categories WHERE category_id = {id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }
    }
}
