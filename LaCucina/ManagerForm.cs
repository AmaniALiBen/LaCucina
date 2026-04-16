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
    public partial class ManagerForm : Form
    {
        Button selectedButton;
        public ManagerForm()
        {
            InitializeComponent();
           
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }


        private void btnFloorplan_Click(object sender, EventArgs e)
        { 

            panel2.Controls.Clear();
            USFloorplanEditor uS = new USFloorplanEditor();
            uS.Dock= DockStyle.Fill;
            panel2.Controls.Add(uS);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            USuserManegment uS = new USuserManegment();
            uS.Dock = DockStyle.Fill;
            panel2.Controls.Add(uS);
        }
    }
}
