using LaCucina.Models;
using LaCucina.Services;
using LaCucina.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class KDS : Form, IMessageFilter
    {
        private readonly KdsService _kdsService = new KdsService();
        private System.Windows.Forms.Timer _refreshTimer;
        private Form _form;

        private const int WM_MOUSEWHEEL = 0x020A;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        // ════════════════════════════════════════════════════════════════
        //  Constructor
        // ════════════════════════════════════════════════════════════════

        public KDS(Form form)
        {
            _form = form;
            InitializeComponent();

            Application.AddMessageFilter(this);

            LoadKds();
            LoadKitchenLoad();

            _refreshTimer = new System.Windows.Forms.Timer();
            _refreshTimer.Interval = 60000;
            _refreshTimer.Tick += (s, e) =>
            {
                LoadKds();
                LoadKitchenLoad();
            };
            _refreshTimer.Start();
        }

        // ════════════════════════════════════════════════════════════════
        //  Mouse wheel filter
        // ════════════════════════════════════════════════════════════════

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_MOUSEWHEEL)
            {
                Control targetControl = Control.FromHandle(m.HWnd);
                if (targetControl != null && pnlBatches != null && IsChildOf(targetControl, pnlBatches))
                {
                    SendMessage(pnlBatches.Handle, m.Msg, m.WParam, m.LParam);
                    return true;
                }
            }
            return false;
        }

        private bool IsChildOf(Control child, Control parent)
        {
            while (child != null)
            {
                if (child == parent) return true;
                child = child.Parent;
            }
            return false;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Application.RemoveMessageFilter(this);
            base.OnFormClosed(e);
        }

        // ════════════════════════════════════════════════════════════════
        //  Load batches — only adds new ones, leaves existing cards alone
        // ════════════════════════════════════════════════════════════════

        private void LoadKds()
        {
            var batches = _kdsService.GetActiveBatches();

            // Collect batch IDs already on screen
            var existingIds = new HashSet<int>();
            foreach (Control c in pnlBatches.Controls)
                if (c is UCBatchCard card)
                    existingIds.Add(card.BatchId);

            pnlBatches.SuspendLayout();

            int maxCardHeight = Screen.GetWorkingArea(this).Height - 100;

            foreach (var batch in batches)
            {
                if (existingIds.Contains(batch.BatchId)) continue; // already on screen

                var chunks = _kdsService.SplitBatchIntoChunks(batch, maxCardHeight);
                int totalChunks = chunks.Count;

                for (int i = 0; i < totalChunks; i++)
                {
                    var chunkBatch = new BatchCardDto
                    {
                        BatchId = batch.BatchId,
                        TableNumber = batch.TableNumber,
                        OrderId = batch.OrderId,
                        SentAt = batch.SentAt,
                        Items = chunks[i]
                    };

                    var card = new UCBatchCard();
                    card.ItemOrBatchChanged += (s, e) => LoadKitchenLoad();
                    card.LoadBatch(chunkBatch, isFirstCard: i == 0, isLastCard: i == totalChunks - 1);
                    pnlBatches.Controls.Add(card);
                }
            }

            pnlBatches.ResumeLayout();
        }

        // ════════════════════════════════════════════════════════════════
        //  Kitchen load side panel
        // ════════════════════════════════════════════════════════════════

        private void LoadKitchenLoad()
        {
            pnlItemsList.Controls.Clear();

            var load = _kdsService.GetKitchenLoad();
            int total = _kdsService.GetTotalItemsInQueue();

            lblItemsInQueue.Text = $"    Items in Queue ×{total}";

            foreach (var item in load)
                pnlItemsList.Controls.Add(MakeLoadItemLabel(item));
        }

        private Label MakeLoadItemLabel(KitchenLoadItemDto item)
        {
            var lbl = new Label
            {
                AutoSize = true,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Regular),
                ForeColor = Color.WhiteSmoke,
                Padding = new Padding(8, 10, 0, 7),
                Margin = new Padding(4, 0, 4, 0),
                Text = $"{item.MenuItemName} ×{item.TotalQuantity}",
                Tag = item.MenuItemId,
                Cursor = Cursors.Hand
            };

            lbl.MouseEnter += (s, e) => lbl.ForeColor = Color.FromArgb(239, 128, 16);
            lbl.MouseLeave += (s, e) => lbl.ForeColor = Color.WhiteSmoke;
            lbl.Click += OnKitchenLoadItemClick;

            return lbl;
        }

        private void OnKitchenLoadItemClick(object sender, EventArgs e)
        {
            int menuItemId = (int)((Label)sender).Tag;
            // TODO: highlight batch cards that contain this menu item
        }

        // ════════════════════════════════════════════════════════════════
        //  Button handlers
        // ════════════════════════════════════════════════════════════════

        private void rjButton1_Click(object sender, EventArgs e)
        {
            EditItemsForm editItemsForm = new EditItemsForm(this);
            editItemsForm.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _form.Show();
            this.Close();
        }

        private void KDS_Load(object sender, EventArgs e)
        {
            InvoicesLoad();
        }

        public void InvoicesLoad() { }

        private void rjPanel2_Paint(object sender, PaintEventArgs e) { }
    }
}