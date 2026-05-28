using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LaCucina.Models
{
    public class KitchenLoadItemDto
    {
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public int TotalQuantity { get; set; }
    }
}