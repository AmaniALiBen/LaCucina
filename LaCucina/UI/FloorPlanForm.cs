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
        private Form callerForm;

        public FloorPlanForm()
        {
            InitializeComponent();
        }
        public FloorPlanForm(Form caller)
        {
            InitializeComponent();
            this.callerForm = caller;
        }

        private void FloorPlanForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Session.CurrentUser.Username.ToString();
            
        }


        private void rjButton3_Click(object sender, EventArgs e)
        {
            POSForm t= new POSForm(this,true);
            t.Show();
            this.Hide();
            
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {

            callerForm.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            if (callerForm is ManagerForm)
            {
                callerForm.Show();
            }

            
            this.Close();
        }
    }
}
