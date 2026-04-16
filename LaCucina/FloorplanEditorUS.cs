using CustomControls.RJControls;
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
    public partial class USFloorplanEditor : UserControl
    {
        int chaircount=2;
        public USFloorplanEditor()
        {
            InitializeComponent();
           

            HorizontalTableUserControl t = new HorizontalTableUserControl("01", 4, "occupied", true);
            t.Location = new Point(40, 20);
            pnlTables.Controls.Add(t);


            HorizontalTableUserControl ta = new HorizontalTableUserControl("05", 12, "vacant", true);

            ta.Location = new Point(500, 20);
            pnlTables.Controls.Add(ta);

            HorizontalTableUserControl tab = new HorizontalTableUserControl("05", 10, "occupied", true);

            tab.Location = new Point(140, 200);
            pnlTables.Controls.Add(tab);

            VerticalTableUserControl tabl = new VerticalTableUserControl("05", 8, "vacant",true);
            tabl.Location = new Point(30, 300);
            pnlTables.Controls.Add(tabl);

            HorizontalTableUserControl tab2 = new HorizontalTableUserControl("10", 4, "vacant", true);

            tab2.Location = new Point(500, 200);
            pnlTables.Controls.Add(tab2);

            VerticalTableUserControl tabl3 = new VerticalTableUserControl("05", 6, "vacant", true);
            tabl3.Location = new Point(400, 350);
            pnlTables.Controls.Add(tabl3);

            VerticalTableUserControl tabl4 = new VerticalTableUserControl("07", 6, "empty", true);
            tabl4.Location = new Point(1000, 350);
            pnlTables.Controls.Add(tabl4);

            HorizontalTableUserControl tab5 = new HorizontalTableUserControl("10", 4, "empty",true);

            tab5.Location = new Point(650, 200);
            pnlTables.Controls.Add(tab5);

            CircularTableUserControl tab6 = new CircularTableUserControl("16", 2, "occupied", true);
            tab6.Location = new Point(600, 400);
            pnlTables.Controls.Add(tab6);

            CircularTableUserControl tab7 = new CircularTableUserControl("04", 4, "vacant", true);
            tab7.Location = new Point(800, 100);
            pnlTables.Controls.Add(tab7);

            CircularTableUserControl tab8 = new CircularTableUserControl("02", 4, "empty", true);
            tab8.Location = new Point(800, 300);
            pnlTables.Controls.Add(tab8);

            int l = (rjPanel3.Size.Width / 2 - (rjPanel1.Width / 2));
            rjPanel1.Location = new Point(l);

           
        }

        private void rjPanel4_Paint(object sender, PaintEventArgs e)
        {
            int l = (rjPanel3.Size.Width / 2 - (rjPanel1.Width / 2));
            rjPanel1.Location = new Point(l);
        }

       

        private void btnNewTable_Click(object sender, EventArgs e)
        {pnlNewTaple.Visible = !pnlNewTaple.Visible;
            pnlNewTaple.BringToFront();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FloorplanEditorUS_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlTables.Controls)
            {
                try
                {
                    // سيحاول الوصول للخاصية مهما كان نوع الكلاس
                    dynamic table = ctrl;
                    table.isInEditingMode = true;
                    ctrl.Invalidate();
                    ctrl.Update();

                }
                catch
                {
                    // إذا لم تكن الخاصية موجودة في الأداة (مثل Label) سيتجاهلها
                }
            }
            pnlTables.Invalidate();
        }

        
        private void pnlTables_Click(object sender, EventArgs e)
        {
            foreach (RJgradiantPanal item in UCtable.lastSelectedTable.Controls)
            {

                item.BorderSize = 0;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbtnCircular.Checked)
            {
                CircularTableUserControl t = new CircularTableUserControl(txtTablenum.Texts, chaircount, "vacant", true);
                t.Location = new Point(800, 100);
                pnlTables.Controls.Add(t);

            }
            else if (rbtnHorizantal.Checked)
            {
                HorizontalTableUserControl t = new HorizontalTableUserControl(txtTablenum.Texts, chaircount, "occupied", true);
                t.Location = new Point(100, 300);
                pnlTables.Controls.Add(t);
            }
            else if (rbtnVertical.Checked)
            {
                VerticalTableUserControl t = new VerticalTableUserControl(txtTablenum.Texts, chaircount, "empty", true);
                t.Location = new Point(1000, 350);
                pnlTables.Controls.Add(t);

            }
            
        }

        private void rbtnCircular_CheckedChanged(object sender, EventArgs e)
        {
           
                rbtn6.Visible = !rbtnCircular.Checked;
                rbtn8.Visible = !rbtnCircular.Checked;
                rbtn10.Visible = !rbtnCircular.Checked;
                rbtn12.Visible =! rbtnCircular.Checked;

            
            
        }
    }
}
