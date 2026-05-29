using LaCucina.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina.DataLink
{
    public class POSRepository
    {

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


        public DataTable GetOrderReceiptDetails(int orderId)
        {
            string sql = $@"
    SELECT 
        o.order_id, 
        o.created_at AS order_date, 
        u.username AS cashier_name,
        CASE 
            WHEN o.is_takeaway = 1 THEN 'Takeaway' 
            ELSE 'Table ' + CAST(dt.number AS VARCHAR(10)) 
        END AS location,
        mi.menu_item_name, 
        oi.quantity, 
        oi.unit_price, 
        oi.total_price AS item_total_price,
        ISNULL((
            SELECT 'without ' + ing.ingredient_name + ' ' 
            FROM order_item_ingredients oii 
            JOIN ingredients ing ON ing.ingredient_id = oii.ingredient_id 
            WHERE oii.order_item_id = oi.order_item_id AND oii.is_removed = 1 
            FOR XML PATH('')
        ), '') AS removed_ingredients,
        o.sub_total AS total_before_discount, 
        ISNULL(o.discount_amount, 0.00) AS discount_amount, 
        o.total_amount AS net_total
    FROM orders o
    JOIN users u ON u.user_id = o.user_id
    LEFT JOIN dining_tables dt ON dt.table_id = o.table_id
    JOIN order_items oi ON oi.order_id = o.order_id
    JOIN menu_items mi ON mi.menu_item_id = oi.menu_item_id
    WHERE o.order_id = {orderId}";

            return DatabaseHelper.ExecuteQuery(sql);
        }
    }
}
