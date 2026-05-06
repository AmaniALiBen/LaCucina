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
        int id;
        string name;
        int categoryId;
        double price;
        bool isActive;
        string ImagePath;

        public Item(int id, string name, int categoryId, double price, bool isActive, string imagePath)
        {
            this.id = id;
        this.name = name;
            this.categoryId = categoryId;
            this.price = price;
            this.isActive = isActive;
            this.ImagePath = imagePath;
        }
    }
}
