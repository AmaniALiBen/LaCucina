using LaCucina.Models;
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

namespace LaCucina.UI
{
    public partial class UCOrderRow : UserControl
    {
        private static readonly Color ColorNormal = Color.FromArgb(28, 28, 28);
        private static readonly Color ColorHover = Color.FromArgb(38, 38, 38);
        private static readonly Color ColorSelected = Color.FromArgb(50, 45, 35);
        private static readonly Color AccentOrange = Color.FromArgb(239, 128, 16);

        private bool _isSelected = false;

        public int OrderId { get; private set; }
        public event EventHandler RowSelected;

        public UCOrderRow()
        {
            InitializeComponent();
            WireHover(this);
        }

        public void LoadOrder(OrderRowDto order)
        {
            OrderId = order.OrderId;

            lblOrderId.Text = "#" + order.OrderId;
            lblType.Text = order.IsTakeaway ? "Takeaway" : "Dine-in";
            lblTable.Text = order.IsTakeaway ? "—" : "T-" + order.TableNumber;
            lblServedBy.Text = order.WaiterName;
            lblDateTime.Text = order.CreatedAt.ToString("HH:mm yyyy-MM-dd");
            lblTotal.Text = "$" + order.TotalAmount.ToString("0.00");
                
        }

        public void SetSelected(bool selected)
        {
            _isSelected = selected;
            this.BackColor = selected ? ColorSelected : ColorNormal;

            // Highlight order ID in orange when selected
            lblOrderId.ForeColor = selected ? AccentOrange : Color.FromArgb(242, 242, 242);
        }

        // ── Hover ────────────────────────────────────────────────────────

        private void WireHover(Control control)
        {
            control.MouseEnter += OnMouseEnter;
            control.MouseLeave += OnMouseLeave;
            control.Click += OnRowClick;
            foreach (Control child in control.Controls)
                WireHover(child);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            if (!_isSelected)
                this.BackColor = ColorHover;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (!_isSelected)
                this.BackColor = ColorNormal;
        }

        private void OnRowClick(object sender, EventArgs e)
        {
            RowSelected?.Invoke(this, EventArgs.Empty);
        }

        private void UCOrderRow_Load(object sender, EventArgs e)
        {

        }
    }
}
