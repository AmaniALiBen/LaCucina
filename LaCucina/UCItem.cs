using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaCucina
{

    public partial class UCItem : UserControl
    {
       

        int id;
       
        bool isEditing;

        public UCItem(int id,bool isEditing)
        {
            this.id = id;
            this.isEditing=isEditing;
            InitializeComponent();

            cmbCatagory.ValueMember = "id";
            foreach (var category in DataBase.category)
            {
                cmbCatagory.Items.Add(category.Value);
            }
            if (isEditing)
            {
                Item item = DataBase.items[id];
                txtName.Texts = item.name;
                txtPrice.Texts=item.price.ToString();
                btnActive.Checked = item.isActive;
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                string imagePath = Path.Combine(imagesFolder, $"{item.id}.png");
                picItem.Image = Image.FromFile(imagePath);
                foreach (Categories category in cmbCatagory.Items)
                {
                    if (item.categoryId == category.id)
                    { cmbCatagory.SelectedItem = category; break; }
                }
                foreach(var ingredientInItem in DataBase.ingredientInItem)
                {
                    if(ingredientInItem.Value.itemId==this.id)
                    {
                        UCIngredientInItem ing = ingredientInItem.Value;
                        if (ingredientInItem.Value.isMain)
                        {
                            pnlMainIngredients.Controls.Add(ing);
                        }
                        else { pnlSideIngredients.Controls.Add(ing); }
                    }
                }
            }


        }

        private void picItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picItem.Image = Image.FromFile(ofd.FileName);
                picItem.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void UCItem_Load(object sender, EventArgs e)
        {
            foreach (var ingredient in DataBase.ingredients)
            {
                pnlSearchResults.Controls.Add(ingredient.Value);
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

            if (pnlSearchResults.Controls.Count == 0) { btnAddAsNew.Visible = true; }
            else { btnAddAsNew.Visible = false; } 

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
            UCIngredient ing = new UCIngredient(++DataBase.ingredientCounter, txtSearch.Texts);
            DataBase.ingredients.Add(DataBase.ingredientCounter, ing);

            btnAddAsNew.Visible = false;
            txtSearch.Texts = "";
            addIngrediantToPannel(DataBase.ingredientCounter);

        }

        private void addIngrediantToPannel(int ingredientId) 
        {
            foreach(var item in DataBase.ingredientInItem)
            {
                if(item.Value.ingredientId==ingredientId&&item.Value.itemId==this.id)return;
            }
            UCIngredientInItem ing = new UCIngredientInItem(++DataBase.ingredientInItemCounter,this.id, ingredientId, rbtnAddToMain.Checked);


            if (rbtnAddToMain.Checked) { pnlMainIngredients.Controls.Add(ing); }
            else { pnlSideIngredients.Controls.Add(ing); }

        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            addIngrediantToPannel(UCIngredient.lastSelectedIngredient.id);
        }

        private void UCItem_Load_1(object sender, EventArgs e)
        {
            fillSearchResultPanel();
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            if (picItem.Image != null)
            {
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                Directory.CreateDirectory(imagesFolder);
                string destination = Path.Combine(imagesFolder, $"{++DataBase.itemCounter}.png");
                picItem.Image.Save(destination, System.Drawing.Imaging.ImageFormat.Png);
               
                
            }
            else { ++DataBase.itemCounter; }

            Categories selectedCategory = (Categories)cmbCatagory.SelectedItem;
            Item item = new Item(DataBase.itemCounter,txtName.Texts, selectedCategory.id, Convert.ToDouble( txtPrice.Texts), btnActive.Checked);
            DataBase.items.Add(DataBase.itemCounter, item);
            foreach (UCIngredientInItem control in pnlMainIngredients.Controls.OfType<UCIngredientInItem>()) 
            {
                DataBase.ingredientInItem.Add(control.id, control);

            }
            foreach (UCIngredientInItem control in pnlSideIngredients.Controls.OfType<UCIngredientInItem>())
            {
                DataBase.ingredientInItem.Add(control.id, control);

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
