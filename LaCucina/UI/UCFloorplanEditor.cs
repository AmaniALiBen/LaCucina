using CustomControls.RJControls;
using LaCucina.DataLink;
using LaCucina.Models;
using LaCucina.Services;
using LaCucina.UI;
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
    public partial class USFloorplanEditor :UserControl
    {

        private FloorPlanService service = new FloorPlanService();
        public USFloorplanEditor()
        {
            InitializeComponent();
           
          
            fillSpacesPanel();


        }
        private void SelectDefaultSpace()
        {
            hfpnlSpaces.Controls.OfType<Space>().First().PerformClick();

        }
        public void fillSpacesPanel()
        {
            hfpnlSpaces.Controls.Clear();

            var spaces = service.GetSpaces();

            foreach (var space in spaces)
            {
                Space s = new Space(space.id, space.name);
                hfpnlSpaces.Controls.Add(s);
            }

            SelectDefaultSpace();
        }
        public void fillTablePanel(bool isEditing)
        {
            clearTablePanel();
            clearSelection();

            int spaceId = Space.lastSelectedSpace.id;

            var tables = service.GetTablesBySpace(spaceId);

            foreach (var table in tables)
            {
                addTableToPanel(table, isEditing);
            }
        }
        public void addTableToPanel(Table table, bool isEditing)
        {
            UCtable t = null;

            if (table.tableFormat == TableFormat.circular)
            {
                t = new CircularTableUserControl(table.id, table.tableNum, table.chairCount, table.tableStatus, isEditing);

            }
            if (table.tableFormat == TableFormat.vertical)
            {
                t = new VerticalTableUserControl(table.id, table.tableNum, table.chairCount, table.tableStatus, isEditing);

            }
            if (table.tableFormat == TableFormat.horizontal)
            {
                t = new HorizontalTableUserControl(table.id, table.tableNum, table.chairCount, table.tableStatus, isEditing);


            }
            if (t != null)
            {
                t.Location = table.location;
                pnlTables.Controls.Add(t);
                t.BringToFront();
            }
        }

        public void clearTablePanel()
        {
            foreach (var table in pnlTables.Controls.OfType<UCtable>().ToList())
            {
                pnlTables.Controls.Remove(table);
                table.Dispose();

            }
        }
        
        
        public TableFormat getSelectedFormat() 
        {

            foreach (RadioButton b in pnlFormat.Controls.OfType<RadioButton>())
            {

                if (b.Checked == true)
                { 
                    return (TableFormat)Enum.Parse(typeof(TableFormat), b.Tag.ToString()); 
                }

            }
            return TableFormat.circular;
        }
        public int getSelectedChairCount() 
        {
            foreach (RadioButton b in pnlChairCount.Controls.OfType<RadioButton>())
            {

                if (b.Checked == true)
                {
                    return int.Parse( b.Tag.ToString());
                }

            }
            return 2;

        }
      

        private void rjPanel4_Paint(object sender, PaintEventArgs e)
        {
            int l = (rjPanel3.Size.Width / 2 - (pnlSpases.Width / 2));
            pnlSpases.Location = new Point(l);
        }

       

        private void btnNewTable_Click(object sender, EventArgs e)
        {pnlNewTable.Visible = !pnlNewTable.Visible;
            pnlNewTable.BringToFront();
            

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
            pnlNewTable.Visible=false;
            clearSelection();
        }
        private void clearSelection() 
        {
            if (UCtable.lastSelectedTable != null)
            {
                foreach (RJgradiantPanal item in UCtable.lastSelectedTable.Controls)
                {

                    item.BorderSize = 0;

                }
                UCtable.lastSelectedTable = null;
                pnlTableButtons.Visible = false;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Table t = new Table(
                0,
                txtTablenum.Texts,
                getSelectedChairCount(),
                getSelectedFormat(),
                new Point(pnlTables.Width / 2, pnlTables.Height / 2),
                Space.lastSelectedSpace.id,
                TableStatus.vacant
            );
            string error = service.ValidateTable(t, false);

            if (error != null)
            {
                lblError.Text = error;
                lblError.Visible = true;
                return;
            }

            service.AddTable(t);

            fillTablePanel(true);

            lblError.Visible = false;
            resetpnlNewTable();
        }
        
        private void rbtnCircular_CheckedChanged(object sender, EventArgs e)
        {
           
                rbtn6.Visible = !rbtnCircular.Checked;
                rbtn8.Visible = !rbtnCircular.Checked;
                rbtn10.Visible = !rbtnCircular.Checked;
                rbtn12.Visible =! rbtnCircular.Checked;

            
            
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = UCtable.lastSelectedTable.id;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this table?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
                return;

            service.DeleteTable(id);

            fillTablePanel(true);

            pnlTableButtons.Visible = false;
        }
        private void btnEditTable_Click(object sender, EventArgs e)
        {
            pnlNewTable.Visible = true;
            btnEdit.Visible = true;

            int id = UCtable.lastSelectedTable.id;

            Table t = service.GetTableById(id);

            foreach (RadioButton btn in pnlFormat.Controls.OfType<RadioButton>())
            {
                if ((TableFormat)Enum.Parse(typeof(TableFormat), btn.Tag.ToString()) == t.tableFormat)
                    btn.Checked = true;
            }

            foreach (RadioButton btn in pnlChairCount.Controls.OfType<RadioButton>())
            {
                if (btn.Tag.ToString() == t.chairCount.ToString())
                    btn.Checked = true;
            }

            txtTablenum.Texts = t.tableNum;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = UCtable.lastSelectedTable.id;

            

            Table t = new Table(
                id,
                txtTablenum.Texts,
                getSelectedChairCount(),
                getSelectedFormat(),
                UCtable.lastSelectedTable.Location,
                Space.lastSelectedSpace.id,
                TableStatus.vacant
            );

            string error = service.ValidateTable(t, true);

            if (error != null)
            {
                lblError.Text = error;
                lblError.Visible = true;
                return;
            }

            service.UpdateTable(t);

            fillTablePanel(true);

            btnEdit.Visible = false;
            pnlNewTable.Visible = false;
            lblError.Visible = false;
            resetpnlNewTable();
        }

        private void resetpnlNewTable() 
        {
            rbtnHorizantal.Checked = true;
            rbtn2.Checked = true;
            txtTablenum.Texts = "";
        }

        private void hfpnlSpaces_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNewTable_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void txtTablenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)Keys.Enter)
            {
                if (btnAdd.Visible) { btnAdd.PerformClick(); }
                else { btnEdit.PerformClick(); }
                e.Handled = true;
               
            }

        }
    }


}
