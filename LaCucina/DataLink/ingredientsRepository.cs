using LaCucina;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; // أو Microsoft.Data.SqlClient حسب النسخة المستخدمة
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaCucina.Models; // تأكد من استدعاء مساحة الأسماء الخاصة بكلاس المكونات

namespace LaCucina
{
    public static class IngredientsRepository
    {
        // 🔹 1. Get all ingredients (not deleted)
        public static List<ingredients> GetAll()
        {
            string query = @"
            SELECT ingredient_id, ingredient_name, is_deleted
            FROM ingredients
            WHERE is_deleted = 0";

            return MapToList(query);
        }

        // 🔹 2. Get ingredient by id (for edit page)
        public static ingredients GetById(int id)
        {
            string query = $@"
            SELECT *
            FROM ingredients
            WHERE ingredient_id = {id}";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            bool isDeleted = row["is_deleted"] != DBNull.Value && Convert.ToBoolean(row["is_deleted"]);

            return new ingredients
            (
                (int)row["ingredient_id"],
                row["ingredient_name"].ToString(),
                isDeleted
            );
        }

        // 🔹 3. Search ingredients
        public static List<ingredients> Search(string keyword)
        {
            string query = $@"
            SELECT ingredient_id, ingredient_name, is_deleted
            FROM ingredients
            WHERE is_deleted = 0
            AND ingredient_name LIKE '%{keyword}%'";

            return MapToList(query);
        }

        // 🔹 4. Add ingredient
        public static int Add(string name)
        {
            string query = $@"
            INSERT INTO ingredients
            (ingredient_name, is_deleted)
            VALUES
            ('{name}', 0);
           SELECT SCOPE_IDENTITY();";

           object result =  DatabaseHelper.ExecuteScalar(query);
           

            return Convert.ToInt32(result);
        }

        // 🔹 5. Update ingredient
        public static void Update(ingredients ingredient)
        {
            string query = $@"
            UPDATE ingredients
            SET
                ingredient_name = '{ingredient.Name}'
            WHERE ingredient_id = {ingredient.Id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔹 6. Soft delete ingredient
        //public static void Delete(int id)
        //{
        //    string query = $@"
        //    UPDATE ingredients
        //    SET is_deleted = 1
        //    WHERE ingredient_id = {id}";

        //    DatabaseHelper.ExecuteNonQuery(query);
        //}
        public static bool DeleteIngredient(int ingredientId)
        {
            try
            {
                // 1. مسح العلاقات المرتبطة بالمكون من جدول الربط بناءً على التسمية الصحيحة في السكربت 🔥
                string deleteRelationsQuery = $@"DELETE FROM menu_item_ingredients 
                                         WHERE ingredient_id = {ingredientId}";
                DatabaseHelper.ExecuteNonQuery(deleteRelationsQuery);

                // 2. تحديث حالة المكون إلى محذوف ناعم (Soft Delete)
                string deleteIngredientQuery = $@"UPDATE ingredients 
                                          SET is_deleted = 1 
                                          WHERE ingredient_id = {ingredientId}";
                DatabaseHelper.ExecuteNonQuery(deleteIngredientQuery);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // 🔥 Helper: reuse mapping logic
        private static List<ingredients> MapToList(string query)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            List<ingredients> list = new List<ingredients>();

            foreach (DataRow row in dt.Rows)
            {
                bool isDeleted = row["is_deleted"] != DBNull.Value && Convert.ToBoolean(row["is_deleted"]);

                list.Add(new ingredients
                (
                    (int)row["ingredient_id"],
                    row["ingredient_name"].ToString(),
                    isDeleted
                ));
            }

            return list;
        }
    }
}