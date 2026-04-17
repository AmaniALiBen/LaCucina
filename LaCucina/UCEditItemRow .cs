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
    
    public partial class UCEditItemRow : UserControl
    {
        public string ItemText
        {
            get { return lblItem.Text; }
            set { lblItem.Text = value; }
        }
        public UCEditItemRow()
        {
            InitializeComponent();
        }
    }
}
