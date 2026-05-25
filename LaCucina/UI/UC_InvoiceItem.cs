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
    public partial class UC_InvoiceItem : UserControl
    {
        private double total;
        private int qty;
        public event EventHandler DataChanged;

        public string ItemName
        {
            get => lblItemName.Text;
            set => lblItemName.Text = value;
        }

        public int Quantity
        {
            get => qty;
            set
            {
                qty = value;
                lblQty.Text =  qty.ToString();
                UpdateSubtotal(); 
            }
        }

        public double Price
        {
            get => total;
            set { total = value; UpdateSubtotal(); }
        }
        public UC_InvoiceItem(string name, int qty, double price)
        {
           
                InitializeComponent();
            this.ItemName = name;
            this.total = price;
            this.Quantity = qty;
            this.Price = total;

        }
        public double Subtotal => qty * total;
        private void UpdateSubtotal()
        {
            lblTotal.Text = (qty * total).ToString("N2") ;

        }


        private void RemoveItem()
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
              
            }
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            if (Quantity > 1)
            {
                Quantity--;
                DataChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
               
                RemoveItem();
            }
        }

        private void lblQty_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            Quantity++;
            DataChanged?.Invoke(this, EventArgs.Empty);


        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            RemoveItem();
            DataChanged?.Invoke(this, EventArgs.Empty);

        }

        private void UC_InvoiceItem_Load(object sender, EventArgs e)
        {

        }
    }
}
