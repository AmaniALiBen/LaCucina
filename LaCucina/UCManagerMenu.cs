using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UCManagerMenu : UserControl
    {
        UCbtnCategory _selectedCategory;
        public void loadMenu()
        {
            FlowpnlItems.Controls.Clear();
            pnlCategories.Controls.Clear();
            foreach(var entry in DataBase.category)
            {
                var key = entry.Key;
                var value = entry.Value;
                UCbtnCategory category= new UCbtnCategory();
                category._Name = value.name;
                category.Tag = key;
                
                category.clickCategory = () =>
                {
                    category.btnName.ForeColor = Color.DarkOrange;
                    _selectedCategory = category;
                    foreach(UCbtnCategory c in pnlCategories.Controls)
                    {
                        
                        if (c != _selectedCategory)
                        {
                            c.btnName.ForeColor = Color.Gray;
                        }
                        
                    }
                    FlowpnlItems.Controls.Clear();
                    UCbtnAddItem u = new UCbtnAddItem();
                    FlowpnlItems.Controls.Add(u);
                    foreach (Item i in DataBase.items.Values)
                    {
                        UCManagerItemCard card = new UCManagerItemCard();
                        if (i.CategoryId == value.id)
                        {
                            
                            card.Name = i.Name;
                            card.Price = i.Price;
                            card.Id = i.Id;
                            FlowpnlItems.Controls.Add(card);
                        }
                        card.Delete = () => {
                            ManagerMenu.DeleteItem(i.Id);
                            FlowpnlItems.Controls.Remove(card);

                        };
                    }

                    
                };
               
               
                pnlCategories.Controls.Add(category);

            }

        }
        public UCManagerMenu()
        {
            InitializeComponent();
        }

       

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            EditCategory editCategory = new EditCategory();
            editCategory.ShowDialog();
           
            if( editCategory.DialogResult ==DialogResult.Cancel)
                editCategory.Close();
            else
            {
                loadMenu();
               
                editCategory.Close();
            }

        }

        private void UCManagerMenu_Load(object sender, EventArgs e)
        {
            
            loadMenu();
        }
    }
}
