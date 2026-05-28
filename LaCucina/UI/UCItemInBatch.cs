//using LaCucina.Models;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace LaCucina.UI
//{
//    public partial class UCItemInBatch : UserControl
//    {
//        public UCItemInBatch()
//        {
//            InitializeComponent();
//        }

//        private void lblItemNameAndQuantity_Click(object sender, EventArgs e)
//        {

//        }
//        public void LoadItem(BatchItemDto item)
//        {
//            lblItemNameAndQuantity.Text = item.Quantity + "× " + item.MenuItemName;

//            // fill removed ingredients
//            pnlModifiers.Controls.Clear();
//            foreach (var removed in item.RemovedIngredients)
//            {
//                var lbl = new Label
//                {
//                    AutoSize = true,
//                    Dock = DockStyle.Top,
//                    ForeColor = Color.WhiteSmoke,
//                    Font = new Font("Segoe UI", 9F, FontStyle.Regular),
//                    Text = removed  // e.g. "No onion"
//                };
//                pnlModifiers.Controls.Add(lbl);
//            }

//            // show or hide note
//            if (!string.IsNullOrEmpty(item.NoteText))
//            {
//                pnlNote.Visible = true;
//                lblNote.Text = item.NoteText;
//            }
//            else
//            {
//                pnlNote.Visible = false;
//            }
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
    public partial class UCItemInBatch : UserControl
    {
        private readonly KdsService _service = new KdsService();
        private int _orderItemId;
        private bool _isDone = false;

        // Fired when this item is marked done — parent card listens to this
        public event EventHandler ItemMarkedDone;

        public UCItemInBatch()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
        }

        public void LoadItem(BatchItemDto item)
        {
            _orderItemId = item.OrderItemId;

            lblItemNameAndQuantity.Text = item.Quantity + "× " + item.MenuItemName;

            // Removed ingredients
            pnlModifiers.Controls.Clear();
            foreach (var removed in item.RemovedIngredients)
            {
                var lbl = new Label
                {
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    ForeColor = Color.WhiteSmoke,
                    Font = new Font("Segoe UI", 9f, FontStyle.Regular),
                    Text = removed
                };
                pnlModifiers.Controls.Add(lbl);
            }

            // Note
            if (!string.IsNullOrEmpty(item.NoteText))
            {
                pnlNote.Visible = true;
                lblNote.Text = item.NoteText;
            }
            else
            {
                pnlNote.Visible = false;
            }

            // Wire clicks on all child controls so anywhere on the item is clickable
            WireClick(this);
        }

        // ── Clicking anywhere on the item marks it done ──────────────────

        private void WireClick(Control control)
        {
            control.DoubleClick += OnItemClick;
            foreach (Control child in control.Controls)
                WireClick(child);
        }

        private void OnItemClick(object sender, EventArgs e)
        {
            if (_isDone) return;

            _isDone = true;

            // Visual — strikethrough + darken
            lblItemNameAndQuantity.Font = new Font(
                lblItemNameAndQuantity.Font,
                FontStyle.Strikeout);
            lblItemNameAndQuantity.ForeColor = Color.FromArgb(100, 100, 100);

            foreach (Control c in pnlModifiers.Controls)
                c.ForeColor = Color.FromArgb(100, 100, 100);
            lblNote.ForeColor = Color.FromArgb(100, 100, 100);
            lblNoteTitle.ForeColor = Color.DarkRed;
            this.BackColor = Color.FromArgb(22, 22, 22);

            // Update DB
            _service.MarkItemDone(_orderItemId);

            // Notify parent card
            ItemMarkedDone?.Invoke(this, EventArgs.Empty);
        }

        private void lblItemNameAndQuantity_Click(object sender, EventArgs e)
        {

        }
    }
}