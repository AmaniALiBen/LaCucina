using LaCucina.DataLink;
using LaCucina.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // 🔹 spaces
        public List<spaces> GetSpaces()
        {
            return spaceRepo.GetAll();
        }

        // 🔹 tables by space
        public List<Table> GetTablesBySpace(int spaceId)
        {
            return tableRepo.GetBySpace(spaceId);
                
        }
        public Table GetTableById(int tableId)
        {
            return tableRepo.GetById(tableId);
        }

        // 🔹 delete table
        public void DeleteTable(int id)
        {
            tableRepo.Delete(id);
        }

        // 🔹 add table
        public void AddTable(Table t)
        {
            tableRepo.Add(t);
        }

        // 🔹 update table
        public void UpdateTable(Table t)
        {
            tableRepo.Update(t);
        }

        public void editLocation(int id,Point location) 
        {

            tableRepo.editLocation(id, location.X,location.Y);
        }
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

