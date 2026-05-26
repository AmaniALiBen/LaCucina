using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina.Models
{
    public class ingredients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public static UCIngredient lastSelectedIngredient = null;

        public ingredients(int id , string name, bool isDeleted)
        {
            this.Name = name;
            this.Id = id;
            IsDeleted = isDeleted;
        }
    }
}