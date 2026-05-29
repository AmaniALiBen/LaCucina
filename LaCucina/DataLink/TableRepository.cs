using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaCucina.Models;

namespace LaCucina.DataLink
{
    public class TableRepository
    {
        // 1. Get all tables in a space
        public List<Table> GetBySpace(int spaceId)
        {
            string query = $@"
            SELECT table_id, number, space_id, table_status, capacity, position_x, position_y, table_format
            FROM dining_tables
            WHERE space_id = {spaceId}
            AND is_deleted = 0";

            return MapToList(query);
        }

        // 2. Get table by id
        public Table GetById(int id)
        {
            string query = $@"
            SELECT *
            FROM dining_tables
            WHERE table_id = {id}";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return Map(row);
        }

       

        // 4. Add table
        public void Add(Table t)
        {
            string query = $@"
            INSERT INTO dining_tables
            (number, space_id, table_status, capacity, position_x, position_y, table_format, is_deleted)
            VALUES
            ('{t.tableNum}', {t.spaceId}, {(int)t.tableStatus}, {t.chairCount},
             {t.location.X}, {t.location.Y}, {(int)t.tableFormat}, 0)";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 5. Update table
        public void Update(Table t)
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

        // 6. Delete (soft delete)
        public void Delete(int id)
        {
            string query = $@"
            UPDATE dining_tables
            SET is_deleted = 1
            WHERE table_id = {id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        public void editLocation(int id ,int x,int y) 
        {
            string query = $@"
            UPDATE dining_tables
            SET position_x = {x},position_y={y}
            WHERE table_id = {id}";

            DatabaseHelper.ExecuteNonQuery(query);
        }
        
        // ---------------- HELPERS ----------------

        private List<Table> MapToList(string query)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            List<Table> list = new List<Table>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(Map(row));
            }

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

        // Add these methods to TableRepository.cs

        // Get all table IDs that have items with status = 1 (Done/Ready)
        public List<int> GetTablesWithReadyItems()
        {
            string query = @"
    SELECT DISTINCT t.table_id 
    FROM dining_tables t
    INNER JOIN orders o ON o.table_id = t.table_id
    INNER JOIN order_items oi ON oi.order_id = o.order_id
    WHERE oi.item_status = 1 
      AND o.order_status = 0  -- Open orders only
      AND t.is_deleted = 0";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<int> tableIds = new List<int>();

            foreach (DataRow row in dt.Rows)
            {
                tableIds.Add(Convert.ToInt32(row["table_id"]));
            }

            return tableIds;
        }

        // Mark all ready items as delivered for a specific table
        public bool MarkReadyItemsAsDelivered(int tableId)
        {
            try
            {
                // Step 1: Update all item_status from 1 to 2 for this table
                string updateQuery = $@"
        UPDATE order_items 
        SET item_status = 2 
        WHERE item_status = 1 
          AND order_id IN (SELECT order_id FROM orders WHERE table_id = {tableId} AND order_status = 0)";

                DatabaseHelper.ExecuteNonQuery(updateQuery);

                // Step 2: Check if any items are still pending (status 0) or ready (status 1)
                string checkQuery = $@"
        SELECT COUNT(*) 
        FROM order_items oi
        INNER JOIN orders o ON o.order_id = oi.order_id
        WHERE o.table_id = {tableId} 
          AND o.order_status = 0
          AND oi.item_status IN (0, 1)";

                DataTable dt = DatabaseHelper.ExecuteQuery(checkQuery);
                int pendingCount = Convert.ToInt32(dt.Rows[0][0]);

                // Step 3: If no pending/ready items, set table_status to served (2)
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

        // Get order ID for a table (open order)
        public int? GetOpenOrderIdByTable(int tableId)
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
    }
}
