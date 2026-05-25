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
    public partial class UCMenuEditorItem : UserControl
    {
        public UCMenuEditorItem()
        {
            InitializeComponent();
        }


        public string ItemName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public void lblName_Click(object sender, EventArgs e)
        {

        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked )
            {
                lblStatus.Text = "Available";

            }
            else {
                lblStatus.Text = "Not Available";
            }
        }
    }
}
