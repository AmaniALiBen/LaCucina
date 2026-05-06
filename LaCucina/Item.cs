using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina
{
    public class Item
    {

        public string name;
        public string picture;
        public int category_id;
        public double price;
        public Item(string name , double price,string picture , int categiry_id ){
        this.name = name;
            this.picture = picture;
            this.category_id = categiry_id;
            this.price = price;
        }
    }
}
