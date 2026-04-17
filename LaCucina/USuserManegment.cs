using CustomControls.RJControls;
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
    public partial class USuserManegment : UserControl
    {
        public USuserManegment()
        {
            InitializeComponent();
        }

        
        private void smoothFlowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void USuserManegment_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                UCrow r = new UCrow();
                if (i % 2 == 0) {
                    foreach (Control item in r.Controls)
                    {
                        item.BackColor= Color.FromArgb(18, 18, 18);
                       

                    }
                }
                tablePanel1.Controls.Add(r);
            }
            

        }

        private void rjButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
