using CrystalDecisions.Windows.Forms;
using LaCucina.DataLink;
using LaCucina.Models;
using LaCucina.Services;
using LaCucina.UI;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace LaCucina
{
    public partial class UCOrders : UserControl
    {
        private readonly OrdersService _service = new OrdersService();
        private UCOrderRow _selectedRow = null;

        public UCOrders()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════════════
        //  Load
        // ════════════════════════════════════════════════════════════════

        private void UCOrders_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            dtpFrom.Value = new DateTime(2000, 1, 1);
            dtpTo.Value = DateTime.Today;

            LoadFilters();
            LoadOrders();
        }

        private void LoadFilters()
        {
            cmbWaiter.Items.Clear();
            cmbWaiter.Items.Add("All");
            foreach (var waiter in _service.GetWaiters())
                cmbWaiter.Items.Add(waiter);
            cmbWaiter.SelectedIndex = 0;
        }

        // ════════════════════════════════════════════════════════════════
        //  Load orders
        // ════════════════════════════════════════════════════════════════

        private void LoadOrders()
        {
            flowOrders.Controls.Clear();
            _selectedRow = null;
            ClearReceipt();

            string waiter = cmbWaiter.SelectedIndex > 0
                ? cmbWaiter.SelectedItem.ToString()
                : null;

            var orders = _service.GetOrders(
                from: dtpFrom.Value.Date,
                to: dtpTo.Value.Date,
                waiter: waiter);

            foreach (var order in orders)
            {
                var row = new UCOrderRow();
                row.LoadOrder(order);
                row.Width = flowOrders.ClientSize.Width - 4;
                row.RowSelected += OnRowSelected;
                flowOrders.Controls.Add(row);

                var sep = new Panel
                {
                    Height = 1,
                    Width = flowOrders.ClientSize.Width - 4,
                    BackColor = Color.FromArgb(30, 30, 30)
                };
                flowOrders.Controls.Add(sep);
            }
        }

        // ════════════════════════════════════════════════════════════════
        //  Row selected → load receipt
        // ════════════════════════════════════════════════════════════════

        private void OnRowSelected(object sender, EventArgs e)
        {
            var row = (UCOrderRow)sender;

            if (_selectedRow != null)
                _selectedRow.SetSelected(false);

            _selectedRow = row;
            row.SetSelected(true);

            LoadReceipt(row.OrderId);
        }

        private void LoadReceipt(int orderId)
        {
            var detail = _service.GetOrderDetail(orderId);
            if (detail == null) return;

            lblReceiptOrderId.Text = "Order ID #" + detail.OrderId;
            lblReceiptMeta.Text = (detail.IsTakeaway ? "Takeaway" : "Dine-in  T-" + detail.TableNumber)
                                   + "   " + detail.CreatedAt.ToString("HH:mm  yyyy-MM-dd");

            flowReceiptItems.Controls.Clear();
            foreach (var item in detail.Items)
            {
                var uc = new UCOrderItemRow();
                uc.LoadItem(item);
                uc.Width = flowReceiptItems.ClientSize.Width - 4;
                flowReceiptItems.Controls.Add(uc);
            }

            decimal subtotal = detail.TotalAmount + (detail.DiscountAmount ?? 0);
            lblSubtotalV.Text = "$" + subtotal.ToString("0.00");
            lblDiscountV.Text = detail.DiscountAmount.HasValue
                ? "-$" + detail.DiscountAmount.Value.ToString("0.00")
                : "$0.00";
            lblTotalV.Text = "$" + detail.TotalAmount.ToString("0.00");
        }

        private void ClearReceipt()
        {
            lblReceiptOrderId.Text = "Select an order";
            lblReceiptMeta.Text = "";
            flowReceiptItems.Controls.Clear();
            lblSubtotalV.Text = "$0.00";
            lblDiscountV.Text = "$0.00";
            lblTotalV.Text = "$0.00";
        }

        // ════════════════════════════════════════════════════════════════
        //  Filter buttons
        // ════════════════════════════════════════════════════════════════

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = new DateTime(2000, 1, 1);
            dtpTo.Value = DateTime.Today;
            cmbWaiter.SelectedIndex = 0;
            LoadOrders();
        }

        // ════════════════════════════════════════════════════════════════
        //  Print
        // ════════════════════════════════════════════════════════════════

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_selectedRow == null || _selectedRow.OrderId == 0)
            {
                MessageBox.Show("Please select or open an active order to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                POSRepository repo = new POSRepository();
                DataTable dtReceipt = repo.GetOrderReceiptDetails(_selectedRow.OrderId);

                if (dtReceipt.Rows.Count > 0)
                {
                    CrystalReport3 myReport = new CrystalReport3();
                    myReport.SetDataSource(dtReceipt);

                    using (Form previewForm = new Form())
                    {
                        CrystalReportViewer viewer = new CrystalReportViewer();
                        viewer.Dock = DockStyle.Fill;
                        viewer.ReportSource = myReport;

                        previewForm.Controls.Add(viewer);
                        previewForm.WindowState = FormWindowState.Maximized;
                        previewForm.Text = "Invoice Preview - La Cucina";

                        previewForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show($"No data found in the database for order number {_selectedRow.OrderId}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the display process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void USOrders_Load(object sender, EventArgs e) { }
        private void rjButton3_Click(object sender, EventArgs e) { }

        private void pnlFilters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbWaiter_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFilterWaiter_Click(object sender, EventArgs e)
        {

        }
    }
}