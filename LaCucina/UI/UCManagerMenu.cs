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
        CategoryRepository categoryRepository = new CategoryRepository();
        ItemRepository itemRepository = new ItemRepository();
        public void loadMenu()
        {
            FlowpnlItems.Controls.Clear();
            pnlCategories.Controls.Clear();
            DataTable table = categoryRepository.GetAll();
            
            foreach (DataRow row in table.Rows)
            {
                int id = (int)row["category_id"];
                string name =(string) row["category_name"];
                UCbtnCategory category= new UCbtnCategory();
                category._Name = name;
                category.Tag = id;


                category.clickCategory = () =>
                {
                    category.btnName.ForeColor = Color.DarkOrange;
                    _selectedCategory = category;
                    foreach (UCbtnCategory c in pnlCategories.Controls)
                    {

                        if (c != _selectedCategory)
                        {
                            c.btnName.ForeColor = Color.Gray;
                        }

                    }
                    FlowpnlItems.Controls.Clear();
                    UCbtnAddItem u = new UCbtnAddItem();
                    u.Add = () =>
                    {

                        Control parent = this.Parent;
                        parent.Controls.Remove(this);

                        // Create and add the Edit Item control
                        UCItem editItem = new UCItem(++DataBase.itemCounter, false);
                        editItem.Dock = DockStyle.Fill;
                        editItem.OnClose = () =>
                        {
                            parent.Controls.Remove(editItem);
                            UCManagerMenu menu = new UCManagerMenu();
                            menu.Dock = DockStyle.Fill;
                            parent.Controls.Add(menu);
                        };
                        parent.Controls.Add(editItem);
                    };
                    FlowpnlItems.Controls.Add(u);

                    List<Item> items = itemRepository.GetByCategory(Convert.ToInt32(_selectedCategory.Tag));
                    foreach (Item i in items)
                    {
                        UCManagerItemCard card = new UCManagerItemCard();
                        

                            card.Name = i.Name;
                            card.Price = i.Price;
                            card.Id = i.Id;
                            FlowpnlItems.Controls.Add(card);
                        card.Delete = () =>
                        {
                            ManagerMenu.DeleteItem(i.Id);
                            FlowpnlItems.Controls.Remove(card);

                        };
                        // Add this Edit action
                        card.Edit = () =>
                        {

                            Control parent = this.Parent;
                            parent.Controls.Remove(this);

                            // Create and add the Edit Item control
                            UCItem editItem = new UCItem(i.Id, true);
                            editItem.Dock = DockStyle.Fill;
                            editItem.OnClose = () =>
                            {
                                parent.Controls.Remove(editItem);
                                UCManagerMenu menu = new UCManagerMenu();
                                menu.Dock = DockStyle.Fill;
                                parent.Controls.Add(menu);
                            };
                            parent.Controls.Add(editItem);
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

        private void FlowpnlItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
