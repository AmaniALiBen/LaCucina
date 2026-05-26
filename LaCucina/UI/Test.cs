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
        UCbtnCategory _selectedCategory;
        public void loadMenu()
        {

            pnlCAtegories.Controls.Clear();
            foreach (var entry in DataBase.category)
            {
                var key = entry.Key;
                var value = entry.Value;
                UCbtnCategory category = new UCbtnCategory();
                category._Name = value.name;
                category.Tag = key;


                category.clickCategory = () =>
                {
                    category.btnName.ForeColor = Color.DarkOrange;
                    
                    _selectedCategory = category;
                    foreach (UCbtnCategory c in pnlCAtegories.Controls)
                    {

                        if (c != _selectedCategory)
                        {
                             c.btnName.ForeColor = Color.FromArgb(242, 242, 242);
                           
                        }

                    }
                    pnlItems.Controls.Clear();
                    foreach (Item i in DataBase.items.Values)
                    {
                        UC_ProductCard card = new UC_ProductCard();
                        if (i.CategoryId == value.id)
                        {

                            card.Name = i.Name;
                            card.Price = i.Price;
                            card.Id = i.Id;

                            pnlItems.Controls.Add(card);

                        }
                       
                    }

                };
               




                pnlCAtegories.Controls.Add(category);
        
            }

        }
        Form form;
        public Test()
        {
            InitializeComponent();
           
        }
        public Test(Form form)
        {
            this.form = form;
            InitializeComponent();

        }

        private void Test_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd /MM /yyyy");
            loadMenu();
            lblUser.Text = Session.CurrentUser.Username;
        }

       

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss ");

        }


       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void PopulateProducts()
        //{
            
        //    pnlItems.Controls.Clear();

          
        //    for (int i = 0; i < 15; i++)
        //    {
        //        UC_ProductCard card = new UC_ProductCard();

        //        card.ItemName = "CHEESE BURGER " + i;
        //        card.ItemPrice = (15.50 + i).ToString() + " LYD";
        //        // card.ItemImage = Image.FromFile("path_to_image"); 

        //        card.Click += (s, e) =>
        //        {

        //            IngredientsSelector ing = new IngredientsSelector();
        //            ing.ShowDialog();
        //            if (ing.DialogResult == DialogResult.OK)
        //            {
        //                UC_InvoiceItem newItem = new UC_InvoiceItem(card.ItemName, 1, 15.50);
        //                newItem.DataChanged += Item_DataChanged;
        //                smoothFlowPanel2.Controls.Add(newItem);
        //                ing.Close();
        //                CalTotal();

        //            }
        //            else if (ing.DialogResult == DialogResult.Cancel)
        //                ing.Close();



        //        };

        //        pnlItems.Controls.Add(card);
        //    }
        //}
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
          //  PopulateProducts();
            //Button btn = (Button)sender;
            //foreach (Control c in btn.Parent.Controls)
            //{
            //    if (c is Button b)
            //    {
            //        b.ForeColor = Color.FromArgb(242,242, 242);
            //        b.BackColor = Color.FromArgb(28, 28, 28);
            //        b.Font = new Font(b.Font, FontStyle.Regular);
            //    }
            //}
            //btn.ForeColor = Color.FromArgb(230, 126, 34);
            //btn.BackColor = Color.FromArgb(17, 17, 17);
            //btn.Font = new Font(btn.Font, FontStyle.Bold);
           


           
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
           form.Show();
           
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void rjButton7_Click(object sender, EventArgs e)
        {

        }
    }
}
