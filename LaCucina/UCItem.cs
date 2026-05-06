using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaCucina
{
    public partial class UCItem : UserControl
    {

        int id = 1;
        public string ImagePath;
        public UCItem()
        {
            InitializeComponent();
           
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
            UCIngredientInItem ing = new UCIngredientInItem(++DataBase.ingredientInItemCounter,this.id, ingredientId, rbtnAddToMain.Checked);
            DataBase.ingredientInItem.Add(DataBase.ingredientInItemCounter, ing);


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
            //Item item = new Item(++DataBase.itemCounter,txtName.Texts,Convert.ToBoolean( txtPrice.Texts), btnActive.Checked,"lll");
        }
    }
}
