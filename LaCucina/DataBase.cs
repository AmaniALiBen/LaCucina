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
        public static int itemCounter = 50;
        public static int categoryCounter = 16;

        public static Dictionary<int, Table> tables = new Dictionary<int, Table>()
        {
        [1] = new Table(1,"10",4,TableFormat.circular,new Point(50,50),1,TableStatus.vacant),
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
            
            [1] = new Item(1, "Classic Beef Burger", 1, 15, true),
            [2] = new Item(2, "Double Cheese Burger", 1, 20, true),
            [3] = new Item(3, "Spicy Zinger Burger", 1, 18, true),
            [4] = new Item(4, "Mushroom Swiss Burger", 1, 22, true),
            [5] = new Item(5, "BBQ Bacon Burger", 1, 24, true),
            [6] = new Item(6, "Crispy Chicken Burger", 1, 17, true),
            [7] = new Item(7, "Grilled Chicken Burger", 1, 19, true),
            [8] = new Item(8, "Fish Burger", 1, 16, true),
            [9] = new Item(9, "Veggie Burger", 1, 15, true),
            [10] = new Item(10, "Slider Trio (Minis)", 1, 25, true),

            [11] = new Item(11, "Margherita Pizza", 2, 14, true),
            [12] = new Item(12, "Pepperoni Pizza", 2, 18, true),
            [13] = new Item(13, "Super Supreme Pizza", 2, 22, true),
            [14] = new Item(14, "BBQ Chicken Pizza", 2, 20, true),
            [15] = new Item(15, "Four Cheese Pizza", 2, 19, true),
            [16] = new Item(16, "Veggie Lover Pizza", 2, 17, true),
            [17] = new Item(17, "Ranch Chicken Pizza", 2, 21, true),
            [18] = new Item(18, "Seafood Pizza", 2, 26, true),
            [19] = new Item(19, "Spicy Beef Pizza", 2, 19, true),
            [20] = new Item(20, "Mushroom Pizza", 2, 16, true),

            [21] = new Item(21, "Caesar Salad", 3, 12, true),
            [22] = new Item(22, "Grilled Chicken Caesar", 3, 16, true),
            [23] = new Item(23, "Greek Salad", 3, 13, true),
            [24] = new Item(24, "Quinoa Salad", 3, 15, true),
            [25] = new Item(25, "Fattoush Salad", 3, 10, true),
            [26] = new Item(26, "Tuna Salad", 3, 14, true),
            [27] = new Item(27, "Caprese Salad", 3, 17, true),
            [28] = new Item(28, "Rocket (Arugula) Salad", 3, 11, true),
            [29] = new Item(29, "Chef's Special Salad", 3, 18, true),
            [30] = new Item(30, "Fruit Salad", 3, 9, true),

            [31] = new Item(31, "Ribeye Steak (300g)", 4, 45, true),
            [32] = new Item(32, "Sirloin Steak (250g)", 4, 38, true),
            [33] = new Item(33, "T-Bone Steak (400g)", 4, 55, true),
            [34] = new Item(34, "Beef Tenderloin (200g)", 4, 50, true),
            [35] = new Item(35, "Pepper Steak", 4, 40, true),
            [36] = new Item(36, "Mushroom Steak", 4, 42, true),
            [37] = new Item(37, "Grilled Salmon Steak", 4, 35, true),
            [38] = new Item(38, "Lamb Chops (4pcs)", 4, 48, true),
            [39] = new Item(39, "BBQ Ribs", 4, 36, true),
            [40] = new Item(40, "Surf & Turf (Steak/Shrimp)", 4, 60, true),

            [41] = new Item(41, "Pasta Bolognese", 5, 18, true),
            [42] = new Item(42, "Pasta Alfredo", 5, 20, true),
            [43] = new Item(43, "Chicken Alfredo Pasta", 5, 24, true),
            [44] = new Item(44, "Pasta Arrabbiata (Spicy)", 5, 17, true),
            [45] = new Item(45, "Lasagna Bolognese", 5, 22, true),
            [46] = new Item(46, "Seafood Pasta (Linguine)", 5, 28, true),
            [47] = new Item(47, "Pesto Pasta", 5, 19, true),
            [48] = new Item(48, "Carbonara Pasta", 5, 21, true),
            [49] = new Item(49, "Macaroni & Cheese", 5, 16, true),
            [50] = new Item(50, "Vegetarian Pasta", 5, 18, true)

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
            [3] = new Categories(3, "Salads"),
            [4] = new Categories(4, "Steaks"),
            [5] = new Categories(5,"Pasta"),
            [6] = new Categories(6,"Seafood"),
            [7] = new Categories(7,"Drinks"),
            [8] = new Categories(8,"Desserts"),
           


        };
    }
}
