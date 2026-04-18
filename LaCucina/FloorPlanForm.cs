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
    public partial class FloorPlanForm : Form
    {
        Form form;
        public FloorPlanForm(Form form)
        {this.form = form;
            InitializeComponent();
        }
        Form loginForm;
        public FloorPlanForm()
        {
            InitializeComponent();
        }
        public FloorPlanForm(Form loginForm)
        {
            this.loginForm = loginForm;
            
            InitializeComponent();
        }

        private void FloorPlanForm_Load(object sender, EventArgs e)
        {

            HorizontalTableUserControl t = new HorizontalTableUserControl("01", 4, "occupied", false);
            t.Location = new Point(40, 40);
            pnlTables.Controls.Add(t);


            HorizontalTableUserControl ta = new HorizontalTableUserControl("05", 12, "vacant", false);

            ta.Location = new Point(500, 40);
            pnlTables.Controls.Add(ta);

            HorizontalTableUserControl tab = new HorizontalTableUserControl("05", 10, "occupied", false);

            tab.Location = new Point(140, 200);
            pnlTables.Controls.Add(tab);

            VerticalTableUserControl tabl = new VerticalTableUserControl("05", 8, "vacant", false);
            tabl.Location = new Point(30, 300);
            pnlTables.Controls.Add(tabl);

            HorizontalTableUserControl tab2 = new HorizontalTableUserControl("10", 4, "vacant", false);

            tab2.Location = new Point(500, 200);
            pnlTables.Controls.Add(tab2);

            VerticalTableUserControl tabl3 = new VerticalTableUserControl("05", 6, "vacant", false);
            tabl3.Location = new Point(400, 350);
            pnlTables.Controls.Add(tabl3);

            VerticalTableUserControl tabl4 = new VerticalTableUserControl("07", 6, "empty", false);
            tabl4.Location = new Point(1000, 350);
            pnlTables.Controls.Add(tabl4);

            HorizontalTableUserControl tab5 = new HorizontalTableUserControl("10", 4, "empty", false);

            tab5.Location = new Point(650, 200);
            pnlTables.Controls.Add(tab5);

            CircularTableUserControl tab6 = new CircularTableUserControl("16", 2, "occupied", false);
            tab6.Location = new Point(600, 400);
            pnlTables.Controls.Add(tab6);

            CircularTableUserControl tab7 = new CircularTableUserControl("04", 4, "vacant", false);
            tab7.Location = new Point(800, 100);
            pnlTables.Controls.Add(tab7);

            CircularTableUserControl tab8 = new CircularTableUserControl("02", 4, "empty", false);
            tab8.Location = new Point(800, 300);
            pnlTables.Controls.Add(tab8);

            int l = (rjPanel3.Size.Width / 2 - (rjPanel4.Width / 2));
            rjPanel4.Location = new Point(l);


        }

        private void pnlTables_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Test t= new Test();
            t.ShowDialog();
            this.Close();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            loginForm.Show();
            this.Close();
        }
    }
}
