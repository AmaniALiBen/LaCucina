using CustomControls.RJControls;
using LaCucina.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public static class ManagerMenu
    {
        public static bool  EditCategory(int key,string name)
        {
            Categories c = DataBase.category[key];
            
            foreach(var value in DataBase.category.Values)
            {
                if(name==value.name)
                {
                    MessageBox.Show("Category Already Exists");
                    return false;
                }

            }
            c.name = name;
            DataBase.category[key] = c;
            MessageBox.Show("Edited Successfully");
            return true;
        }
        public static void DeleteCategory(int key)
        {
           if(DataBase.category.ContainsKey(key))
                DataBase.category.Remove(key);
            MessageBox.Show("Deleted Successfully");
        }
        public static void AddCategory(string name)
        {
            Categories c = new Categories(name);
            foreach(var entry in DataBase.category)
            {
                if(entry.Value.name==name)
                {
                    MessageBox.Show("Category Already Exists");
                    return;
                }
            }
            int nextKey =DataBase.category.Count==0?1:DataBase.category.Count+1;
            DataBase.category[nextKey] = c;
            MessageBox.Show("Added Successfully");

        }
    }
}
