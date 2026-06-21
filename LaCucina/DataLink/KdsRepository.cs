using System.Data;
namespace LaCucina.DataLink
{
    public class KdsRepository
    {
        public virtual DataTable GetActiveBatchesRaw()
        {
            string sql = @"
        SELECT
            ob.batch_id, ob.order_id, ob.sent_at, ob.batch_status,
            CASE 
                WHEN o.is_takeaway = 1 THEN 'Takeaway'
                ELSE 'Table ' + CAST(t.number AS VARCHAR(10))
            END AS table_number,
            ISNULL(s.space_name, 'Takeaway') AS space_name,
            oi.order_item_id, oi.quantity, oi.item_status,
            m.menu_item_name,
            n.note_text,
            i.ingredient_name
        FROM order_batches ob
        JOIN orders               o   ON ob.order_id       = o.order_id
        LEFT JOIN dining_tables   t   ON o.table_id        = t.table_id
        LEFT JOIN spaces          s   ON t.space_id        = s.space_id
        JOIN order_items          oi  ON oi.batch_id      = ob.batch_id
        JOIN menu_items           m   ON oi.menu_item_id  = m.menu_item_id
        LEFT JOIN notes           n   ON n.note_id         = oi.order_item_id
        LEFT JOIN order_item_ingredients oii
                                    ON oii.order_item_id = oi.order_item_id
                                   AND oii.is_removed    = 1
        LEFT JOIN ingredients   i   ON i.ingredient_id  = oii.ingredient_id
        WHERE ob.batch_status = 0
        ORDER BY ob.sent_at ASC";
            return DatabaseHelper.ExecuteQuery(sql);
        }

        public virtual DataTable GetKitchenLoadRaw()
        {
            string sql = @"
                SELECT
                    m.menu_item_id,
                    m.menu_item_name,
                    SUM(oi.quantity) AS total_quantity
                FROM order_batches ob
                JOIN order_items oi ON oi.batch_id     = ob.batch_id
                JOIN menu_items  m  ON oi.menu_item_id = m.menu_item_id
                WHERE ob.batch_status = 0
                AND oi.item_status  = 0
                GROUP BY m.menu_item_id, m.menu_item_name
                ORDER BY total_quantity DESC";
            return DatabaseHelper.ExecuteQuery(sql);
        }

        public virtual int GetTotalItemsInQueue()
        {
            string sql = @"
                SELECT ISNULL(SUM(oi.quantity), 0)
                FROM order_batches ob
                JOIN order_items oi ON oi.batch_id = ob.batch_id
                WHERE  ob.batch_status = 0
                AND oi.item_status  = 0";
            return DatabaseHelper.ExecuteScalar(sql);
        }

        public virtual void MarkItemDone(int orderItemId)
        {
            string sql = $@"
                UPDATE order_items
                SET item_status = 1
                WHERE order_item_id = {orderItemId}";
            DatabaseHelper.ExecuteNonQuery(sql);
        }

        public virtual void MarkBatchReady(int batchId)
        {
            string sql = $@"
                UPDATE order_batches
                SET batch_status = 1
                WHERE batch_id = {batchId}";
            DatabaseHelper.ExecuteNonQuery(sql);
        }

        public virtual int CountPendingItems(int batchId)
        {
            string sql = $@"
                SELECT COUNT(*)
                FROM order_items
                WHERE batch_id   = {batchId}
                  AND item_status = 0";
            return DatabaseHelper.ExecuteScalar(sql);
        }

        public virtual void MarkAllItemsDone(int batchId)
        {
            string sql = $@"
        UPDATE order_items
        SET item_status = 1
        WHERE batch_id = {batchId}";
            DatabaseHelper.ExecuteNonQuery(sql);
        }
    }
}