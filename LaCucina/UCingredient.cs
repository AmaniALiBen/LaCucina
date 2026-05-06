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
    public partial class UCIngredient : UserControl
    {
        public int id;
        public string name;
        public static UCIngredient lastSelectedIngredient=null;
        public UCIngredient(int id, string name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            lblIngredient.Text = name;
        }

        private void pnlIngredient_Click(object sender, EventArgs e)
        {

            if (lastSelectedIngredient != null)
            {
                lastSelectedIngredient.pnlIngredient.BackColor = Color.FromArgb(23, 23, 23);
            }

            lastSelectedIngredient = this;
            lastSelectedIngredient.pnlIngredient.BackColor = Color.FromArgb(35, 35, 35);



        }
    }
}
