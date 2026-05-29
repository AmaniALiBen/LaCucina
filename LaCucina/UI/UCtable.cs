//using CustomControls.RJControls;
//using LaCucina;
//using LaCucina.Models;
//using LaCucina.Services;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web.UI.Design;
//using System.Windows.Forms;

//namespace LaCucina
//{

//    public partial class UCtable : UserControl
//    {
//        FloorPlanService service = new FloorPlanService();

//        public int id;
//        public string tableNum;
//        public int chairCount;
//        public TableStatus tableStatus;
//        public bool isInEditingMode;
//        int offsetx, offsety;

//        private bool isDragging = false;
//        private Point dragCursorPoint;
//        private Point dragFormPoint;
//        public Panel pnlTableButtons;

//        // 🔔 ADDED: Notification icon fields
//        private Label notificationIcon;
//        private Timer notificationPulseTimer;
//        private bool isNotificationVisible = false;

//        public static UCtable lastSelectedTable = null;

//        public virtual Label TargetlblTableNum { get; }
//        public virtual Label TargetlblTableStatus { get; }

//        public UCtable()
//        {
//            InitializeComponent();
//            InitializeNotificationIcon(); // 🔔 ADDED
//        }

//        public UCtable(int id, string tableNum, int chairCount, TableStatus tableStatus, bool isInEditingMode)
//        {
//            InitializeComponent();
//            this.id = id;
//            this.tableNum = tableNum;
//            this.chairCount = chairCount;
//            this.tableStatus = tableStatus;
//            this.isInEditingMode = isInEditingMode;
//            InitializeNotificationIcon(); // 🔔 ADDED
//        }

//        public virtual void BuildTable()
//        {
//            TargetlblTableNum.Text = tableNum;
//            if (!isInEditingMode)
//            {
//                TargetlblTableStatus.Text = tableStatus.ToString();
//                adjustStatusColor();
//                foreach (Control ctrl in this.Controls)
//                {
//                    ctrl.Click += (s, e) =>
//                    {
//                        POSForm f = new POSForm(false, tableNum, id);


//                        f.Show(this);

//                    };
//                    foreach (Control sub in ctrl.Controls)
//                    {
//                        sub.Click += (s, e) =>
//                        {
//                            POSForm f = new POSForm(false, tableNum, id);
//                            f.Show(this);
//                        };
//                    }
//                }
//            }
//            if (isInEditingMode)
//            {
//                foreach (Control ctrl in this.Controls)
//                {
//                    ctrl.Click += (s, e) => SelectTable();
//                    ctrl.MouseDown += HandleMouseDown;
//                    ctrl.MouseMove += HandleMouseMove;
//                    ctrl.MouseUp += HandleMouseUp;

//                    foreach (Control sub in ctrl.Controls)
//                    {
//                        sub.Click += (s, e) => SelectTable();
//                        sub.MouseDown += HandleMouseDown;
//                        sub.MouseMove += HandleMouseMove;
//                        sub.MouseUp += HandleMouseUp;
//                    }
//                }
//            }
//        }

//        public void adjustStatusColor()
//        {
//            if (tableStatus == TableStatus.occupied)
//            {
//                foreach ( Control control  in this.Controls)
//                    if (control is RJgradiantPanal item)
//                    { 
//                    item.GradientBottomColor = Color.FromArgb(211, 84, 0); 
//                    item.GradientTopColor = Color.FromArgb(239, 128, 16);

//                    }
//            }
//            else if(tableStatus == TableStatus.served)
//            {
//                foreach (Control control in this.Controls)
//                    if (control is RJgradiantPanal item)
//                 {
//                    item.GradientBottomColor = Color.FromArgb(39, 174, 96); 
//                    item.GradientTopColor = Color.FromArgb(46, 204, 113);
//                  }
//            }
//            else if (tableStatus == TableStatus.vacant)
//            {
//                foreach (Control control in this.Controls)

//                    if (control is RJgradiantPanal item)
//                    {
//                    item.GradientBottomColor = Color.FromArgb(38, 38, 38);
//                    item.GradientTopColor = Color.FromArgb(58, 58, 58);
//                    }
//            }

//        }

//        public void SelectTable()
//        {
//            pnlTableButtons = this.Parent.Controls.Find("pnlTableButtons", true).FirstOrDefault() as Panel;

