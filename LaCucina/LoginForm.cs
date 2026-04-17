using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaCucina;

namespace LaCucina
{
    public partial class LoginForm : Form
    {
        

        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

         

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //MainForm form = new MainForm();
            //Test form=new Test();
            //FloorPlanForm form = new FloorPlanForm();
            //FloorPlanManagerForm form = new FloorPlanManagerForm();
            ManagerForm form = new ManagerForm();
            //Test form = new Test();
            form.ShowDialog();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucLogin1_Load(object sender, EventArgs e)
        {

        }
    }
}
