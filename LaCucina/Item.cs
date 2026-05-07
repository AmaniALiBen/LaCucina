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
        private int id;
        private string name;
        private int categoryId;
        private double price;
        private bool isActive;
        private string imagePath;

        public int Id{
            get { return id; }
            set { id = value; }

          }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }

        }
        public string ImagePath
        {
            get { return ImagePath; }
            set { ImagePath = value; }
        }

        public Item(int id, string name, int categoryId, double price, bool isActive)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
            this.price = price;
            this.isActive = isActive;
            this.imagePath = imagePath;
        }
    }
}
