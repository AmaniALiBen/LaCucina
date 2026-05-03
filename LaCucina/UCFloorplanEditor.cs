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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaCucina
{ 
    public partial class USFloorplanEditor : UserControl
    {
        
        public USFloorplanEditor()
        {
            InitializeComponent();
           
            fillPanel(false);
            

            

           
        }
        public void fillPanel(bool isEditing) {
            foreach (var item in DataBase.tables)
            {

                addTableToPanel(item.Value, isEditing);

            }
        }
       public void addTableToPanel(Table table, bool isEditing)
        {
            UCtable t = null;

            if (table.tableFormat == TableFormat.circular)
            {
                t = new CircularTableUserControl(table.tableNum, table.chairCount, table.tableStatus, isEditing);

            }
            if (table.tableFormat == TableFormat.vertical)
            {
                t = new VerticalTableUserControl(table.tableNum, table.chairCount, table.tableStatus, isEditing);

            }
            if (table.tableFormat == TableFormat.horizontal)
            {
                t = new HorizontalTableUserControl(table.tableNum, table.chairCount, table.tableStatus, isEditing);


            }
            if (t != null)
            {
                t.Location = table.location;
                pnlTables.Controls.Add(t);
            }
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
                    dynamic table = ctrl;
                    table.isInEditingMode = true;
                    ctrl.Invalidate();
                    ctrl.Update();

                }
                catch
                {
                }
            }
            pnlTables.Invalidate();
        }

        
        private void pnlTables_Click(object sender, EventArgs e)
        {
            if (UCtable.lastSelectedTable != null)
            {
                foreach (RJgradiantPanal item in UCtable.lastSelectedTable.Controls)
                {

                    item.BorderSize = 0;

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (rbtnCircular.Checked)
            //{
            //    CircularTableUserControl t = new CircularTableUserControl(txtTablenum.Texts, chaircount, "vacant", true);
            //    t.Location = new Point(800, 100);
            //    pnlTables.Controls.Add(t);

            //}
            //else if (rbtnHorizantal.Checked)
            //{
            //    HorizontalTableUserControl t = new HorizontalTableUserControl(txtTablenum.Texts, chaircount, "occupied", true);
            //    t.Location = new Point(100, 300);
            //    pnlTables.Controls.Add(t);
            //}
            //else if (rbtnVertical.Checked)
            //{
            //    VerticalTableUserControl t = new VerticalTableUserControl(txtTablenum.Texts, chaircount, "empty", true);
            //    t.Location = new Point(1000, 350);
            //    pnlTables.Controls.Add(t);

            //}

            
        }

        private void rbtnCircular_CheckedChanged(object sender, EventArgs e)
        {
           
                rbtn6.Visible = !rbtnCircular.Checked;
                rbtn8.Visible = !rbtnCircular.Checked;
                rbtn10.Visible = !rbtnCircular.Checked;
                rbtn12.Visible =! rbtnCircular.Checked;

            
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            ManageSpacesForm form = new ManageSpacesForm();
            form.ShowDialog();
        }
    }
}
