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
    public partial class btnOptionalIngredient : UserControl
    {
        private string name;
        private int Id;
        private bool cheacked =true ;
        public Action btnClick;
        public int IngredientId
        {
            get { return Id; }
            set { Id = value; }
        }
        public string btnName
        {
            get { return name; }
            set
            {
                name = value;
            lblIngName.Text = name;
            }
        }
        public bool isChecked
        {
            get { return cheacked; }
            set { cheacked = value; 
            lblIngName.Checked = value;
            }
        }
        public btnOptionalIngredient()
        {
            InitializeComponent();
            this.lblIngName.Click += ToggleState;
            this.Click += ToggleState;
        }

        private void ToggleState(object sender, EventArgs e)
        {
            this.isChecked = !this.isChecked;

            if (btnClick != null)
                btnClick.Invoke();
        }



        
    }
}
