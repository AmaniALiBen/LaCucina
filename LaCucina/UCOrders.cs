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
    public partial class UCOrders : UserControl
    {
        public UCOrders()
        {
            InitializeComponent();
        }

        private void USOrders_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 20; i++)
            {
               UCInvoiceRowHeader r=new UCInvoiceRowHeader();
                UCInvoiceItemHistory h=new UCInvoiceItemHistory();

                if (i % 2 == 1)
                {
                    foreach (Control item in r.Controls)
                    {
                        item.BackColor = Color.FromArgb(10, 10, 10);


                    }
                    foreach (Control item in h.Controls)
                    {
                        item.BackColor = Color.FromArgb(27, 27, 27);


                    }
                }
                tablePanel1.Controls.Add(r);
                smoothFlowPanel1.Controls.Add(h);
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
