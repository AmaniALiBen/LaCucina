using CustomControls.RJControls;
using LaCucina.Services;
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
    public partial class UCFloorPlan : UserControl
    {

        private FloorPlanService service = new FloorPlanService();
        public UCFloorPlan()
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

        private void UCFloorPlan_Load(object sender, EventArgs e)
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

        private void pnlTables_Paint(object sender, PaintEventArgs e)
        {
            int l = (rjPanel3.Size.Width / 2 - (pnlSpases.Width / 2));
            pnlSpases.Location = new Point(l);
        }
    }
}
