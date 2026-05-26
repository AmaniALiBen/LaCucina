using LaCucina;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina
{
    public static class ItemRepository
    {
        // 🔹 1. Get items by category (for cards)
        public static List<Item> GetByCategory(int categoryId)
        {
            string query = $@"
            SELECT menu_item_id, menu_item_name, price, category_id, is_active
            FROM menu_items
            WHERE category_id = {categoryId}
            AND is_deleted = 0";

            return MapToList(query);
        }

        // 🔹 2. Get item by id (for edit page)
        public static Item GetById(int id)
        {
            string query = $@"
            SELECT *
            FROM menu_items
            WHERE menu_item_id = {id}";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Item
            (
                 (int)row["menu_item_id"],
                    row["menu_item_name"].ToString(),
                     (int)row["category_id"],
                     Convert.ToDouble(row["price"]),
                    (bool)row["is_active"]
                
            );
        }

        // 🔹 3. Get active items only (POS menu)
        public static List<Item> GetActiveItems()
        {
            string query = @"
            SELECT menu_item_id, menu_item_name, price, category_id, is_active
            FROM menu_items
            WHERE is_active = 1
            AND is_deleted = 0
            AND (disabled_until IS NULL OR GETDATE() >= disabled_until)"; // تصفية ذكية حية

            return MapToList(query);
        }

        // 🔹 4. Search items
        public static List<Item> Search(string keyword)
        {
            string query = $@"
            SELECT menu_item_id, menu_item_name, price, category_id, is_active
            FROM menu_items
            WHERE is_deleted = 0
            AND menu_item_name LIKE '%{keyword}%'";

            return MapToList(query);
        }

        // 🔹 5. Add item
        public static int Add(Item item)
        {
            string query = $@"INSERT INTO menu_items (menu_item_name, category_id, price, is_active,is_deleted) 
                      VALUES ('{item.Name}', {item.CategoryId}, {item.Price}, {(item.IsActive ? 1 : 0)},0);
                      SELECT SCOPE_IDENTITY();";

            object result = DatabaseHelper.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }

        // 🔹 6. Update item
        public static void Update(Item item)
        {
            string query = $@"
            UPDATE menu_items
            SET
                menu_item_name = '{item.Name}',
                price = {item.Price},
                category_id = {item.CategoryId},
                is_active = {(item.IsActive ? 1 : 0)}
            WHERE menu_item_id = {item.Id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔹 7. Soft delete
        public static void Delete(int id)
        {
            string query = $@"
            UPDATE menu_items
            SET is_deleted = 1
            WHERE menu_item_id = {id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔹 8. Toggle active
        //public static void ToggleActive(int id)
        //{
        //    string query = $@"
        //    UPDATE menu_items
        //    SET is_active = CASE WHEN is_active = 1 THEN 0 ELSE 1 END
        //    WHERE menu_item_id = {id}";

        //    DatabaseHelper.ExecuteNonQuery(query);
        //}

        public static void DisableItemForToday(int menuItemId)
        {
            DateTime nextWorkingDay = DateTime.Today.AddDays(1).AddHours(8);

            string query = $@"UPDATE menu_items 
                      SET disabled_until = '{nextWorkingDay:yyyy-MM-dd HH:mm:ss}' 
                      WHERE menu_item_id = {menuItemId}";

            DatabaseHelper.ExecuteNonQuery(query);
        }


        public static void EnableItemManually(int menuItemId)
        {
            string query = $@"UPDATE menu_items SET disabled_until = NULL WHERE menu_item_id = {menuItemId}";
            DatabaseHelper.ExecuteNonQuery(query);
        }
        public static List<Item> GetByCategoryForChef(int categoryId)
        {
            // تجلب كل الأصناف في القسم (نشط أو غير نشط) مع قراءة عمود وقت الإيقاف لليوم
            string query = $@"
            SELECT menu_item_id, menu_item_name, price, category_id, is_active, disabled_until
            FROM menu_items
            WHERE category_id = {categoryId}
            AND is_deleted = 0";

            return MapToList(query);
        }

        // 🔥 Helper: تم تعديله ليدعم قراءة التاريخ بأمان دون التأثير على الدوال القديمة
        private static List<Item> MapToList(string query)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<Item> items = new List<Item>();

            foreach (DataRow row in dt.Rows)
            {
                Item item = new Item
                (
                    (int)row["menu_item_id"],
                    row["menu_item_name"].ToString(),
                    (int)row["category_id"],
                    Convert.ToDouble(row["price"]),
                    (bool)row["is_active"]
                );

                // فحص أمان: إذا كان الاستعلام يحتوي على عمود disabled_until وقيمته ليست فارغة
                if (dt.Columns.Contains("disabled_until") && row["disabled_until"] != DBNull.Value)
                {
                    item.DisabledUntil = Convert.ToDateTime(row["disabled_until"]);
                }
                else
                {
                    item.DisabledUntil = null;
                }

                items.Add(item);
            }

            return items;
        }
    }
}

