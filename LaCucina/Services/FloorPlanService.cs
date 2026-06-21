using LaCucina.DataLink;
using LaCucina.Models;
using System.Collections.Generic;
using System.Drawing;

namespace LaCucina.Services
{
    public class FloorPlanService
    {
        private readonly TableRepository tableRepo;
        private readonly SpaceRepository spaceRepo;

        public FloorPlanService() : this(new TableRepository(), new SpaceRepository()) { }

        public FloorPlanService(TableRepository tableRepo, SpaceRepository spaceRepo)
        {
            this.tableRepo = tableRepo;
            this.spaceRepo = spaceRepo;
        }

        public List<spaces> GetSpaces() => spaceRepo.GetAll();

        public List<Table> GetTablesBySpace(int spaceId) => tableRepo.GetBySpace(spaceId);
        public Table GetTableById(int tableId) => tableRepo.GetById(tableId);
        public void DeleteTable(int id) => tableRepo.Delete(id);
        public void AddTable(Table t) => tableRepo.Add(t);
        public void UpdateTable(Table t) => tableRepo.Update(t);
        public void editLocation(int id, Point location)
            => tableRepo.editLocation(id, location.X, location.Y);

        public List<int> GetTablesWithReadyItems()
            => tableRepo.GetTablesWithReadyItems();

        public bool MarkReadyItemsAsDelivered(int tableId)
            => tableRepo.MarkReadyItemsAsDelivered(tableId);

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