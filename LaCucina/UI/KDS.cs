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
    public partial class KDS : Form
    {
        Form form;
        public KDS(Form form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void rjPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            UCInvoiceCard c = new UCInvoiceCard();
            smoothFlowPanel1.Controls.Add(c);

        }
        public void InvoicesLoad()
        {
            for(int i = 0; i < 15; i++)
            {
                UCInvoiceCard c = new UCInvoiceCard();
                c.OrderNum = "Order: #"+i + 1;
                c.TableNum = "Table :" + i + 1;
                smoothFlowPanel1.Controls.Add(c);
            }
                }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            EditItemsForm editItemsForm = new EditItemsForm(this);
            editItemsForm.Show();
            //this.Hide();
        }

        private void KDS_Load(object sender, EventArgs e)
        {
            InvoicesLoad();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            form.ShowDialog();
        }
    }
}
