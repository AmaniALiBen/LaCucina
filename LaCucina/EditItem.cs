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
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void FpnlRequiredIngredients_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddMainIngredient_Click(object sender, EventArgs e)
        {
              UCEditItemRow row = new UCEditItemRow();
               row.ItemText=txtMain.Texts;
            if(txtMain.Texts.Length > 0 )
               FpnlRequiredIngredients.Controls.Add(row);
            txtMain.Texts = "";

        }

        private void btnAddTopping_Click(object sender, EventArgs e)
        {
            UCEditItemRow row = new UCEditItemRow();
            row.ItemText = txtTopping.Texts;
            if(txtTopping.Texts.Length>0)
            fpnlToppings.Controls.Add(row);
             txtTopping.Texts = "";
        }
    }
}
