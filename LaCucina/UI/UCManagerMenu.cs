using LaCucina.DataLink;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaCucina
{
    public partial class UCManagerMenu : UserControl
    {
        UCbtnCategory _selectedCategory;
        
        
        public void loadMenu()
        {
            FlowpnlItems.Controls.Clear();
            pnlCategories.Controls.Clear();
            List<Categories> categoryList = CategoryRepository.GetAll();
            
            foreach (Categories cat in categoryList)
            {
               // int id = (int)row["category_id"];
               // string name =(string) row["category_name"];
                UCbtnCategory category= new UCbtnCategory();
                category._Name = cat.name;
                category.Tag = cat.id;


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

                    List<Item> items = ItemRepository.GetByCategory(Convert.ToInt32(_selectedCategory.Tag));
                    foreach (Item i in items)
                    {
                        UCManagerItemCard card = new UCManagerItemCard();
                        

                            card.Name = i.Name;
                            card.Price = i.Price;
                            card.Id = i.Id;
                            FlowpnlItems.Controls.Add(card);
                        card.Delete = () =>
                        {
                            DialogResult result = MessageBox.Show(
                                    $"Are you sure you want to delete this item",
                                    "Confirm Delete",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning
                                );
                            if (result == DialogResult.Yes)
                            {
                                ItemRepository.Delete(i.Id);
                                menuItemIngredientsRepository.DeleteAllByMenuItem(i.Id);
                                UCItem c = new UCItem();
                               // c.CleanupImages();
                                MessageBox.Show("Item has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FlowpnlItems.Controls.Remove(card);
                            }
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
