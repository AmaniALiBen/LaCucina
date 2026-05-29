using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina.UI
{
    public partial class btnIngredient : UserControl
    {
        private string name;
        public string btnName
        {
            get { return name; }
            set { name = value; 
            lblIngName.Text = value;
            }
        }
        public btnIngredient()
        {
            InitializeComponent();
        }
    }
}
