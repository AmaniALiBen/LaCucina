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
    public partial class FloorPlanForm : Form
    {
        Form form;
        Form loginForm;
        //public FloorPlanForm(Form form)
        //{this.form = form;
        //    InitializeComponent();
        //}
        
        public FloorPlanForm()
        {
            InitializeComponent();
        }
        public FloorPlanForm(Form loginForm)
        {
            this.loginForm = loginForm;
            
            InitializeComponent();
        }

        private void FloorPlanForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Session.CurrentUser.Username.ToString();
            
        }


        private void rjButton3_Click(object sender, EventArgs e)
        {
            POSForm t= new POSForm(this.FindForm(),true);
            t.ShowDialog();
            this.Hide();
            
        }

        //private void btnLogout_Click(object sender, EventArgs e)
        //{
        //    form.Show();
        //    this.Close();
        //}

        private void btnLogout_Click(object sender, EventArgs e)
        {

            loginForm.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
