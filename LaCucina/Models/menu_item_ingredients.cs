using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina.Models
{
    public class menu_item_ingredients
    {
        
        public int ItemId { get; set; }
        public int IngredientId { get; set; }
        public bool IsMain { get; set; }

        public menu_item_ingredients(int itemId, int ingredientId, bool isMain)
        {
            this.ItemId = itemId;
            this.IngredientId = ingredientId;
            this.IsMain = isMain;
        }
    }
}