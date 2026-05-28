//using CustomControls.RJControls;
//using LaCucina.Models;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace LaCucina.UI
//{
//    public partial class UCBatchCard : UserControl
//    {
//        int secondsElapsed = 0;
//        public UCBatchCard()
//        {
//            InitializeComponent();
//            this.DoubleBuffered = true;

//        }

//        private void pnlContiner_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private DateTime _sentAt;

//        /
//        public void LoadBatch(BatchCardDto batch, bool isFirstCard, bool isLastCard)
//        {
//            UCContinue Continue = new UCContinue();
//            if (isFirstCard)
//            {
//                lblTable.Text = "Table " + batch.TableNumber;
//                lblOrderId.Text = "#" + batch.OrderId;
//                _sentAt = batch.SentAt;

//            }
//            else { pnlHeader.Dispose(); }




//            foreach (var item in batch.Items)
//            {
//                var uc = new UCItemInBatch();
//                uc.LoadItem(item);
//                pnlBatchItems.Controls.Add(uc);
//            }
//            if (!isLastCard) { pnlBatchItems.Controls.Add(Continue); }

//        }







//        private void orderTimer_Tick(object sender, EventArgs e)
//        {

//            var elapsed = DateTime.Now - _sentAt;

//            lblTime.Text = elapsed.ToString(@"mm\:ss");

//            double min = elapsed.TotalMinutes;


//            if (min < 10)
//            {
//                pnlColor.BackColor = Color.DarkGray;
//            }
//            else if (min < 20)
//            {
//                pnlColor.BackColor = Color.FromArgb(255, 255, 193, 7);
//            }
//            else if (min < 30)
//            {
//                pnlColor.BackColor = Color.FromArgb(255, 255, 152, 0);
//            }
//            else
//            {
//                pnlColor.BackColor = Color.FromArgb(255, 244, 67, 54);
//            }

//        }

//        private void lblTime_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
using LaCucina.Models;
using LaCucina.Services;
using System;
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

                // Wire double click on header to mark whole batch done
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
                _totalItems++;
            }

            if (!isLastCard)
            {
                pnlBatchItems.Controls.Add(new UCContinue());
            }
        }

        // ════════════════════════════════════════════════════════════════
        //  Header double click → mark whole batch ready
        // ════════════════════════════════════════════════════════════════

        private void WireHeaderDoubleClick(Control control)
        {
            control.DoubleClick += OnHeaderDoubleClick;
            foreach (Control child in control.Controls)
                WireHeaderDoubleClick(child);
        }

        private void OnHeaderDoubleClick(object sender, EventArgs e)
        {
            MarkBatchReady();
        }

        // ════════════════════════════════════════════════════════════════
        //  Individual item marked done
        // ════════════════════════════════════════════════════════════════

        private void OnItemMarkedDone(object sender, EventArgs e)
        {
            _doneItems++;

            if (_doneItems >= _totalItems)
                MarkBatchReady();
        }

        // ════════════════════════════════════════════════════════════════
        //  Mark batch ready — update DB then remove card from screen
        // ════════════════════════════════════════════════════════════════

        private void MarkBatchReady()
        {
            _service.MarkBatchReady(_batchId);
            RemoveFromParent();
        }

        private void RemoveFromParent()
        {
            if (this.Parent != null)
            {
                this.Visible = false;
                this.Parent.Controls.Remove(this);
                this.Dispose();
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