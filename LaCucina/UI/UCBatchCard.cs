using LaCucina.Models;
using LaCucina.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LaCucina.UI
{
    public partial class UCBatchCard : UserControl
    {
        private readonly KdsService _service = new KdsService();

        private int _batchId;
        private int _totalItems = 0;
        private int _doneItems = 0;
        private DateTime _sentAt;

        // Fired when any item is marked done or batch is completed
        // KDS listens to this to refresh the side panel
        public event EventHandler ItemOrBatchChanged;

        public int BatchId => _batchId; // exposed for LoadKds filtering

        public UCBatchCard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        // ════════════════════════════════════════════════════════════════
        //  Load
        // ════════════════════════════════════════════════════════════════

        public void LoadBatch(BatchCardDto batch, bool isFirstCard, bool isLastCard)
        {
            _batchId = batch.BatchId;

            if (isFirstCard)
            {
                lblTable.Text = "Table " + batch.TableNumber;
                lblOrderId.Text = "#" + batch.OrderId;
                _sentAt = batch.SentAt;
                WireHeaderDoubleClick(pnlHeader);
            }
            else
            {
                pnlHeader.Dispose();
            }

            foreach (var item in batch.Items)
            {
                var uc = new UCItemInBatch();
                uc.LoadItem(item);
                uc.ItemMarkedDone += OnItemMarkedDone;
                pnlBatchItems.Controls.Add(uc);

                if (item.ItemStatus == 0)
                    _totalItems++;
            }

            if (!isLastCard)
                pnlBatchItems.Controls.Add(new UCContinue());
        }

        // ════════════════════════════════════════════════════════════════
        //  Header double click → mark all items + batch ready immediately
        // ════════════════════════════════════════════════════════════════

        private void WireHeaderDoubleClick(Control control)
        {
            control.DoubleClick += OnHeaderDoubleClick;
            foreach (Control child in control.Controls)
                WireHeaderDoubleClick(child);
        }

        private void OnHeaderDoubleClick(object sender, EventArgs e)
        {
            _service.MarkAllItemsDone(_batchId);
            _service.MarkBatchReady(_batchId);
            ItemOrBatchChanged?.Invoke(this, EventArgs.Empty);
            RemoveAllChunksFromParent();
        }

        // ════════════════════════════════════════════════════════════════
        //  Individual item marked done
        // ════════════════════════════════════════════════════════════════

        private void OnItemMarkedDone(object sender, EventArgs e)
        {
            _doneItems++;
            ItemOrBatchChanged?.Invoke(this, EventArgs.Empty); // refresh side panel

            if (_doneItems >= _totalItems)
                TryMarkBatchReady();
        }

        // ════════════════════════════════════════════════════════════════
        //  TryMarkBatchReady — checks DB before removing all chunks
        // ════════════════════════════════════════════════════════════════

        private void TryMarkBatchReady()
        {
            int pending = _service.CountPendingItems(_batchId);

            if (pending == 0)
            {
                _service.MarkBatchReady(_batchId);
                ItemOrBatchChanged?.Invoke(this, EventArgs.Empty);
                RemoveAllChunksFromParent();
            }
            // if pending > 0 other chunks still have items — do nothing,
            // those chunks will call TryMarkBatchReady when their items are done
        }

        // ════════════════════════════════════════════════════════════════
        //  Remove helpers
        // ════════════════════════════════════════════════════════════════

        private void RemoveAllChunksFromParent()
        {
            if (this.Parent == null) return;

            var parent = this.Parent;
            var toRemove = new List<UCBatchCard>();

            foreach (Control c in parent.Controls)
            {
                if (c is UCBatchCard card && card._batchId == this._batchId)
                    toRemove.Add(card);
            }

            foreach (var card in toRemove)
            {
                parent.Controls.Remove(card);
                card.Dispose();
            }
        }

        // ════════════════════════════════════════════════════════════════
        //  Timer
        // ════════════════════════════════════════════════════════════════

        private void orderTimer_Tick(object sender, EventArgs e)
        {
            var elapsed = DateTime.Now - _sentAt;
            lblTime.Text = elapsed.ToString(@"mm\:ss");
            double min = elapsed.TotalMinutes;

            if (min < 10) pnlColor.BackColor = Color.DarkGray;
            else if (min < 20) pnlColor.BackColor = Color.FromArgb(255, 255, 193, 7);
            else if (min < 30) pnlColor.BackColor = Color.FromArgb(255, 255, 152, 0);
            else pnlColor.BackColor = Color.FromArgb(255, 244, 67, 54);
        }

        private void pnlContiner_Paint(object sender, PaintEventArgs e) { }
        private void lblTime_Click(object sender, EventArgs e) { }
    }
}