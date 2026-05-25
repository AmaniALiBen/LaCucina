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

       
        public UCLogin()
        {
            InitializeComponent();
        }

        private void UCLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAccessSystem_Click(object sender, EventArgs e)
        {
            LoginLogic loginlogic = new LoginLogic();
            if (string.IsNullOrEmpty(txtPassword.Texts) || string.IsNullOrEmpty(txtUserName.Texts))
            {
                MessageBox.Show("fill all fields");
            }
            else {
                bool confirm = loginlogic.ConfirmLogin(txtUserName.Texts, txtPassword.Texts);
                if (confirm)
                {
                    txtPassword.Texts = "";
                    txtUserName.Texts = "";
                    txtUserName.Focus();
                    loginlogic.ShowDialog(this.FindForm());
                }
                else MessageBox.Show("not found", "");
            }
          
        }

       
        

        private void txtUserName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                btnAccessSystem.PerformClick();
            }
        }
    }
}

