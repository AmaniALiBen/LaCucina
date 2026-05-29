using LaCucina.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace LaCucina.DataLink
{
    public class OrdersRepository
    {
        // ────────────────────────────────────────────────────────────────
        //  Filter helpers
        // ────────────────────────────────────────────────────────────────

        public List<string> GetWaiters()
        {
            string sql = @"
                SELECT DISTINCT u.username
                FROM   orders o
                JOIN   users  u ON u.user_id = o.user_id
                ORDER  BY u.username";

            DataTable dt = DatabaseHelper.ExecuteQuery(sql);
            var result = new List<string>();

            foreach (DataRow row in dt.Rows)
                result.Add(row["username"].ToString());

            return result;
        }

        public List<string> GetTables()
        {
            string sql = @"
                SELECT number
                FROM   dining_tables
                WHERE  is_deleted = 0
                ORDER  BY number";

            DataTable dt = DatabaseHelper.ExecuteQuery(sql);
            var result = new List<string>();

            foreach (DataRow row in dt.Rows)
                result.Add(row["number"].ToString());

            return result;
        }

        // ────────────────────────────────────────────────────────────────
        //  Order list
        // ────────────────────────────────────────────────────────────────

        public List<OrderRowDto> GetOrders(
            DateTime from,
            DateTime to,
            string   waiter = null
            )
        {
            string waiterFilter = waiter != null ? $"AND u.username = '{waiter}'" : "";
          

            string sql = $@"
                SELECT
                    o.order_id,
                    o.is_takeaway,
                    ISNULL(dt.number, '')  AS table_number,
                    u.username             AS waiter_name,
                    o.created_at,
                    o.order_status,
                    o.total_amount
                FROM  orders         o
                JOIN  users          u   ON u.user_id  = o.user_id
                LEFT  JOIN dining_tables dt ON dt.table_id = o.table_id
                WHERE o.created_at >= '{from.Date:yyyy-MM-dd}'
                  AND o.created_at <  '{to.Date.AddDays(1):yyyy-MM-dd}'
                  {waiterFilter} AND o.order_status=1
                  
                  
                ORDER BY o.created_at DESC";

            DataTable dt2 = DatabaseHelper.ExecuteQuery(sql);
            var result = new List<OrderRowDto>();

            foreach (DataRow row in dt2.Rows)
            {
                result.Add(new OrderRowDto
                {
                    OrderId     = Convert.ToInt32(row["order_id"]),
                    IsTakeaway  = Convert.ToBoolean(row["is_takeaway"]),
                    TableNumber = row["table_number"].ToString(),
                    WaiterName  = row["waiter_name"].ToString(),
                    CreatedAt   = Convert.ToDateTime(row["created_at"]),
                    OrderStatus = Convert.ToByte(row["order_status"]),
                    TotalAmount = Convert.ToDecimal(row["total_amount"])
                });
            }

            return result;
        }

        // ────────────────────────────────────────────────────────────────
        //  Order detail (receipt)
        // ────────────────────────────────────────────────────────────────

        public OrderDetailDto GetOrderDetail(int orderId)
        {
            // ── 1. Header ────────────────────────────────────────────────
            string headerSql = $@"
                SELECT
                    o.order_id,
                    o.is_takeaway,
                    ISNULL(dt.number, '')  AS table_number,
                    o.created_at,
                    o.total_amount,
                    o.discount_amount
                FROM  orders o
                LEFT  JOIN dining_tables dt ON dt.table_id = o.table_id
                WHERE o.order_id = {orderId}";

            DataTable headerDt = DatabaseHelper.ExecuteQuery(headerSql);
            if (headerDt.Rows.Count == 0) return null;

            DataRow h = headerDt.Rows[0];
            var detail = new OrderDetailDto
            {
                OrderId        = Convert.ToInt32(h["order_id"]),
                IsTakeaway     = Convert.ToBoolean(h["is_takeaway"]),
                TableNumber    = h["table_number"].ToString(),
                CreatedAt      = Convert.ToDateTime(h["created_at"]),
                TotalAmount    = Convert.ToDecimal(h["total_amount"]),
                DiscountAmount = h["discount_amount"] == DBNull.Value
                                     ? (decimal?)null
                                     : Convert.ToDecimal(h["discount_amount"])
            };

            // ── 2. Items + notes ─────────────────────────────────────────
            string itemsSql = $@"
                SELECT
                    oi.order_item_id,
                    mi.menu_item_name,
                    oi.quantity,
                    oi.total_price,
                    n.note_text
                FROM  order_items  oi
                JOIN  menu_items   mi ON mi.menu_item_id = oi.menu_item_id
                LEFT  JOIN notes   n  ON n.note_id       = oi.order_item_id
                WHERE oi.order_id = {orderId}
                ORDER BY oi.order_item_id";

            DataTable itemsDt = DatabaseHelper.ExecuteQuery(itemsSql);
            var itemMap = new Dictionary<int, OrderItemDto>();

            foreach (DataRow row in itemsDt.Rows)
            {
                int orderItemId = Convert.ToInt32(row["order_item_id"]);
                var item = new OrderItemDto
                {
                    MenuItemName = row["menu_item_name"].ToString(),
                    Quantity     = Convert.ToInt32(row["quantity"]),
                    TotalPrice   = Convert.ToDecimal(row["total_price"]),
                    NoteText     = row["note_text"] == DBNull.Value
                                       ? null
                                       : row["note_text"].ToString()
                };

                itemMap[orderItemId] = item;
                detail.Items.Add(item);
            }

            // ── 3. Removed ingredients ───────────────────────────────────
            if (itemMap.Count > 0)
            {
                string removedSql = $@"
                    SELECT oii.order_item_id, i.ingredient_name
                    FROM   order_item_ingredients oii
                    JOIN   ingredients            i ON i.ingredient_id = oii.ingredient_id
                    WHERE  oii.order_item_id IN (
                               SELECT order_item_id
                               FROM   order_items
                               WHERE  order_id = {orderId})
                      AND  oii.is_removed = 1";

                DataTable removedDt = DatabaseHelper.ExecuteQuery(removedSql);

                foreach (DataRow row in removedDt.Rows)
                {
                    int    id   = Convert.ToInt32(row["order_item_id"]);
                    string name = row["ingredient_name"].ToString();

                    if (itemMap.TryGetValue(id, out var item))
                        item.RemovedIngredients.Add(name);
                }
            }

            return detail;
        }
    }
}
