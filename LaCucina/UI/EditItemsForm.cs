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
    public partial class EditItemsForm : Form
    {
        Form form;

        UCbtnCategory _selectedCategory = null;

        public EditItemsForm(Form form)
        {
            this.form = form;
            InitializeComponent();
        }

        public void loadMenuForChef()
        {
            pnlProducts.Controls.Clear();
            pnlCategoriesNavbar.Controls.Clear();

            List<Categories> categoryList = CategoryRepository.GetAll();

            foreach (Categories cat in categoryList)
            {
                UCbtnCategory category = new UCbtnCategory();
                category._Name = cat.name;
                category.Tag = cat.id;

                category.clickCategory = () =>
                {
                    txtSearch.Texts = "";

                    category.btnName.ForeColor = Color.DarkOrange;
                    _selectedCategory = category;

                    foreach (UCbtnCategory c in pnlCategoriesNavbar.Controls)
                    {
                        if (c != _selectedCategory)
                        {
                            c.btnName.ForeColor = Color.Gray;
                        }
                    }

                    LoadItemsForSelectedCategory();
                };

                pnlCategoriesNavbar.Controls.Add(category);
            }

            if (pnlCategoriesNavbar.Controls.Count > 0)
            {
                UCbtnCategory firstCategory = (UCbtnCategory)pnlCategoriesNavbar.Controls[0];
                firstCategory.clickCategory();
            }
        }

        private void LoadItemsForSelectedCategory()
        {
            pnlProducts.Controls.Clear();

            if (_selectedCategory != null)
            {
                int currentCategoryId = Convert.ToInt32(_selectedCategory.Tag);
                List<Item> items = ItemRepository.GetByCategoryForChef(currentCategoryId);

                foreach (Item i in items)
                {
                    UCMenuEditorItem card = new UCMenuEditorItem();

                    bool isAvailable = (i.DisabledUntil == null || DateTime.Now >= i.DisabledUntil);
                    card.SetCardData(i.Id, i.Name, isAvailable);

                    card.OnStatusChanged = () =>
                    {
                        LoadItemsForSelectedCategory();
                    };

                    pnlProducts.Controls.Add(card);
                }
            }
        }

        private void EditItemsForm_Load(object sender, EventArgs e)
        {
            loadMenuForChef();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            loadMenuForChef();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialDivider2_Click(object sender, EventArgs e) { }
        private void btnLogout_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts.Length > 0)
            {
                string search = txtSearch.Texts.ToLower().Trim();

                LoadItemsForSelectedCategory();

                for (int i = pnlProducts.Controls.Count - 1; i >= 0; i--)
                {
                    if (pnlProducts.Controls[i] is UCMenuEditorItem card)
                    {
                        string itemName = card.ItemName.ToLower().Trim();

                        if (!itemName.StartsWith(search))
                        {
                            pnlProducts.Controls.RemoveAt(i);
                        }
                    }
                }
            }
            else
            {
                LoadItemsForSelectedCategory();
            }
        }
    }
}