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
        Form loginForm;
       
        Button selectedButton;
        public ManagerForm()
        {
            InitializeComponent();
           
        }
        public ManagerForm(Form loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();

        }


        private void ManagerForm_Load(object sender, EventArgs e)
        {
            btnFloorplan.PerformClick();
            lblUser.Text = Session.CurrentUser.Username;
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
            UCUserManegment uS = new UCUserManegment();
            uS.Dock = DockStyle.Fill;
            panel2.Controls.Add(uS);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UCManagerMenu uS = new UCManagerMenu();
            //UCItem uS=new UCItem(1,true);
            uS.Dock = DockStyle.Fill;
            panel2.Controls.Add(uS);

        }

        private void btnOrdersHistory_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UCOrders uS = new UCOrders();
            uS.Dock = DockStyle.Fill;
            panel2.Controls.Add(uS);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Session.Logout();
            this.Close();
            
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            UCDiscountManager uc = new UCDiscountManager();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
        }
    }
}
