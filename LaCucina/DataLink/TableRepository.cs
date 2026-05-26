using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
