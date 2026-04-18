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
    public partial class UCDiscountManager : UserControl
    {
        public UCDiscountManager()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCDiscountManager_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 7; i++) {
                UCRowDiscount r = new UCRowDiscount();
                tablePanel1.Controls.Add(r); 
            }
        }
    }
}
