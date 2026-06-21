using System;
using System.Collections.Generic;
using System.Data;
using LaCucina.Models;

namespace LaCucina.DataLink
{
    public class TableRepository
    {
        public virtual List<Table> GetBySpace(int spaceId)
        {
            string query = $@"
            SELECT table_id, number, space_id, table_status, capacity, position_x, position_y, table_format
            FROM dining_tables
            WHERE space_id = {spaceId}
            AND is_deleted = 0";

            return MapToList(query);
        }

        public virtual Table GetById(int id)
        {
            string query = $@"
            SELECT *
            FROM dining_tables
            WHERE table_id = {id}";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            return Map(dt.Rows[0]);
        }

        public virtual void Add(Table t)
        {
            string query = $@"
            INSERT INTO dining_tables
            (number, space_id, table_status, capacity, position_x, position_y, table_format, is_deleted)
            VALUES
            ('{t.tableNum}', {t.spaceId}, {(int)t.tableStatus}, {t.chairCount},
             {t.location.X}, {t.location.Y}, {(int)t.tableFormat}, 0)";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        public virtual void Update(Table t)
        {
            string query = $@"
            UPDATE dining_tables
            SET
                number = '{t.tableNum}',
                space_id = {t.spaceId},
                table_status = {(int)t.tableStatus},
                capacity = {t.chairCount},
                position_x = {t.location.X},
                position_y = {t.location.Y},
                table_format = {(int)t.tableFormat}
            WHERE table_id = {t.id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        public virtual void Delete(int id)
        {
            string query = $@"
            UPDATE dining_tables
            SET is_deleted = 1
            WHERE table_id = {id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        public virtual void editLocation(int id, int x, int y)
        {
            string query = $@"
            UPDATE dining_tables
            SET position_x = {x}, position_y = {y}
            WHERE table_id = {id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        public virtual List<int> GetTablesWithReadyItems()
        {
            string query = @"
    SELECT DISTINCT t.table_id 
    FROM dining_tables t
    INNER JOIN orders o ON o.table_id = t.table_id
    INNER JOIN order_items oi ON oi.order_id = o.order_id
    WHERE oi.item_status = 1 
      AND o.order_status = 0
      AND t.is_deleted = 0";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<int> tableIds = new List<int>();

            foreach (DataRow row in dt.Rows)
                tableIds.Add(Convert.ToInt32(row["table_id"]));

            return tableIds;
        }

        public virtual bool MarkReadyItemsAsDelivered(int tableId)
        {
            try
            {
                string updateQuery = $@"
        UPDATE order_items 
        SET item_status = 2 
        WHERE item_status = 1 
          AND order_id IN (SELECT order_id FROM orders WHERE table_id = {tableId} AND order_status = 0)";

                DatabaseHelper.ExecuteNonQuery(updateQuery);

                string checkQuery = $@"
        SELECT COUNT(*) 
        FROM order_items oi
        INNER JOIN orders o ON o.order_id = oi.order_id
        WHERE o.table_id = {tableId} 
          AND o.order_status = 0
          AND oi.item_status IN (0, 1)";

                DataTable dt = DatabaseHelper.ExecuteQuery(checkQuery);
                int pendingCount = Convert.ToInt32(dt.Rows[0][0]);

                if (pendingCount == 0)
                {
                    string statusQuery = $@"
            UPDATE dining_tables 
            SET table_status = 2 
            WHERE table_id = {tableId}";

                    DatabaseHelper.ExecuteNonQuery(statusQuery);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual int? GetOpenOrderIdByTable(int tableId)
        {
            string query = $@"
    SELECT order_id 
    FROM orders 
    WHERE table_id = {tableId} AND order_status = 0";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0]["order_id"]);

            return null;
        }

        // ---------------- HELPERS ----------------

        private List<Table> MapToList(string query)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<Table> list = new List<Table>();

            foreach (DataRow row in dt.Rows)
                list.Add(Map(row));

            return list;
        }

        private Table Map(DataRow row)
        {
            return new Table
            (
                (int)row["table_id"],
                row["number"].ToString(),
                (int)row["capacity"],
                (TableFormat)Convert.ToInt32(row["table_format"]),
                new System.Drawing.Point(
                    Convert.ToInt32(row["position_x"]),
                    Convert.ToInt32(row["position_y"])
                ),
                (int)row["space_id"],
                (TableStatus)Convert.ToInt32(row["table_status"])
            );
        }
    }
}