using CustomControls.RJControls;
using LaCucina;
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


        private void professionalNavPanel1_Paint(object sender, PaintEventArgs e)
        {
            int l = (rjPanel2.Size.Width / 2 - (professionalNavPanel1.Width / 2));
            professionalNavPanel1.Location = new Point(l);
        }

        private void btnFloorplan_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            USFloorplanEditor uS = new USFloorplanEditor();
            uS.Dock = DockStyle.Fill;
            panel2.Controls.Add(uS);
        }

        

        private void btnUsers_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            USUserManegment uS = new USUserManegment();
            uS.Dock = DockStyle.Fill;
            panel2.Controls.Add(uS);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UCManagerMenu uS = new UCManagerMenu();
            uS.Dock = DockStyle.Fill;
            panel2.Controls.Add(uS);

        }

        private void btnOrdersHistory_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            USOrders uS = new USOrders();
            uS.Dock = DockStyle.Fill;
            panel2.Controls.Add(uS);
        }
    }
}
