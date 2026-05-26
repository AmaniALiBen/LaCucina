using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LaCucina
{
    public  class Categories
    {
        public  int id;
        public  string name;

        public int Id { get; set; }
        public string Name { get; set; }
       public Categories(int id,string name)
        {
            this.name = name;
            this.id = id;
        }
        //public override string ToString()
        //{
        //    return name;
        //}

    }
}
