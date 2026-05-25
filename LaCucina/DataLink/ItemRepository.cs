using LaCucina;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Item> GetActiveItems()
        {
            string query = @"
            SELECT menu_item_id, menu_item_name, price, category_id, is_active
            FROM menu_items
            WHERE is_active = 1
            AND is_deleted = 0";

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
        public void Add(Item item)
        {
            string query = $@"
            INSERT INTO menu_items
            (menu_item_name, price, category_id, is_active, is_deleted)
            VALUES
            ('{item.Name}', {item.Price}, {item.CategoryId}, 1, 0)";

            DatabaseHelper.ExecuteNonQuery(query);
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

        // 🔹 8. Toggle active
        public void ToggleActive(int id)
        {
            string query = $@"
            UPDATE menu_items
            SET is_active = CASE WHEN is_active = 1 THEN 0 ELSE 1 END
            WHERE menu_item_id = {id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔥 Helper: reuse mapping logic
        private List<Item> MapToList(string query)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            List<Item> items = new List<Item>();

            foreach (DataRow row in dt.Rows)
            {
                items.Add(new Item
                (
                    (int)row["menu_item_id"],
                    row["menu_item_name"].ToString(),
                     (int)row["category_id"],
                    Convert.ToDouble( row["price"]),
                    (bool)row["is_active"]
                ));
            }

            return items;
        }
    }
}

