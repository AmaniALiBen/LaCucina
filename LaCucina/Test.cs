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
            lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy"); 
        }

        private void rjPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

        }

        private void smoothFlowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton17_Click(object sender, EventArgs e)
        {
            
                UC_InvoiceItem newItem = new UC_InvoiceItem("cheese burger", 1, 15.00);

                newItem.Width = smoothFlowPanel2.Width - 25;

                smoothFlowPanel2.Controls.Add(newItem);

                smoothFlowPanel2.ScrollControlIntoView(newItem);
            
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
                    UC_InvoiceItem newItem = new UC_InvoiceItem(card.ItemName, 1,15.50);


                    smoothFlowPanel2.Controls.Add(newItem);

                    smoothFlowPanel2.ScrollControlIntoView(newItem);

                };

                smoothFlowPanel3.Controls.Add(card);
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            PopulateProducts();
            Button btn = (Button)sender;
            foreach (Control c in btn.Parent.Controls)
            {
                if (c is Button b)
                {
                    b.ForeColor = Color.FromArgb(242,242, 242); // لون النص للأزرار غير النشطة
                }
            }
            btn.ForeColor = Color.FromArgb(230, 126, 34); 
            rjPanel4.Visible = true;
            rjPanel4.Left = btn.Left + 35;            
            rjPanel4.Top = btn.Top +108;             
            rjPanel4.BringToFront();


           
        }

       
    }
}
