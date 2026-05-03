using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina
{
    public enum TableFormat
    {
       circular,
       horizontal,
       vertical
    }

   
    public enum TableStatus
    {
        vacant,
        preparing,
        ready,
        completed
        
    }
    public class Table
    {
        public int id;
        public string tableNum;
        public int chairCount;
        public TableStatus tableStatus;
        public TableFormat tableFormat;
        public Point location;
        public int spaceId;

        public Table(int id, string tableNum, int chairCount, TableFormat tableFormat, Point location, int spaceId, TableStatus tableStatus)
        {
            this.id = id;
            this.tableNum = tableNum;
            this.chairCount = chairCount;
            this.tableFormat = tableFormat;
            this.location = location;
            this.spaceId = spaceId;
            this.tableStatus = tableStatus;
           

        }
       
    }
}
