using LaCucina.DataLink;
using LaCucina.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UCItem : UserControl
    {
        public int id;
        public bool isEditing;
        public Action OnClose;
        public bool picChanged = false;
        private menuItemIngredientsRepository itemIngredientsRepo = new menuItemIngredientsRepository();
        private IngredientsRepository ingredientsRepository = new IngredientsRepository();
        private CategoryRepository categoryRepository = new CategoryRepository();

        public UCItem(int id, bool isEditing)
        {
            this.id = id;
            this.isEditing = isEditing;
            categoriesList = categoryRepository.GetAll();
            InitializeComponent();
            fillSearchResultPanel();
            fillCmbCategory();
            LoadInfo();
        }
        public UCItem()
        {
            categoriesList = categoryRepository.GetAll();
        }


        List<Categories> categoriesList = new List<Categories>();
        List<ingredients> ingredientsList = new List<ingredients>();
        List<menu_item_ingredients> itemIngredientsList = new List<menu_item_ingredients>();


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


            foreach (Categories category in categoriesList)
            {
                cmbCatagory.Items.Add(category.name);
            }
        }

        public void LoadInfo()
        {
            if (isEditing)
            {
                ItemRepository repo = new ItemRepository();
                Item item = repo.GetById(id);

                txtName.Texts = item.Name;
                txtPrice.Texts = item.Price.ToString();
                btnActive.Checked = item.IsActive;

                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                string imagePath = Path.Combine(imagesFolder, $"{item.Id}.png");

                if (File.Exists(imagePath))
                {
                    SetPicImage(new Bitmap(imagePath));
                }

                foreach (Categories category in categoriesList)
                {
                    if (item.CategoryId == category.id)
                    {
                        cmbCatagory.SelectedItem = category.name;
                        break;
                    }
                }

                fillIngredintsPanels();
            }
        }

        public void fillIngredintsPanels()
        {


            pnlMainIngredients.Controls.Clear();
            pnlSideIngredients.Controls.Clear();

            this.itemIngredientsList = itemIngredientsRepo.GetByMenuItem(this.id);

            foreach (menu_item_ingredients itemIngredient in this.itemIngredientsList)
            {
                UCIngredientInItem ing = new UCIngredientInItem();
                ing.ingredientId = itemIngredient.IngredientId;
                ing.itemId = itemIngredient.ItemId;
                ing.isMain = itemIngredient.IsMain;

                ingredients i = ingredientsRepository.GetById(itemIngredient.IngredientId);
                if (i != null)
                {
                    ing.Name = i.Name;

                    if (itemIngredient.IsMain)
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

            string query = txtSearch.Texts.ToLower().Trim();

            this.ingredientsList = ingredientsRepository.GetAll();

            foreach (ingredients ingredient in this.ingredientsList)
            {
                if (ingredient.IsDeleted) continue;

                if (ingredient.Name.ToLower().StartsWith(query))
                {
                    UCIngredient u = new UCIngredient();
                    u.Name = ingredient.Name;
                    u.Id = ingredient.Id;

                    u.OnIngredientDeleted = () => {
                        RefreshAllPanelsAfterDelete();
                    };

                    pnlSearchResults.Controls.Add(u);
                }
            }

            if (pnlSearchResults.Controls.Count == 0 && !string.IsNullOrEmpty(query))
                btnAddAsNew.Visible = true;
            else
                btnAddAsNew.Visible = false;
        }
        public void RefreshAllPanelsAfterDelete()
        {
            fillSearchResultPanel();

            pnlMainIngredients.Controls.Clear();
            pnlSideIngredients.Controls.Clear();

            itemIngredientsList = itemIngredientsRepo.GetAll();

            fillIngredintsPanels();
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
            string name = txtSearch.Texts.Trim();
            if (string.IsNullOrEmpty(name)) return;

            int newId = ingredientsRepository.Add(name);

            ingredients i = new ingredients(newId, name, false);
            ingredientsList.Add(i);

            addIngrediantToPannel(newId, name, isNew: true);
        }

        private void addIngrediantToPannel(int ingredientId, string name, bool isNew)
        {
            var existingControls = pnlMainIngredients.Controls.OfType<UCIngredientInItem>()
           .Concat(pnlSideIngredients.Controls.OfType<UCIngredientInItem>());

            foreach (var control in existingControls)
            {
                if (control.ingredientId == ingredientId)
                {
                    MessageBox.Show("This ingredient is already added to the list!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            UCIngredientInItem ing = new UCIngredientInItem();
            ing.itemId = this.id;
            ing.ingredientId = ingredientId;
            ing.Name = name;
            ing.isMain = rbtnAddToMain.Checked;

            if (rbtnAddToMain.Checked)
                pnlMainIngredients.Controls.Add(ing);
            else
                pnlSideIngredients.Controls.Add(ing);

            btnAddAsNew.Visible = false;
            txtSearch.Texts = "";
            fillSearchResultPanel();
        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            if (UCIngredient.lastSelectedIngredient == null)
            {
                MessageBox.Show("Please select an ingredient first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            addIngrediantToPannel(UCIngredient.lastSelectedIngredient.id, UCIngredient.lastSelectedIngredient.Name, isNew: false);
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
                MessageBox.Show("Please enter item name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCatagory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtPrice.Texts, out double price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (picChanged) { savePic(); }

            int selectedCategoryId = 0;
            foreach (Categories category in categoriesList)
            {
                if (category.name == cmbCatagory.SelectedItem.ToString())
                {
                    selectedCategoryId = category.id;
                    break;
                }
            }

            Item item = new Item(
                this.id,
                txtName.Texts.Trim(),
                selectedCategoryId,
                price,
                btnActive.Checked
            );

            if (this.isEditing)
            {
                ItemRepository repo = new ItemRepository();
                repo.Update(item);
                itemIngredientsRepo.DeleteAllByMenuItem(this.id);
            }
            else
            {
                ItemRepository repo = new ItemRepository();
                this.id = repo.Add(item);
            }


            foreach (UCIngredientInItem control in pnlMainIngredients.Controls.OfType<UCIngredientInItem>())
            {
                menu_item_ingredients mIngredients = new menu_item_ingredients(this.id, control.ingredientId, isMain: true);
                itemIngredientsRepo.Add(mIngredients);
            }

            foreach (UCIngredientInItem control in pnlSideIngredients.Controls.OfType<UCIngredientInItem>())
            {
                menu_item_ingredients mIngredients = new menu_item_ingredients(this.id, control.ingredientId, isMain: false);
                itemIngredientsRepo.Add(mIngredients);
            }

            MessageBox.Show("New Item and its ingredients saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            pnlMainIngredients.Controls.Clear();
            pnlSideIngredients.Controls.Clear();
            CleanupImages();
            OnClose?.Invoke();
        }
        public void CleanupImages()
        {
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

        private void rjPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}