//            if (isInEditingMode)
//            {
//                if (lastSelectedTable != null && lastSelectedTable != this)
//                {
//                    foreach (RJgradiantPanal item in lastSelectedTable.Controls)
//                    {
//                        item.BorderSize = 0;
//                    }
//                }
//                foreach (RJgradiantPanal item in this.Controls)
//                {
//                    item.BorderSize = 1;
//                }
//            }
//            else
//            {
//                POSForm test = new POSForm(this.FindForm(), false);
//                test.Show();
//            }
//            lastSelectedTable = this;
//        }

//        private void HandleMouseDown(object sender, MouseEventArgs e)
//        {
//            if (isInEditingMode && e.Button == MouseButtons.Left)
//            {
//                SelectTable();
//                pnlTableButtons.Location = new Point(this.Location.X + this.Width - pnlTableButtons.Width, this.Location.Y - pnlTableButtons.Height - 10);
//                pnlTableButtons.Visible = true;

//                isDragging = true;
//                offsetx = Cursor.Position.X - this.Location.X;
//                offsety = Cursor.Position.Y - this.Location.Y;
//                this.Cursor = Cursors.SizeAll;
//                this.BringToFront();
//            }
//        }

//        private void HandleMouseMove(object sender, MouseEventArgs e)
//        {
//            if (isDragging)
//            {
//                pnlTableButtons.Visible = false;

//                int newX = Cursor.Position.X - offsetx;
//                int newY = Cursor.Position.Y - offsety;
//                int minX = 0;
//                int minY = 0;
//                int maxX = this.Parent.Width - this.Width;
//                int maxY = this.Parent.Height - this.Height;
//                newX = Math.Max(minX, Math.Min(newX, maxX));
//                newY = Math.Max(minY, Math.Min(newY, maxY));

//                this.Location = new Point(newX, newY);
//            }
//        }

//        private void HandleMouseUp(object sender, MouseEventArgs e)
//        {
//            pnlTableButtons.Location = new Point(this.Location.X + this.Width - pnlTableButtons.Width, this.Location.Y - pnlTableButtons.Height - 10);
//            pnlTableButtons.Visible = true;
//            isDragging = false;
//            this.Cursor = Cursors.Default;
//            service.editLocation(this.id, this.Location);
//        }

//        private void UCtable_Load(object sender, EventArgs e)
//        {
//        }

//        // 🔔 ADDED: Notification methods below

//        private void InitializeNotificationIcon()
//        {
//            notificationIcon = new Label();
//            notificationIcon.Text = "🔔";
//            notificationIcon.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
//            notificationIcon.BackColor = Color.Transparent;
//            notificationIcon.ForeColor = Color.Yellow;
//            notificationIcon.Size = new Size(40, 40);
//            notificationIcon.TextAlign = ContentAlignment.MiddleCenter;
//            notificationIcon.Cursor = Cursors.Hand;
//            notificationIcon.Visible = false;
//            notificationIcon.Location = new Point(this.Width - notificationIcon.Width - 5, 5);
//            notificationIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;

//            // ✅ هذا يمنع الجرس من التأثير على أي شيء
//            notificationIcon.TabStop = false;
//            notificationIcon.MouseDown += (s, e) => { ((Label)s).Capture = false; };

//            notificationIcon.Click += NotificationIcon_Click;

//            this.Controls.Add(notificationIcon);
//            notificationIcon.BringToFront();

//            notificationPulseTimer = new Timer();
//            notificationPulseTimer.Interval = 500;
//            notificationPulseTimer.Tick += (s, e) =>
//            {
//                if (notificationIcon.Visible && isNotificationVisible)
//                {
//                    if (notificationIcon.Font.Size == 16)
//                        notificationIcon.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
//                    else
//                        notificationIcon.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
//                }
//            };
//        }
//        private void NotificationIcon_Click(object sender, EventArgs e)
//        {
//            DialogResult result = MessageBox.Show(
//                "Mark all ready items as served?",
//                "Confirm",
//                MessageBoxButtons.YesNo,
//                MessageBoxIcon.Question);

//            if (result == DialogResult.Yes)
//            {
//                bool success = service.MarkReadyItemsAsDelivered(this.id);

//                if (success)
//                {
//                    HideNotification();
//                    RefreshTableStatus();
//                }
//                else
//                {
//                    MessageBox.Show("Failed to mark items as served.", "Error",
//                        MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }

