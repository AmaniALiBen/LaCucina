using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina.Models
{
    public class MemoryOrderItem
    {
        public string UniqueId { get; set; } 
        public int MenuItemId { get; set; }
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string NoteText { get; set; }

        public List<int> RemovedIngredientIds { get; set; } = new List<int>();
    
    }
}
