using LaCucina.Models;
using System.Collections.Generic;

namespace LaCucina
{
    public class ItemDetails
    {
        public string ItemName { get; set; }
        public List<MemoryIngredientRemoved> MainIngredients { get; set; } = new List<MemoryIngredientRemoved>();  
        public List<MemoryIngredientRemoved> ExtraIngredients { get; set; } = new List<MemoryIngredientRemoved>();
    }
}