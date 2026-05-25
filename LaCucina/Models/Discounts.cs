using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina
{
    public class Discounts
    {
        public enum Type { Percentage, Fixed };
        public string name;
        public Type type;
        public double value;
        public string start_date;
        public string end_date;
        public bool isActive;
        public bool isDeleted;
        public Discounts(string name, Type type, double value, string start_date, string end_date, bool isActive, bool isDeleted) 
        { 
        this.name = name;
            this.type = type;  
            this.value = value;
            this.start_date = start_date;
            this.end_date = end_date;
            this.isActive = isActive;
            this.isDeleted = isDeleted;

        }
    }
}
