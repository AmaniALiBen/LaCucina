//using LaCucina.DataLink;
//using LaCucina.Models;
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LaCucina.Services
//{

//    public class FloorPlanService
//    {
//        private TableRepository tableRepo;
//        private SpaceRepository spaceRepo;

//        public FloorPlanService()
//        {
//            tableRepo = new TableRepository();
//            spaceRepo = new SpaceRepository();
//        }

//        // 🔹 spaces
//        public List<spaces> GetSpaces()
//        {
//            return spaceRepo.GetAll();
//        }

//        // 🔹 tables by space
//        public List<Table> GetTablesBySpace(int spaceId)
//        {
//            return tableRepo.GetBySpace(spaceId);

//        }
//        public Table GetTableById(int tableId)
//        {
//            return tableRepo.GetById(tableId);
//        }

//        // 🔹 delete table
//        public void DeleteTable(int id)
//        {
//            tableRepo.Delete(id);
//        }

//        // 🔹 add table
//        public void AddTable(Table t)
//        {
//            tableRepo.Add(t);
//        }

//        // 🔹 update table
//        public void UpdateTable(Table t)
//        {
//            tableRepo.Update(t);
//        }

//        public void editLocation(int id,Point location) 
//        {

//            tableRepo.editLocation(id, location.X,location.Y);
//        }
//        public string ValidateTable(Table table, bool isEdit = false)
//        {
//            table.tableNum = table.tableNum.Trim();

//            if (string.IsNullOrWhiteSpace(table.tableNum))
//                return "Table number is required";

//            if (table.tableNum.Length > 3)
//                return "Table number is too long";

//            var tables = tableRepo.GetBySpace(table.spaceId);

//            foreach (var t in tables)
//            {
//                if (t.tableNum == table.tableNum)
//                {
//                    if (isEdit && t.id == table.id)
//                        continue;

//                    return "Table number already exists";
//                }
//            }

//            return null;
//        }

//        public List<int> GetTablesWithReadyItems()
//        {
//            return tableRepo.GetTablesWithReadyItems();
//        }


//        public bool MarkReadyItemsAsDelivered(int tableId)
//        {
//            return tableRepo.MarkReadyItemsAsDelivered(tableId);
//        }


//        public int? GetOpenOrderIdByTable(int tableId)
//        {
//            return tableRepo.GetOpenOrderIdByTable(tableId);
//        }
//    }
//}

using LaCucina.DataLink;
using LaCucina.Models;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace LaCucina.Services
{
    public class FloorPlanService
    {
        private TableRepository tableRepo;
        private SpaceRepository spaceRepo;

        public FloorPlanService()
        {
            tableRepo = new TableRepository();
            spaceRepo = new SpaceRepository();
        }

        // ── Spaces ───────────────────────────────────────────────────────
        public List<spaces> GetSpaces() => spaceRepo.GetAll();

        // ── Tables ───────────────────────────────────────────────────────
        public List<Table> GetTablesBySpace(int spaceId) => tableRepo.GetBySpace(spaceId);
        public Table GetTableById(int tableId) => tableRepo.GetById(tableId);
        public void DeleteTable(int id) => tableRepo.Delete(id);
        public void AddTable(Table t) => tableRepo.Add(t);
        public void UpdateTable(Table t) => tableRepo.Update(t);

        public void editLocation(int id, Point location)
            => tableRepo.editLocation(id, location.X, location.Y);

        // ── Notification helpers ─────────────────────────────────────────

        /// <summary>
        /// Returns table IDs that have at least one item with item_status = 1 (Done).
        /// Called by the floor plan timer to decide which tables show the 🔔 icon.
        /// </summary>
        public List<int> GetTablesWithReadyItems()
            => tableRepo.GetTablesWithReadyItems();

        /// <summary>
        /// Marks all item_status = 1 items as Delivered (2) for the given table.
        /// If no pending or ready items remain, sets table_status = served (2).
        /// </summary>
        public bool MarkReadyItemsAsDelivered(int tableId)
            => tableRepo.MarkReadyItemsAsDelivered(tableId);

        // ── Validation ───────────────────────────────────────────────────
        public string ValidateTable(Table table, bool isEdit = false)
        {
            table.tableNum = table.tableNum.Trim();

            if (string.IsNullOrWhiteSpace(table.tableNum))
                return "Table number is required";

            if (table.tableNum.Length > 3)
                return "Table number is too long";

            var tables = tableRepo.GetBySpace(table.spaceId);

            foreach (var t in tables)
            {
                if (t.tableNum == table.tableNum)
                {
                    if (isEdit && t.id == table.id)
                        continue;
                    return "Table number already exists";
                }
            }

            return null;
        }
    }
}