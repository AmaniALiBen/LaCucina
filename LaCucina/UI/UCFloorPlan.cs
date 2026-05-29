using CustomControls.RJControls;
using LaCucina;
using LaCucina.Services;
using LaCucina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace LaCucina.UI
{
    public partial class UCFloorPlan : UserControl
    {
        private Timer readyItemsCheckTimer;

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
            InitializeReadyItemsTimer();
        }

        private void pnlTables_Paint(object sender, PaintEventArgs e)
        {
            int l = (rjPanel3.Size.Width / 2 - (pnlSpases.Width / 2));
            pnlSpases.Location = new Point(l);
        }

        private void InitializeReadyItemsTimer()
        {
            readyItemsCheckTimer = new Timer();
            readyItemsCheckTimer.Interval = 20000; // 60 seconds
            readyItemsCheckTimer.Tick += ReadyItemsCheckTimer_Tick;
            readyItemsCheckTimer.Start();
        }

        private void ReadyItemsCheckTimer_Tick(object sender, EventArgs e)
        {
            // Run in background to not block UI
            Task.Run(() =>
            {
                try
                {
                    var readyTableIds = service.GetTablesWithReadyItems();

                    // Update UI on the main thread
                    this.Invoke(new Action(() =>
                    {
                        UpdateTableNotifications(readyTableIds);
                    }));
                }
                catch (Exception ex)
                {
                    // Log error silently
                    System.Diagnostics.Debug.WriteLine($"Error checking ready items: {ex.Message}");
                }
            });
        }

        private void UpdateTableNotifications(List<int> readyTableIds)
        {
            // Loop through all table controls
            foreach (var tableControl in pnlTables.Controls.OfType<UCtable>())
            {
                if (readyTableIds.Contains(tableControl.id))
                {
                    tableControl.ShowNotification();
                }
                else
                {
                    tableControl.HideNotification();
                }
            }
        }


        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (readyItemsCheckTimer != null)
            {
                readyItemsCheckTimer.Stop();
                readyItemsCheckTimer.Dispose();
            }
            base.OnHandleDestroyed(e);
        }
    }
}
