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
        public void loadCategories()
        {
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
                    foreach(var i in DataBase.items.Values)
                    {
                       //  if()
                    }
                    
                };
                pnlCategories.Controls.Add(category);

            }

        }
        public UCManagerMenu()
        {
            InitializeComponent();
        }

        //private void btnBurgers_Click(object sender, EventArgs e)
        //{
        //    pnlItems.Controls.Clear();
        //    UCCategoryItems cat = new UCCategoryItems();
        //    cat.Dock = DockStyle.Fill;
        //    pnlItems.Controls.Add(cat);
        //}

        //private void btnPasta_Click(object sender, EventArgs e)
        //{
        //    pnlItems.Controls.Clear();
        //    UCCategoryItems cat = new UCCategoryItems();
        //    cat.Dock = DockStyle.Fill;
        //    pnlItems.Controls.Add(cat);
        //}

        //private void btnSalads_Click(object sender, EventArgs e)
        //{
        //    pnlItems.Controls.Clear();
        //    UCCategoryItems cat = new UCCategoryItems();
        //    cat.Dock = DockStyle.Fill;
        //    pnlItems.Controls.Add(cat);
        //}

        //private void btnSoups_Click(object sender, EventArgs e)
        //{
        //    pnlItems.Controls.Clear();
        //    UCCategoryItems cat = new UCCategoryItems();
        //    cat.Dock = DockStyle.Fill;
        //    pnlItems.Controls.Add(cat);
        //}

        //private void btnDesserts_Click(object sender, EventArgs e)
        //{
        //    pnlItems.Controls.Clear();
        //    UCCategoryItems cat = new UCCategoryItems();
        //    cat.Dock = DockStyle.Fill;
        //    pnlItems.Controls.Add(cat);
        //}

        //private void btnSideDishes_Click(object sender, EventArgs e)
        //{
        //    pnlItems.Controls.Clear();
        //    UCCategoryItems cat = new UCCategoryItems();
        //    cat.Dock = DockStyle.Fill;
        //    pnlItems.Controls.Add(cat);
        //}

        //private void btnGrills_Click(object sender, EventArgs e)
        //{
        //    pnlItems.Controls.Clear();
        //    UCCategoryItems cat = new UCCategoryItems();
        //    cat.Dock = DockStyle.Fill;
        //    pnlItems.Controls.Add(cat);
        //}

        //private void btnSandwiches_Click(object sender, EventArgs e)
        //{
        //    pnlItems.Controls.Clear();
        //    UCCategoryItems cat = new UCCategoryItems();
        //    cat.Dock = DockStyle.Fill;
        //    pnlItems.Controls.Add(cat);
        //}

        //private void btnDrinks_Click(object sender, EventArgs e)
        //{
        //    pnlItems.Controls.Clear();
        //    UCCategoryItems cat = new UCCategoryItems();
        //    cat.Dock = DockStyle.Fill;
        //    pnlItems.Controls.Add(cat);
        //}

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            EditCategory editCategory = new EditCategory();
            editCategory.ShowDialog();
            if(editCategory.DialogResult==DialogResult.OK|| editCategory.DialogResult ==DialogResult.Cancel)
                editCategory.Close();
        }

        private void UCManagerMenu_Load(object sender, EventArgs e)
        {
            //btnSandwiches.PerformClick();
            loadCategories();
        }
    }
}
