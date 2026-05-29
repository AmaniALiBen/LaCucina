using LaCucina;
using LaCucina.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public class ItemRepository
    {
        // 🔹 1. Get items by category (for cards)
        public List<Item> GetByCategory(int categoryId)
        {
            string query = $@"
            SELECT menu_item_id, menu_item_name, price, category_id, is_active
            FROM menu_items
            WHERE category_id = {categoryId}
            AND is_deleted = 0";

            return MapToList(query);
        }

        // 🔹 2. Get item by id (for edit page)
        public Item GetById(int id)
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
        public List<Item> GetActiveItemsByCategory(int categoryId)
        {
            string query = $@"
            SELECT menu_item_id, menu_item_name, price, category_id, is_active
            FROM menu_items
            WHERE is_active = 1
            AND is_deleted = 0
            AND category_id = {categoryId}
            AND (disabled_until IS NULL OR GETDATE() >= disabled_until)";

            return MapToList(query);
        }

        // 🔹 4. Search items
        public List<Item> Search(string keyword)
        {
            string query = $@"
            SELECT menu_item_id, menu_item_name, price, category_id, is_active
            FROM menu_items
            WHERE is_deleted = 0
            AND menu_item_name LIKE '%{keyword}%'";

            return MapToList(query);
        }

        // 🔹 5. Add item
        public int Add(Item item)
        {
            string query = $@"INSERT INTO menu_items (menu_item_name, category_id, price, is_active,is_deleted) 
                              VALUES ('{item.Name}', {item.CategoryId}, {item.Price}, {(item.IsActive ? 1 : 0)},0);
                              SELECT SCOPE_IDENTITY();";

            object result = DatabaseHelper.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }

        // 🔹 6. Update item
        public void Update(Item item)
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
        public void Delete(int id)
        {
            string query = $@"
            UPDATE menu_items
            SET is_deleted = 1
            WHERE menu_item_id = {id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        public void DisableItemForToday(int menuItemId)
        {
            DateTime nextWorkingDay = DateTime.Today.AddDays(1).AddHours(8);

            string query = $@"UPDATE menu_items 
                              SET disabled_until = '{nextWorkingDay:yyyy-MM-dd HH:mm:ss}' 
                              WHERE menu_item_id = {menuItemId}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        public void EnableItemManually(int menuItemId)
        {
            string query = $@"UPDATE menu_items SET disabled_until = NULL WHERE menu_item_id = {menuItemId}";
            DatabaseHelper.ExecuteNonQuery(query);
        }

        public List<Item> GetByCategoryForChef(int categoryId)
        {
            string query = $@"
            SELECT menu_item_id, menu_item_name, price, category_id, is_active, disabled_until
            FROM menu_items
            WHERE category_id = {categoryId}
            AND is_deleted = 0 AND is_active= 1";

            return MapToList(query);
        }

        public ItemDetails GetItemDetailsWithIngredients(int menuItemId)
        {
            ItemDetails details = new ItemDetails();

            string query = $@"
            SELECT mi.menu_item_name, ing.ingredient_id, ing.ingredient_name, mii.is_main_ingredient
            FROM menu_items mi
            LEFT JOIN menu_item_ingredients mii ON mi.menu_item_id = mii.menu_item_id
            LEFT JOIN ingredients ing ON mii.ingredient_id = ing.ingredient_id
            WHERE mi.menu_item_id = {menuItemId} AND mi.is_deleted = 0";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                details.ItemName = dt.Rows[0]["menu_item_name"].ToString();

                foreach (DataRow row in dt.Rows)
                {
                    if (row["ingredient_name"] != DBNull.Value && row["ingredient_id"] != DBNull.Value)
                    {
                        MemoryIngredientRemoved selection = new MemoryIngredientRemoved();
                        selection.IngredientId = Convert.ToInt32(row["ingredient_id"]);
                        selection.IngredientName = row["ingredient_name"].ToString();
                        selection.IsChecked = true;

                        bool isMain = Convert.ToBoolean(row["is_main_ingredient"]);

                        if (isMain)
                        {
                            details.MainIngredients.Add(selection);
                        }
                        else
                        {
                            details.ExtraIngredients.Add(selection);
                        }
                    }
                }
            }
            return details;
        }

        // 🌟 تحديث دالة الحفظ والـ Send (تتعامل بالسعر الكامل ولا تفرض خصومات أثناء تعليق الطلب)
       

        private List<Item> MapToList(string query)
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