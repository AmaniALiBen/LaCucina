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
   

    public partial class UCuserRow : UserControl
    {
        private string _Username;
        private bool _isActive;
        private string _Role;
        public string Role{
            get
            {
                return _Role;
            }
            set { 
            _Role = value;
                lblRole.Text = _Role;
            
            }
        
        }
        public string Username
        {
            get {
                return _Username; 
            }
            set { 
                _Username = value;
            lblUserName.Text = _Username;
            }
        }
        public bool isActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
                if(_isActive)
                lblIsActive.Text = "Active";
                else lblIsActive.Text = "inActive";
            }
        }
       
        
        public UCuserRow()
        {
            InitializeComponent();
        }

        private void UCuserRow_Load(object sender, EventArgs e)
        {

        }
       
       
    }
}
