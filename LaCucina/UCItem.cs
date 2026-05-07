using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UCItem : UserControl
    {
        int id;
        bool isEditing;

        public UCItem(int id, bool isEditing)
        {
            this.id = id;
            this.isEditing = isEditing;

            InitializeComponent();
            fillSearchResultPanel();
            fillCmbCategory();
            LoadInfo();


        }
       
        public void fillCmbCategory()
        {
            cmbCatagory.ValueMember = "id";

            foreach (var category in DataBase.category)
            {
                cmbCatagory.Items.Add(category.Value);
            }
        }

        
        public void LoadInfo()
        {
            if (isEditing)
            {
                Item item = DataBase.items[this.id];

                txtName.Texts = item.name;
                txtPrice.Texts = item.price.ToString();
                btnActive.Checked = item.isActive;

                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                string imagePath = Path.Combine(imagesFolder, $"{item.id}.png");

                if (File.Exists(imagePath))
                {
                    Image temp = Image.FromFile(imagePath);
                    picItem.Image = new Bitmap(temp);
                    temp.Dispose();
                }

                foreach (Categories category in cmbCatagory.Items)
                {
                    if (item.categoryId == category.id)
                    {
                        cmbCatagory.SelectedItem = category;
                        break;
                    }
                }

                
                fillIngredintsPanels();

            }
        }
        public void fillIngredintsPanels() 
        {

            foreach (var ingredientInItem in DataBase.ingredientInItem)
            {
                if (ingredientInItem.Value.itemId == this.id)
                {
                    UCIngredientInItem ing = ingredientInItem.Value;

                    if (ingredientInItem.Value.isMain)
                    {
                        pnlMainIngredients.Controls.Add(ing);
                    }
                    else
                    {
                        pnlSideIngredients.Controls.Add(ing);
                    }
                }
            }
        }
        private void picItem_Click(object sender, EventArgs e)
        {
            choosePic();
        }
        public void choosePic() 
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {


                Image temp = Image.FromFile(ofd.FileName);
                picItem.Image = new Bitmap(temp);
                temp.Dispose();

                picItem.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        
        public void fillSearchResultPanel()
        {
            pnlSearchResults.Controls.Clear();

            string query = txtSearch.Texts.ToLower();

            foreach (var ingredient in DataBase.ingredients)
            {
                if (ingredient.Value.name.ToLower().Contains(query))
                {
                    pnlSearchResults.Controls.Add(ingredient.Value);
                }
            }

            if (pnlSearchResults.Controls.Count == 0)
                btnAddAsNew.Visible = true;
            else
                btnAddAsNew.Visible = false;
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            fillSearchResultPanel();
        }

        private void btnAddAsNew_Click(object sender, EventArgs e)
        {
            addNewIngredient();
        }

        private void addNewIngredient()
        {
            UCIngredient ing = new UCIngredient(
                ++DataBase.ingredientCounter,
                txtSearch.Texts
            );

            DataBase.ingredients.Add(DataBase.ingredientCounter, ing);

            btnAddAsNew.Visible = false;
            txtSearch.Texts = "";

            addIngrediantToPannel(DataBase.ingredientCounter);
        }

        private void addIngrediantToPannel(int ingredientId)
        {
            foreach (var item in DataBase.ingredientInItem)
            {
                if (item.Value.ingredientId == ingredientId &&
                    item.Value.itemId == this.id)
                    return;
            }

            UCIngredientInItem ing = new UCIngredientInItem(
                ++DataBase.ingredientInItemCounter,
                this.id,
                ingredientId,
                rbtnAddToMain.Checked
            );

            if (rbtnAddToMain.Checked)
                pnlMainIngredients.Controls.Add(ing);
            else
                pnlSideIngredients.Controls.Add(ing);
        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            addIngrediantToPannel(
                UCIngredient.lastSelectedIngredient.id
            );
        }

        private void UCItem_Load_1(object sender, EventArgs e)
        {
            fillSearchResultPanel();
        }

        public void savePic()
        {
            if (picItem.Image != null)
            {
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");

                string destination = Path.Combine(imagesFolder, $"{this.id}.png");


                if (File.Exists(destination))
                {
                    File.Delete(destination);
                }

                picItem.Image.Save(destination, System.Drawing.Imaging.ImageFormat.Png);

            }
        }
        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            saveItem();
        }

        public void saveItem()
        {
            savePic();
            Categories selectedCategory = (Categories)cmbCatagory.SelectedItem;


            Item item = new Item(
                this.id,
                txtName.Texts,
                selectedCategory.id,
                Convert.ToDouble(txtPrice.Texts),
                btnActive.Checked
            );

            if (this.isEditing)
                DataBase.items[this.id] = item;
            else
                DataBase.items.Add(this.id, item);

            if (isEditing)
            {
                List<int> remove = new List<int>();

                foreach (var ingredientInItem in DataBase.ingredientInItem)
                {
                    if (ingredientInItem.Value.itemId == this.id)
                    {
                        remove.Add(ingredientInItem.Key);
                    }
                }

                foreach (int id in remove)
                {
                    DataBase.ingredientInItem.Remove(id);
                }
            }

            foreach (UCIngredientInItem control
                in pnlMainIngredients.Controls.OfType<UCIngredientInItem>())
            {
                DataBase.ingredientInItem.Add(control.id, control);
            }

            foreach (UCIngredientInItem control
                in pnlSideIngredients.Controls.OfType<UCIngredientInItem>())
            {
                DataBase.ingredientInItem.Add(control.id, control);
            }
        }

    }
}