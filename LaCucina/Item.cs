using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina
{
    internal class Item
    {
        public int id;
        public string name;
        public int categoryId;
        public double price;
        public bool isActive;
        

        public Item(int id, string name, int categoryId, double price, bool isActive)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
            this.price = price;
            this.isActive = isActive;
           
        }
    }
}
