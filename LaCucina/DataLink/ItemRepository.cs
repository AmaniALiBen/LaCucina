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
        public bool SaveFullOrderTransaction(
            int tableId,
            int userId,
            List<MemoryOrderItem> items,
            double subTotalAmount,
            double finalTotalAmount,
            int? discountId,
            byte? discountType,
            double discountAmountValue,
            bool isTakeAway,
            out int generatedOrderId)
        {
            generatedOrderId = -1;

            string sqlTableId = (isTakeAway || tableId <= 0) ? "NULL" : tableId.ToString();
            string sqlDiscountId = (discountId.HasValue && discountId.Value > 0) ? discountId.Value.ToString() : "NULL";
            string sqlDiscountType = (discountType.HasValue && sqlDiscountId != "NULL") ? discountType.Value.ToString() : "NULL";
            string sqlDiscountValue = sqlDiscountId == "NULL" ? "NULL" : discountAmountValue.ToString(System.Globalization.CultureInfo.InvariantCulture);

            string formattedSubTotal = subTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
            string formattedFinalTotal = finalTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);

            int orderStatus = isTakeAway ? 1 : 0;
            int is_takeaway = isTakeAway ? 1 : 0;
            try
            {
                if (!isTakeAway && items.Count == 0 && tableId > 0)
                {
                    string checkQuery = $@"SELECT order_id FROM orders WHERE table_id = {tableId} AND order_status = 0";
                    DataTable dtCheck = DatabaseHelper.ExecuteQuery(checkQuery);
                    if (dtCheck != null && dtCheck.Rows.Count > 0)
                    {
                        generatedOrderId = Convert.ToInt32(dtCheck.Rows[0]["order_id"]);
                        // نقوم بتحديث لقطة الحساب النهائي والخصم للطلب المفتوح حالياً
                        return UpdateOrderDiscountDetails(generatedOrderId, subTotalAmount, finalTotalAmount, discountId, discountType, discountAmountValue);
                    }
                    return false;
                }

                if (isTakeAway)
                {
                    // [حالة التيك أواي]: تنزل الفاتورة فوراً بالقيم النهائية والخصم المطبق
                    string orderQuery = $@"
                    INSERT INTO orders (table_id, user_id, order_status, created_at, discount_id, discount_type, discount_amount, sub_total, total_amount,is_takeaway)
                    VALUES (NULL, {userId}, {orderStatus}, GETDATE(), {sqlDiscountId}, {sqlDiscountType}, {sqlDiscountValue}, {formattedSubTotal}, {formattedFinalTotal},{is_takeaway});
                    SELECT SCOPE_IDENTITY();";

                    DataTable dtOrder = DatabaseHelper.ExecuteQuery(orderQuery);
                    if (dtOrder == null || dtOrder.Rows.Count == 0) return false;

                    generatedOrderId = Convert.ToInt32(dtOrder.Rows[0][0]);
                    SaveOrderItemsAndIngredients(generatedOrderId, items, "NULL");
                }
                else
                {
                    // [حالة الصالة - زر الـ Send]:
                    string checkQuery = $@"SELECT order_id FROM orders WHERE table_id = {tableId} AND order_status = 0";
                    DataTable dtCheck = DatabaseHelper.ExecuteQuery(checkQuery);

                    if (dtCheck != null && dtCheck.Rows.Count > 0)
                    {
                        generatedOrderId = Convert.ToInt32(dtCheck.Rows[0]["order_id"]);

                        // عند إضافة وجبات جديدة للمطبخ، نزيد الـ sub_total والـ total_amount بالسعر الكامل 
                        // بدون تطبيق الخصم (لأن الخصم سيُعاد حسابه بالكامل وتحديثه لحظة الضغط على Pay)
                        string updateOrderQuery = $@"
                        UPDATE orders 
                        SET sub_total = sub_total + {formattedSubTotal},
                            total_amount = total_amount + {formattedFinalTotal}
                        WHERE order_id = {generatedOrderId}";

                        DatabaseHelper.ExecuteNonQuery(updateOrderQuery);
                    }
                    else
                    {
                        // إنشاء فاتورة صالة جديدة لأول مرة (تنزل بالسعر الكامل وبدون خصم)
                        string orderQuery = $@"
                        INSERT INTO orders (table_id, user_id, order_status, created_at, discount_id, discount_type, discount_amount, sub_total, total_amount,is_takeaway)
                        VALUES ({sqlTableId}, {userId}, {orderStatus}, GETDATE(), NULL, NULL, NULL, {formattedSubTotal}, {formattedFinalTotal},{is_takeaway});
                        SELECT SCOPE_IDENTITY();";

                        DataTable dtOrder = DatabaseHelper.ExecuteQuery(orderQuery);
                        if (dtOrder == null || dtOrder.Rows.Count == 0) return false;

                        generatedOrderId = Convert.ToInt32(dtOrder.Rows[0][0]);
                    }

                    // فتح باتش المطبخ للأصناف المرسلة حديثاً
                    string batchQuery = $@"
                    INSERT INTO order_batches (sent_at, order_id, batch_status) 
                    VALUES (GETDATE(), {generatedOrderId}, 0);
                    SELECT SCOPE_IDENTITY();";

                    DataTable dtBatch = DatabaseHelper.ExecuteQuery(batchQuery);
                    if (dtBatch == null || dtBatch.Rows.Count == 0) return false;

                    string batchIdString = dtBatch.Rows[0][0].ToString();
                    SaveOrderItemsAndIngredients(generatedOrderId, items, batchIdString);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in SaveFullOrderTransaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 🌟 دالة مساعدة جديدة: لتحديث تفاصيل الخصم الإجمالية للفاتورة لحظة الدفع الفعلي
        public bool UpdateOrderDiscountDetails(int orderId, double subTotal, double finalTotal, int? discountId, byte? discountType, double discountAmountValue)
        {
            try
            {
                string sqlDiscountId = (discountId.HasValue && discountId.Value > 0) ? discountId.Value.ToString() : "NULL";
                string sqlDiscountType = (discountType.HasValue && sqlDiscountId != "NULL") ? discountType.Value.ToString() : "NULL";
                string sqlDiscountValue = sqlDiscountId == "NULL" ? "0" : discountAmountValue.ToString(System.Globalization.CultureInfo.InvariantCulture);

                string formattedSubTotal = subTotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
                string formattedFinalTotal = finalTotal.ToString(System.Globalization.CultureInfo.InvariantCulture);

                string query = $@"
                UPDATE orders 
                SET sub_total = {formattedSubTotal},
                    total_amount = {formattedFinalTotal},
                    discount_id = {sqlDiscountId},
                    discount_type = {sqlDiscountType},
                    discount_amount = {sqlDiscountValue}
                WHERE order_id = {orderId}";

                DatabaseHelper.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void SaveOrderItemsAndIngredients(int orderId, List<MemoryOrderItem> items, string batchIdString)
        {
            foreach (MemoryOrderItem item in items)
            {
                string formattedUnitPrice = ((decimal)item.UnitPrice).ToString(System.Globalization.CultureInfo.InvariantCulture);
                string formattedTotalPrice = ((decimal)item.TotalPrice).ToString(System.Globalization.CultureInfo.InvariantCulture);

                // 1. إدخال الصنف في جدول order_items وجلب الـ ID المولد تلقائياً
                string itemQuery = $@"
        INSERT INTO order_items (order_id, menu_item_id, unit_price, quantity, total_price, batch_id)
        VALUES ({orderId}, {item.MenuItemId}, {formattedUnitPrice}, {item.Quantity}, {formattedTotalPrice}, {batchIdString});
        SELECT SCOPE_IDENTITY();";

                DataTable dtItem = DatabaseHelper.ExecuteQuery(itemQuery);
                if (dtItem != null && dtItem.Rows.Count > 0)
                {
                    int newOrderItemId = Convert.ToInt32(dtItem.Rows[0][0]);

                    // 🔹 [التعديل الجديد]: التحقق من وجود ملاحظة للصنف وإدخالها في جدول notes
                    if (!string.IsNullOrWhiteSpace(item.NoteText))
                    {
                        // تنظيف النص من علامات التنصيص المفردة لمنع كسر استعلام SQL
                        string cleanNote = item.NoteText.Replace("'", "''").Trim();

                        string noteQuery = $@"
                INSERT INTO notes (note_id, note_text)
                VALUES ({newOrderItemId}, N'{cleanNote}')";

                        DatabaseHelper.ExecuteNonQuery(noteQuery);
                    }

                    // 2. إدخال المكونات المزالة (الكود القديم كما هو)
                    foreach (int ingredientId in item.RemovedIngredientIds)
                    {
                        string ingQuery = $@"
                INSERT INTO order_item_ingredients (order_item_id, ingredient_id, is_removed)
                VALUES ({newOrderItemId}, {ingredientId}, 1)";

                        DatabaseHelper.ExecuteNonQuery(ingQuery);
                    }
                }
            }
        }

        public List<MemoryOrderItem> GetActiveOrderItemsByTable(int tableId, out int openOrderId, out double currentTotal)
        {
            List<MemoryOrderItem> loadedItems = new List<MemoryOrderItem>();
            openOrderId = 0;
            currentTotal = 0;

            try
            {
                string orderQuery = $@"
                SELECT order_id, total_amount 
                FROM orders 
                WHERE table_id = {tableId} AND order_status = 0 AND is_takeaway = 0";

                DataTable dtOrder = DatabaseHelper.ExecuteQuery(orderQuery);

                if (dtOrder == null || dtOrder.Rows.Count == 0) return loadedItems;

                openOrderId = Convert.ToInt32(dtOrder.Rows[0]["order_id"]);
                currentTotal = Convert.ToDouble(dtOrder.Rows[0]["total_amount"]);

                string itemsQuery = $@"
                SELECT oi.order_item_id, oi.menu_item_id, mi.menu_item_name, oi.unit_price, oi.quantity, oi.total_price
                FROM order_items oi
                INNER JOIN menu_items mi ON oi.menu_item_id = mi.menu_item_id
                WHERE oi.order_id = {openOrderId}";

                DataTable dtItems = DatabaseHelper.ExecuteQuery(itemsQuery);

                foreach (DataRow row in dtItems.Rows)
                {
                    MemoryOrderItem item = new MemoryOrderItem();
                    item.UniqueId = Guid.NewGuid().ToString();
                    item.MenuItemId = Convert.ToInt32(row["menu_item_id"]);
                    item.ItemName = row["menu_item_name"].ToString();
                    item.UnitPrice = Convert.ToDouble(row["unit_price"]);
                    item.Quantity = Convert.ToInt32(row["quantity"]);
                    item.TotalPrice = Convert.ToDouble(row["total_price"]);

                    int orderItemId = Convert.ToInt32(row["order_item_id"]);
                    string ingQuery = $@"
                    SELECT ingredient_id 
                    FROM order_item_ingredients 
                    WHERE order_item_id = {orderItemId} AND is_removed = 1";

                    DataTable dtIng = DatabaseHelper.ExecuteQuery(ingQuery);
                    foreach (DataRow ingRow in dtIng.Rows)
                    {
                        item.RemovedIngredientIds.Add(Convert.ToInt32(ingRow["ingredient_id"]));
                    }

                    loadedItems.Add(item);
                }
            }
            catch
            {
            }

            return loadedItems;
        }

        public bool PayAndCloseOrder(int orderId)
        {
            try
            {
                string query = $@"
                UPDATE orders 
                SET order_status = 1 
                WHERE order_id = {orderId}";

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query);
                return rowsAffected > 0;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetActiveDiscountsForToday()
        {
            string query = @"
        SELECT discount_id, discount_name, discount_type, discount_amount 
        FROM discounts 
        WHERE is_active = 1 
          AND is_deleted = 0
          AND CAST(GETDATE() AS DATE) BETWEEN CAST(start_date AS DATE) AND CAST(end_date AS DATE)";

            return DatabaseHelper.ExecuteQuery(query);
        }

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