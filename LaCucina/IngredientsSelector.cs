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
    public partial class IngredientsSelector : Form
    {
        public IngredientsSelector()
        {
            InitializeComponent();
        }

        private void rjPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IngredientsSelector_Load(object sender, EventArgs e)
        {
            FillIngredients();
        }
        public void FillIngredients()
        {
            string []arr1 = { "Onion", "Tomato", "Lettuce", "Pickles", "Jalapeños", "Mushrooms", "Ketchup", "Mayonnaise", "Mustard", "BBQ Sauce" };
            string[] arr2 = { "Bun", "Beef Patty" };
             for(int i =0; i < 10; i++)
                {
                UCIngriedentsSelectorRow row = new UCIngriedentsSelectorRow();
                row.checkBox1.Text = arr1[i];
                row.checkBox1.Checked = true;
                FpnlIngredients.Controls.Add(row);
;
                }
             for(int i = 0; i < 2; i++)
            {
                UCIngriedentsSelectorRow row = new UCIngriedentsSelectorRow();
                row.checkBox1.Text = arr2[i];
                row.checkBox1.Checked = true;
                row.checkBox1.Enabled = false;
                FpnlRequiredIngredients.Controls.Add(row);


            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateToppings_Click(object sender, EventArgs e)
        {

        }

        private void rJgradiantPanal2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
