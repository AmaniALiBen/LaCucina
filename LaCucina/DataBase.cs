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
        public static int ingredientInItemCounter = 2;
        public static int itemCounter = 2;
        public static int categoryCounter = 16;

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
            [1] = new UCIngredientInItem(1, 1, 1, true),
            [2] = new UCIngredientInItem(2, 1, 2, false)


        };


        public static Dictionary<int, Item> items = new Dictionary<int, Item>()
        {
            [1] = new Item(1,"burger",1,15,true),
            [2] = new Item(2,"pizza",1,20,true)

        };
        public static Dictionary<int, User> users = new Dictionary<int, User>()
        {
            [1] = new User( "Owner", "1111",  true, User.Role.Owner,false),
            [2] = new User("Admin", "2222", true, User.Role.Admin,false),
            [3] = new User("Waiter", "3333", true, User.Role.Waiter,false),
            [4] = new User("Chef", "4444", true, User.Role.Chef,false),
            [5] = new User("someone", "5555", true, User.Role.Chef, true),


        };
       


        public static Dictionary<int, Discounts> discounts = new Dictionary<int, Discounts>()
        {
            [1] = new Discounts("Ramadan", Discounts.Type.Fixed, 20, "2026/3/1", "2026/3/30", false, false),
            [2] = new Discounts("eid", Discounts.Type.Percentage, 10, "2026/5/25", "2026/5/29", true, false),
            [3] = new Discounts("white friday ", Discounts.Type.Fixed, 10, "2026/11/20", "2026/11/30", true, false),
            [4] = new Discounts("deleted ", Discounts.Type.Fixed, 10, "2026/11/20", "2026/11/30", true, true),
        };
        public static Dictionary<int, Categories> category = new Dictionary<int, Categories>()
        { 
            [1] = new Categories(1,"Burger"),
            [2] = new Categories(2,"Pizza"),
            [3] = new Categories(3,"Pasta"),
            [4] = new Categories(4,"Salads"),
            [5] = new Categories(5,"Steaks"),
            [6] = new Categories(6,"Seafood"),
            [7] = new Categories(7,"Drinks"),
            [8] = new Categories(8,"Desserts"),
            [9] = new Categories(9,"Burger"),
            [10] = new Categories(10,"Pizza"),
            [11] = new Categories(11,"fghjk"),
            [12] = new Categories(12,"Salads"),
            [13] = new Categories(13,"Steaks"),
            [14] = new Categories(14,"Seafood"),
            [15] = new Categories(15,"ijbi"),
            [16] = new Categories(16,"biubi"),


        };
    }
}
