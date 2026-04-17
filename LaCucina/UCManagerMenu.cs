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
    public partial class UCManagerMenu : UserControl
    {
        public UCManagerMenu()
        {
            InitializeComponent();
        }

        private void btnBurgers_Click(object sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            UCCategoryItems cat = new UCCategoryItems();
            cat.Dock = DockStyle.Fill;
            pnlItems.Controls.Add(cat);
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            UCCategoryItems cat = new UCCategoryItems();
            cat.Dock = DockStyle.Fill;
            pnlItems.Controls.Add(cat);
        }

        private void btnSalads_Click(object sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            UCCategoryItems cat = new UCCategoryItems();
            cat.Dock = DockStyle.Fill;
            pnlItems.Controls.Add(cat);
        }

        private void btnSoups_Click(object sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            UCCategoryItems cat = new UCCategoryItems();
            cat.Dock = DockStyle.Fill;
            pnlItems.Controls.Add(cat);
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            UCCategoryItems cat = new UCCategoryItems();
            cat.Dock = DockStyle.Fill;
            pnlItems.Controls.Add(cat);
        }

        private void btnSideDishes_Click(object sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            UCCategoryItems cat = new UCCategoryItems();
            cat.Dock = DockStyle.Fill;
            pnlItems.Controls.Add(cat);
        }

        private void btnGrills_Click(object sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            UCCategoryItems cat = new UCCategoryItems();
            cat.Dock = DockStyle.Fill;
            pnlItems.Controls.Add(cat);
        }

        private void btnSandwiches_Click(object sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            UCCategoryItems cat = new UCCategoryItems();
            cat.Dock = DockStyle.Fill;
            pnlItems.Controls.Add(cat);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            UCCategoryItems cat = new UCCategoryItems();
            cat.Dock = DockStyle.Fill;
            pnlItems.Controls.Add(cat);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            EditCategory editCategory = new EditCategory();
            editCategory.ShowDialog();
            if(editCategory.DialogResult==DialogResult.OK|| editCategory.DialogResult ==DialogResult.Cancel)
                editCategory.Close();
        }
    }
}
