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
           
          
            fillSpacesPanel();


        }
        private void SelectDefaultSpace()
        {
            hfpnlSpaces.Controls.OfType<Space>().First().PerformClick();

        }
        public void fillSpacesPanel()
        {
            hfpnlSpaces.Controls.Clear();

            foreach (var item in DataBase.spaces)
            {

                Space s=new Space(item.Key,item.Value.name);
                hfpnlSpaces.Controls.Add(s);
                
            }
            SelectDefaultSpace();
        }
        public void fillTablePanel(bool isEditing) 
        {
            clearTablePanel();
            foreach (var table in DataBase.tables)
            {
               if(table.Value.spaceId==Space.lastSelectedSpace.id)
                addTableToPanel(table.Value, isEditing);

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
       public void addTableToPanel(Table table, bool isEditing)
        {
            UCtable t = null;

            if (table.tableFormat == TableFormat.circular)
            {
                t = new CircularTableUserControl(table.id,table.tableNum, table.chairCount, table.tableStatus, isEditing);

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

        private void rjPanel4_Paint(object sender, PaintEventArgs e)
        {
            int l = (rjPanel3.Size.Width / 2 - (pnlSpases.Width / 2));
            pnlSpases.Location = new Point(l);
        }

       

        private void btnNewTable_Click(object sender, EventArgs e)
        {pnlNewTable.Visible = !pnlNewTable.Visible;
            pnlNewTable.BringToFront();
            

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
                UCtable.lastSelectedTable = null;
                pnlTableButtons.Visible = false;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tableNumIsNotValid()) return;
            Table t = new Table(++DataBase.tableCounter, txtTablenum.Texts, getSelectedChairCount(), getSelectedFormat(),new Point(pnlTables.Width/2,pnlTables.Height/2), Space.lastSelectedSpace.id, TableStatus.vacant);
            DataBase.tables.Add(DataBase.tableCounter, t);
            addTableToPanel(t, true);
            lblError.Visible = false;
            resetpnlNewTable();
        }
        public bool tableNumIsNotValid()
        {
            bool valid = false;
            foreach (var item in DataBase.tables)
            {

                if (item.Value.tableNum == txtTablenum.Texts && item.Value.spaceId == Space.lastSelectedSpace.id)
                {
                    if (btnEdit.Visible && item.Key == UCtable.lastSelectedTable.id) return false;
                    lblError.Visible = true;
                    lblError.Text = " table number alredy Exists in this space";

                    valid = true;
                }
                
            }
            return valid;


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
            ManageSpacesForm form = new ManageSpacesForm(this);
            form.ShowDialog();
        }

       public void clearTablePanel() 
        {
            foreach(var table in pnlTables.Controls.OfType<UCtable>().ToList())
            {
                pnlTables.Controls.Remove(table);
                table.Dispose();
                pnlTableButtons.Visible = false;
            }
        }


        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = UCtable.lastSelectedTable.id;
            foreach (var table in pnlTables.Controls.OfType<UCtable>().ToList())
            {
                if (table.id == id)
                {
                    pnlTables.Controls.Remove(table);
                    table.Dispose();
                    pnlTableButtons.Visible = false;
                }
            }

           DataBase.tables.Remove(id);
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            
            pnlNewTable.Visible = true;
            btnEdit.Visible = true;
            int id=UCtable.lastSelectedTable.id;

            foreach (RadioButton btn in pnlFormat.Controls.OfType<RadioButton>())
            {
                if ((TableFormat)Enum.Parse(typeof(TableFormat), btn.Tag.ToString()) == DataBase.tables[id].tableFormat)
                {
                    btn.Checked = true;
                }
            }

            foreach (RadioButton btn in pnlChairCount.Controls.OfType<RadioButton>()) 
            {
                if (btn.Tag.ToString() == DataBase.tables[id].chairCount.ToString())
                {
                    btn.Checked = true;
                }
            }
            txtTablenum.Texts = DataBase.tables[id].tableNum;
           


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = UCtable.lastSelectedTable.id;
            if (tableNumIsNotValid()) { return; }
            DataBase.tables[id].tableFormat = getSelectedFormat();
            DataBase.tables[id].tableNum = txtTablenum.Texts;
            DataBase.tables[id].chairCount = getSelectedChairCount();
            foreach (var table in pnlTables.Controls.OfType<UCtable>().ToList())
            {
                if (table.id == id)
                {
                    pnlTables.Controls.Remove(table);
                    table.Dispose();
                    pnlTableButtons.Visible = false;
                }
            }
            addTableToPanel(DataBase.tables[id], true);
            btnEdit.Visible = false;
            pnlNewTable.Visible = false;

            resetpnlNewTable();
        }

        private void resetpnlNewTable() 
        {
            rbtnHorizantal.Checked = true;
            rbtn2.Checked = true;
            txtTablenum.Texts = "";
        }
    }


}
