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
    public partial class UCbtnCategory : UserControl
    {
        
        public Action clickCategory;
        public string name;
       
        
        public string _Name
        {
            get { return name; }
            set { name = value; 
            btnName.Text = value;
            }
        }

        
        public UCbtnCategory()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            clickCategory?.Invoke();
        }
    }
}
