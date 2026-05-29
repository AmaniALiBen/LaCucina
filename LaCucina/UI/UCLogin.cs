using LaCucina.Services;
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
using LaCucina.Models;
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
            LoginService loginlogic = new LoginService();

            if (string.IsNullOrWhiteSpace(txtUserName.Texts) ||
                string.IsNullOrWhiteSpace(txtPassword.Texts))
            {
                MessageBox.Show("fill all fields");
                return;
            }

            User user = loginlogic.ConfirmLogin(
                txtUserName.Texts,
                txtPassword.Texts
            );

            if (user == null)
            {
                MessageBox.Show("not found");
                return;
            }

            txtPassword.Texts = "";
            txtUserName.Texts = "";
            txtUserName.Focus();

            Form current = this.FindForm();
            current.Hide();

            // navigation هنا في UI فقط
            switch (user.UserRole)
            {
                case Role.Admin:
                    new ManagerForm(current).ShowDialog();
                    break;

                case Role.Waiter:
                    new FloorPlanForm(current).ShowDialog();
                    break;

                case Role.Chef:
                    new KDS(current).ShowDialog();
                    break;
            }

            current.Show();
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

