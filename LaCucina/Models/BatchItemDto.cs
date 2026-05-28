using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina.Models
{
    public class BatchItemDto
    {
        public int OrderItemId { get; set; }
        public string MenuItemName { get; set; }
        public int Quantity { get; set; }
        public string NoteText { get; set; }  // null if no note
        public List<string> RemovedIngredients { get; set; } = new List<string>();
    }
}
