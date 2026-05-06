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
        public static int tableCounter=3;
        public static int SpaceCounter=5;
        public static int ingredientCounter = 6;
        public static int ingredientInItemCounter = 0;
        public static int itemCounter = 2;

        public static Dictionary<int, Table> tables = new Dictionary<int, Table>()
        {
        [1] = new Table(1,"10",4,TableFormat.circular,new Point(0,0),1,TableStatus.vacant),
        [2]=new Table(2,"11",10,TableFormat.horizontal,new Point(100,100),2,TableStatus.vacant),
        [3]=new Table(3,"12",12,TableFormat.vertical,new Point(300,300),3,TableStatus.vacant),  
        
        };

        public static Dictionary<int, Space> spaces = new Dictionary<int, Space>()
        {
            [1] = new Space(1, "floor 1"),
            [2] = new Space(2, "floor 2"),
            [3] = new Space(3, "floor 3"),
            [4] = new Space(4, "floor 4"),
            [5] = new Space(5, "floor 5"),


        };

        public static Dictionary<int, UCIngredient> ingredients = new Dictionary<int, UCIngredient>()
        {
            [1]=new UCIngredient(1,"tomato"),
            [2]=new UCIngredient(2,"onion"),
            [3]=new UCIngredient(3,"mayo"),
            [4]=new UCIngredient(4,"chicken"),
            [5]=new UCIngredient(5,"beef"),
            [6]=new UCIngredient(6,"cheese")

        };

        public static Dictionary<int, UCIngredientInItem> ingredientInItem = new Dictionary<int, UCIngredientInItem>()
        {
            
        };

        public static Dictionary<int, Item> items = new Dictionary<int, Item>()
        {
            [1] = new Item(1,"burger",1,15,true,""),
            [2] = new Item(2,"pizza",1,20,true,"")

        };



        }
}
