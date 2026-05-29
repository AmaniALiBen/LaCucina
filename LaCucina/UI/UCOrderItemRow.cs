using LaCucina.Models;
using System.Drawing;
using System.Windows.Forms;

namespace LaCucina.UI
{
    public partial class UCOrderItemRow : UserControl
    {
        public UCOrderItemRow()
        {
            InitializeComponent();
        }

        public void LoadItem(OrderItemDto item)
        {
            lblQuantity.Text = item.Quantity.ToString();
            lblName.Text = item.MenuItemName;
            lblPrice.Text = "$" + item.TotalPrice.ToString("0.00");

            // Modifiers
            pnlModifiers.Controls.Clear();
            foreach (var removed in item.RemovedIngredients)
            {
                var lbl = new Label
                {
                    AutoSize = true,
                    Font = new Font("Yu Gothic", 8.5f),
                    ForeColor = Color.FromArgb(150, 150, 150),
                    BackColor = Color.Transparent,
                    Text = "  — " + removed,
                    Padding = new Padding(0, 1, 0, 1),
                    Margin = new Padding(0)
                };
                pnlModifiers.Controls.Add(lbl);
            }

            // Adjust modifier panel position
            pnlModifiers.Visible = item.RemovedIngredients.Count > 0;

            // Note
            if (!string.IsNullOrEmpty(item.NoteText))
            {
                pnlNote.Visible = true;
                lblNote.Text = "  ✎ " + item.NoteText;

                // Position note below modifiers
                int modBottom = pnlModifiers.Visible
                    ? pnlModifiers.Bottom + 2
                    : 36;
                pnlNote.Location = new Point(44, modBottom);
            }
            else
            {
                pnlNote.Visible = false;
            }
        }
    }
}
