using LaCucina;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaCucina.Models; // تأكد من استدعاء مساحة الأسماء الخاصة بكلاس الموديلات

namespace LaCucina.DataLink
{
    public static class menuItemIngredientsRepository
    {
        // 🔹 جلب كافة سجلات ربط المكونات بالوجبات في المنظومة
        public static List<menu_item_ingredients> GetAll()
        {
            string query = "SELECT ingredient_id, menu_item_id, is_main_ingredient FROM menu_item_ingredients";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<menu_item_ingredients> list = new List<menu_item_ingredients>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new menu_item_ingredients
                (
                   
                    itemId: Convert.ToInt32(row["menu_item_id"]),
                    ingredientId: Convert.ToInt32(row["ingredient_id"]),
                    isMain: Convert.ToBoolean(row["is_main_ingredient"])
                ));
            }

            return list;
        }
        // 🔹 1. Get all ingredients for a specific menu item (جلب مكونات وجبة معينة)
        public static List<menu_item_ingredients> GetByMenuItem(int menuItemId)
        {
            string query = $@"
            SELECT ingredient_id, menu_item_id, is_main_ingredient
            FROM menu_item_ingredients
            WHERE menu_item_id = {menuItemId}";

            return MapToList(query);
        }

        // 🔹 2. Add an ingredient to a menu item (ربط مكون بوجبة)
        public static void Add(menu_item_ingredients item)
        {
            string query = $@"
            INSERT INTO menu_item_ingredients
            (ingredient_id, menu_item_id, is_main_ingredient)
            VALUES
            ({item.IngredientId}, {item.ItemId}, {(item.IsMain ? 1 : 0)})";

           DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔹 3. Remove an ingredient from a menu item (حذف مكون من وجبة)
        public static void Delete(int ingredientId, int menuItemId)
        {
            // لأن الجدول يعتمد على مفتاح مركب، نحذف بشرط الـ ID للوجبة والمكون معاً
            string query = $@"
            DELETE FROM menu_item_ingredients 
            WHERE ingredient_id = {ingredientId} 
            AND menu_item_id = {menuItemId}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔹 4. Remove all ingredients for a specific item (مسح كل المكونات لوجبة معينة - مفيد عند التعديل)
        public static void DeleteAllByMenuItem(int menuItemId)
        {
            string query = $"DELETE FROM menu_item_ingredients WHERE menu_item_id = {menuItemId}";
            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔥 Helper: reuse mapping logic
        private static List<menu_item_ingredients> MapToList(string query)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            List<menu_item_ingredients> list = new List<menu_item_ingredients>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new menu_item_ingredients
                (
                   
                    itemId: (int)row["menu_item_id"],
                    ingredientId: (int)row["ingredient_id"],
                    isMain: Convert.ToBoolean(row["is_main_ingredient"])
                ));
            }

            return list;
        }
    }
}