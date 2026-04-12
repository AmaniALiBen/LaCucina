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
        private double _unitPrice;
        private int _qty;

      
        public string ItemName
        {
            get => lblItemName.Text;
            set => lblItemName.Text = value;
        }

        public int Quantity
        {
            get => _qty;
            set
            {
                _qty = value;
                lblQty.Text =  _qty.ToString();
                UpdateSubtotal(); 
            }
        }

        public double UnitPrice
        {
            get => _unitPrice;
            set { _unitPrice = value; UpdateSubtotal(); }
        }
        public UC_InvoiceItem(string name, int qty, double price)
        {
           
                InitializeComponent();
            this.ItemName = name;
            this._unitPrice = price;
            this.Quantity = qty;

        }
        private void UpdateSubtotal()
        {
            lblPrice.Text = (_qty * _unitPrice).ToString("N2") + " LYD";
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

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void UC_InvoiceItem_Load(object sender, EventArgs e)
        {

        }
    }
}
