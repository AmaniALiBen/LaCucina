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
    public partial class Form1 : Form
    {
        public Form1()
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
            form.ShowDialog();
            this.Hide();
        }
    }
}
