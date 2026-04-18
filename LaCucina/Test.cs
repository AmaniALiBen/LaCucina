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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
           
        }

        private void Test_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd /MM /yyyy"); 
        }

       

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss ");

        }


       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PopulateProducts()
        {
            
            smoothFlowPanel3.Controls.Clear();

          
            for (int i = 0; i < 15; i++)
            {
                UC_ProductCard card = new UC_ProductCard();

                card.ItemName = "CHEESE BURGER " + i;
                card.ItemPrice = (15.50 + i).ToString() + " LYD";
                // card.ItemImage = Image.FromFile("path_to_image"); 

                card.Click += (s, e) =>
                {

                    IngredientsSelector ing = new IngredientsSelector();
                    ing.ShowDialog();
                    if (ing.DialogResult == DialogResult.OK)
                    {
                        UC_InvoiceItem newItem = new UC_InvoiceItem(card.ItemName, 1, 15.50);
                        newItem.DataChanged += Item_DataChanged;
                        smoothFlowPanel2.Controls.Add(newItem);
                        ing.Close();
                        CalTotal();

                    }
                    else if (ing.DialogResult == DialogResult.Cancel)
                        ing.Close();



                };

                smoothFlowPanel3.Controls.Add(card);
            }
        }
        private void Item_DataChanged(object sender, EventArgs e)
        {
            CalTotal();
        }
        public void CalTotal()
        {
            double finalTotal = 0;

            foreach (Control ctrl in smoothFlowPanel2.Controls)
            {
                if (ctrl is UC_InvoiceItem item)
                {
                    finalTotal += item.Subtotal;
                }
               
            }
            if (smoothFlowPanel2.Controls.Count == 0)
            {
                finalTotal = 0.00;
            }

            lblTotalPrice.Text = finalTotal.ToString("N2") + " LYD";
        }
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            PopulateProducts();
            Button btn = (Button)sender;
            foreach (Control c in btn.Parent.Controls)
            {
                if (c is Button b)
                {
                    b.ForeColor = Color.FromArgb(242,242, 242);
                    b.BackColor = Color.FromArgb(28, 28, 28);
                    b.Font = new Font(b.Font, FontStyle.Regular);
                }
            }
            btn.ForeColor = Color.FromArgb(230, 126, 34);
            btn.BackColor = Color.FromArgb(17, 17, 17);
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            // rjPanel4.Visible = true;
           


           
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void smoothFlowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
           OrdersForm form = new OrdersForm();
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FloorPlanForm floor = new FloorPlanForm(this);
            floor.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
