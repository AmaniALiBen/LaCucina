using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LaCucina
{
    internal class DataBase
    {
        public static Dictionary<int, Table> tables = new Dictionary<int, Table>()
        {
        [1] = new Table(1,"10",4,TableFormat.circular,new Point(0,0),1,TableStatus.vacant),
        [2]=new Table(2,"11",10,TableFormat.horizontal,new Point(100,100),1,TableStatus.vacant),
        [3]=new Table(3,"12",12,TableFormat.vertical,new Point(300,300),1,TableStatus.vacant),  
        
        };

    }
}