//        public void ShowNotification()
//        {
//            if (notificationIcon == null)
//                InitializeNotificationIcon();

//            isNotificationVisible = true;
//            notificationIcon.Visible = true;
//            notificationPulseTimer.Start();
//            notificationIcon.BringToFront();
//        }

//        public void HideNotification()
//        {
//            if (notificationIcon != null)
//            {
//                isNotificationVisible = false;
//                notificationIcon.Visible = false;
//                notificationPulseTimer.Stop();
//                notificationIcon.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
//            }
//        }

//        public void RefreshTableStatus()
//        {
//            var updatedTable = service.GetTableById(this.id);
//            if (updatedTable != null)
//            {
//                this.tableStatus = updatedTable.tableStatus;
//                if (TargetlblTableStatus != null)
//                {
//                    TargetlblTableStatus.Text = this.tableStatus.ToString();
//                }
//                adjustStatusColor();
//            }
//        }
//    }
//}

using CustomControls.RJControls;
using LaCucina.Models;
using LaCucina.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UCtable : UserControl
    {
        FloorPlanService service = new FloorPlanService();

        public int id;
        public string tableNum;
        public int chairCount;
        public TableStatus tableStatus;
        public bool isInEditingMode;
        int offsetx, offsety;

        private bool isDragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Panel pnlTableButtons;

        // ── Notification icon ────────────────────────────────────────────
        

        public static UCtable lastSelectedTable = null;

        public virtual Label TargetlblTableNum { get; }
        public virtual Label TargetlblTableStatus { get; }

        public UCtable() { }

        public UCtable(int id, string tableNum, int chairCount, TableStatus tableStatus, bool isInEditingMode)
        {
            InitializeComponent();
            this.id = id;
            this.tableNum = tableNum;
            this.chairCount = chairCount;
            this.tableStatus = tableStatus;
            this.isInEditingMode = isInEditingMode;
        }

        public virtual void BuildTable()
        {
            TargetlblTableNum.Text = tableNum;

            if (!isInEditingMode)
            {
                TargetlblTableStatus.Text = tableStatus.ToString();
                adjustStatusColor();

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl == btnNotification) continue;
                    ctrl.Click += (s, e) =>
                    {
                        POSForm f = new POSForm(false, tableNum, id);
                        f.FormClosed += (fs, fe) => RefreshStatus();
                        f.Show(this);

                    };
                    foreach (Control sub in ctrl.Controls)
                    {
                        sub.Click += (s, e) =>
                        {
                            POSForm f = new POSForm(false, tableNum, id);
                            f.FormClosed += (fs, fe) => RefreshStatus();
                            RefreshStatus();
                        };
                    }
                }
                btnNotification.Visible = false;
                btnNotification.BringToFront();
                if (!isInEditingMode)
                    btnNotification.Click += OnNotificationIconClick;
            }

            if (isInEditingMode)
            {
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Click += (s, e) => SelectTable();
                    ctrl.MouseDown += HandleMouseDown;
                    ctrl.MouseMove += HandleMouseMove;
                    ctrl.MouseUp += HandleMouseUp;

                    foreach (Control sub in ctrl.Controls)
                    {
                        sub.Click += (s, e) => SelectTable();
                        sub.MouseDown += HandleMouseDown;
                        sub.MouseMove += HandleMouseMove;
                        sub.MouseUp += HandleMouseUp;
                    }
                }
            }

            // Build notification icon last so it sits on top
            

        }
        // ════════════════════════════════════════════════════════════════
        //  Notification icon
        // ════════════════════════════════════════════════════════════════


        public void ShowNotification()
        {
            if (btnNotification == null) return;
            btnNotification.Location = new Point(this.Width - 30, 0);
            btnNotification.Visible = true;
            btnNotification.BringToFront();
        }

        public void HideNotification()
        {
            if (btnNotification == null) return;
            btnNotification.Visible = false;
        }
        public void RefreshStatus()
        {
            var updated = service.GetTableById(id);
            if (updated == null) return;

            tableStatus = updated.tableStatus;

            if (TargetlblTableStatus != null)
                TargetlblTableStatus.Text = tableStatus.ToString();

            adjustStatusColor();
            HideNotification(); // re-evaluated by timer anyway
        }
        private void OnNotificationIconClick(object sender, EventArgs e)
        {
            if (e is MouseEventArgs me)
            {
                // do nothing with it, just intercept
            }

            var result = MessageBox.Show(
                $"Table {tableNum} has items ready.\nMark all ready items as served?",
                "Items Ready",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            bool success = service.MarkReadyItemsAsDelivered(id);

            if (success)
            {
                HideNotification();

                // Refresh table status label if visible
                if (TargetlblTableStatus != null)
                {
                    var updatedTable = service.GetTableById(id);
                    if (updatedTable != null)
                    {
                        tableStatus = updatedTable.tableStatus;
                        TargetlblTableStatus.Text = tableStatus.ToString();
                        adjustStatusColor();
                    }
                }
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════════════
        //  Status colors
        // ════════════════════════════════════════════════════════════════

        public void adjustStatusColor()
        {
            foreach (RJgradiantPanal item in this.Controls.OfType<RJgradiantPanal>())
            {
                switch (tableStatus)
                {
                    case TableStatus.vacant:
                        item.GradientBottomColor = Color.FromArgb(38, 38, 38);
                        item.GradientTopColor = Color.FromArgb(58, 58, 58);
                        break;
                    case TableStatus.occupied:
                        item.GradientBottomColor = Color.FromArgb(211, 84, 0);
                        item.GradientTopColor = Color.FromArgb(239, 128, 16);
                        break;
                    case TableStatus.served:
                        item.GradientBottomColor = Color.FromArgb(39, 174, 96);
                        item.GradientTopColor = Color.FromArgb(46, 204, 113);
                        break;
                }
            }
        }
      

        // ════════════════════════════════════════════════════════════════
        //  Select / drag
        // ════════════════════════════════════════════════════════════════

        public void SelectTable()
        {
            pnlTableButtons = this.Parent.Controls.Find("pnlTableButtons", true).FirstOrDefault() as Panel;

            if (isInEditingMode)
            {
                if (lastSelectedTable != null && lastSelectedTable != this)
                {
                    foreach (RJgradiantPanal item in lastSelectedTable.Controls.OfType<RJgradiantPanal>())
                        item.BorderSize = 0;
                }
                foreach (RJgradiantPanal item in this.Controls.OfType<RJgradiantPanal>())
                    item.BorderSize = 1;
            }
            else
            {
                POSForm test = new POSForm(this.FindForm(), false);
                test.Show();
            }

            lastSelectedTable = this;
        }

        private void HandleMouseDown(object sender, MouseEventArgs e)
        {
            if (isInEditingMode && e.Button == MouseButtons.Left)
            {
                SelectTable();
                pnlTableButtons.Location = new Point(
                    this.Location.X + this.Width - pnlTableButtons.Width,
                    this.Location.Y - pnlTableButtons.Height - 10);
                pnlTableButtons.Visible = true;

                isDragging = true;
                offsetx = Cursor.Position.X - this.Location.X;
                offsety = Cursor.Position.Y - this.Location.Y;
                this.Cursor = Cursors.SizeAll;
                this.BringToFront();
            }
        }

        private void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                pnlTableButtons.Visible = false;

                int newX = Cursor.Position.X - offsetx;
                int newY = Cursor.Position.Y - offsety;
                int minX = 0, minY = 0;
                int maxX = this.Parent.Width - this.Width;
                int maxY = this.Parent.Height - this.Height;
                newX = Math.Max(minX, Math.Min(newX, maxX));
                newY = Math.Max(minY, Math.Min(newY, maxY));
                this.Location = new Point(newX, newY);
            }
        }

        private void HandleMouseUp(object sender, MouseEventArgs e)
        {
            pnlTableButtons.Location = new Point(
                this.Location.X + this.Width - pnlTableButtons.Width,
                this.Location.Y - pnlTableButtons.Height - 10);
            pnlTableButtons.Visible = true;
            isDragging = false;
            this.Cursor = Cursors.Default;
            service.editLocation(this.id, this.Location);
        }

        

        private void UCtable_Load(object sender, EventArgs e)
        {
            if (!isInEditingMode)
            {
                var readyTableIds = service.GetTablesWithReadyItems();
                if (readyTableIds.Contains(this.id))
                    ShowNotification();
            }
        }
    }
}