using CustomControls.RJControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UC_InvoiceItem : UserControl
    {
        private double total;
        private int qty;

        public event EventHandler DataChanged;
        public event EventHandler ItemRemoved; 

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
                lblQty.Text = qty.ToString();
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
            lblTotal.Text = (qty * total).ToString("N2");
        }

        public void MarkAsSavedInDatabase()
        {
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;

            if (btnDelete != null) btnDelete.Enabled = false;

            lblItemName.ForeColor = Color.Gray;
            lblItemName.Font = new Font(lblItemName.Font, lblItemName.Font.Style | FontStyle.Strikeout);
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
                ItemRemoved?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            Quantity++;
            DataChanged?.Invoke(this, EventArgs.Empty);
        }

        
        

        private void lblQty_Click(object sender, EventArgs e) { }
        private void UC_InvoiceItem_Load(object sender, EventArgs e) { }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemRemoved?.Invoke(this, EventArgs.Empty);

        }
    }
}