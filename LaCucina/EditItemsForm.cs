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

        private void PopulateProducts()
        {

            smoothFlowPanel1.Controls.Clear();


            for (int i = 0; i < 15; i++)
            {
                UCMenuEditorItem card = new UCMenuEditorItem();

               card.ItemName= "CHEESE BURGER " + i;

              

                smoothFlowPanel1.Controls.Add(card);
            }
        }
        public EditItemsForm()
        {
            InitializeComponent();
        }

        private void EditItemsForm_Load(object sender, EventArgs e)
        {

        }

        private void materialDivider2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            PopulateProducts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            KDS kDS = new KDS();
            kDS.ShowDialog();
        }
    }
}
