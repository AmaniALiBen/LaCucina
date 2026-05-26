using LaCucina;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaCucina.Models; // تأكد من وجود كلاس Categories داخل مساحة الأسماء هذه

namespace LaCucina
{
    public static class CategoryRepository
    {
        // 🔹 1. Get all active categories (List)
        public static List<Categories> GetAll()
        {
            // جلب التصنيفات غير المحذوفة (إذا كنت قد أضفت عمود الحذف الناعم)
            string query = "SELECT category_id, category_name FROM categories";

            return MapToList(query);
        }

        // 🔹 2. Get category by id
        public static Categories GetById(int id)
        {
            string query = $"SELECT category_id, category_name FROM categories WHERE category_id = {id}";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            return new Categories
            (
                (int)row["category_id"],
                row["category_name"].ToString()
            );
        }

        // 🔹 3. Add new category
        public static void Add(String name)
        {
            string query = $"INSERT INTO categories (category_name) VALUES ('{name}')";
            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔹 4. Delete category (يفضل مراجعة طريقة الحذف لتجنب الـ Foreign Key Error)
        public static void Delete(int id)
        {
            string query = $"DELETE FROM categories WHERE category_id = {id}";
            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔹 5. Update category name
        public static void Update(Categories category)
        {
            string query = $"UPDATE categories SET category_name = '{category.name}' WHERE category_id = {category.id}";
            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔥 Helper: reuse mapping logic
        private static List<Categories> MapToList(string query)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<Categories> list = new List<Categories>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Categories
                (
                    (int)row["category_id"],
                    row["category_name"].ToString()
                ));
            }

            return list;
        }
    }
}