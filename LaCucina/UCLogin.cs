using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UCLogin : UserControl
    {

        


        string[] username = { "admin", "waiter", "chef" };
        public UCLogin()
        {
            InitializeComponent();
        }

        private void UCLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateToppings_Click(object sender, EventArgs e)
        {
            
           

            if (txtUserName.Texts == "admin")
            { this.Parent.Hide();
                ManagerForm form = new ManagerForm(this.FindForm());
                form.ShowDialog();
            }
            else if (txtUserName.Texts == "waiter")
            {
                this.Parent.Hide();
                FloorPlanForm form = new FloorPlanForm(this.FindForm());
                form.ShowDialog();
            }
            else if(txtUserName.Texts == "chef")
            {
                this.Parent.Hide();
                KDS form = new KDS(this.FindForm());
                form.ShowDialog();

            }
            else
            {
                txtUserName.PlaceholderText = "wrong user name";
            }



               


        }
    }
}
