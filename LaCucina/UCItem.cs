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
        public Action OnClose;
        bool picChanged = false;

        public UCItem(int id, bool isEditing)
        {
            this.id = id;
            this.isEditing = isEditing;

            InitializeComponent();
            fillSearchResultPanel();
            fillCmbCategory();
            LoadInfo();
        }

       
        private void SetPicImage(Image newImage)
        {
            if (picItem.Image != null)
            {
                picItem.Image.Dispose();
                picItem.Image = null;
            }
            picItem.Image = newImage;
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

                txtName.Texts = item.Name;
                txtPrice.Texts = item.Price.ToString();
                btnActive.Checked = item.IsActive;

                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                string imagePath = Path.Combine(imagesFolder, $"{item.Id}.png");

                if (File.Exists(imagePath))
                {
                    SetPicImage(new Bitmap(imagePath));
                }

                foreach (Categories category in cmbCatagory.Items)
                {
                    if (item.CategoryId == category.id)
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
                        pnlMainIngredients.Controls.Add(ing);
                    else
                        pnlSideIngredients.Controls.Add(ing);
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
                picChanged = true;
                SetPicImage(new Bitmap(ofd.FileName));
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
            if (UCIngredient.lastSelectedIngredient == null)
            {
                MessageBox.Show("Please select an ingredient first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            addIngrediantToPannel(UCIngredient.lastSelectedIngredient.id);
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
                if (!Directory.Exists(imagesFolder))
                    Directory.CreateDirectory(imagesFolder);

                string destination = Path.Combine(imagesFolder, $"{this.id}.png");

                Image img = picItem.Image;
                picItem.Image = null;

                if (File.Exists(destination))
                    File.Delete(destination);

                img.Save(destination, System.Drawing.Imaging.ImageFormat.Png);

                SetPicImage(new Bitmap(destination));
            }
        }

        public void saveItem()
        {
            if (string.IsNullOrWhiteSpace(txtName.Texts))
            {
                MessageBox.Show("Please enter item name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCatagory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtPrice.Texts, out double price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (picChanged)
            { savePic(); }

            Categories selectedCategory = (Categories)cmbCatagory.SelectedItem;

            Item item = new Item(
                this.id,
                txtName.Texts,
                selectedCategory.id,
                price,
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
                        remove.Add(ingredientInItem.Key);
                }

                foreach (int key in remove)
                    DataBase.ingredientInItem.Remove(key);
            }

            foreach (UCIngredientInItem control in pnlMainIngredients.Controls.OfType<UCIngredientInItem>())
            {
                DataBase.ingredientInItem.Add(control.id, control);
            }

            foreach (UCIngredientInItem control in pnlSideIngredients.Controls.OfType<UCIngredientInItem>())
            {
                DataBase.ingredientInItem.Add(control.id, control);
            }

            MessageBox.Show("Item saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanupImages();
            OnClose?.Invoke();
        }
        private void CleanupImages()
        {
            // Dispose the image to release file lock
            if (picItem.Image != null)
            {
                picItem.Image.Dispose();
                picItem.Image = null;
            }
        }
        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            saveItem();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel?\nAny unsaved changes will be lost.",
                "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { CleanupImages(); OnClose?.Invoke(); }
        }
    }
}