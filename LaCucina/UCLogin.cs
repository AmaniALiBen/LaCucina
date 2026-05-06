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
           bool confirm= loginlogic.ConfirmLogin(txtUserName.Texts, txtPassword.Texts);
            if (confirm) loginlogic.ShowDialog(this.FindForm());
            else MessageBox.Show("not found", "");
        }
    }
}

