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
        public KDS()
        {
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
    }
}
