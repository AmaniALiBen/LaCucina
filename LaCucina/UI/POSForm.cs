using LaCucina.Models;
using LaCucina.Services;
using LaCucina.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using LaCucina.DataLink;

namespace LaCucina
{
    public partial class POSForm : Form
    {
        UCbtnCategory _selectedCategory;
        MenuService Service = new MenuService();

        private List<MemoryOrderItem> currentOrderItems = new List<MemoryOrderItem>();
        private string currentTableNum = "0";
        private int currentTableId;
        private int currentUserId = 1;
        private int currentOrderId = 0;

        private bool isTakeAway = false;

        private List<Item> currentCategoryItems = new List<Item>();

        public void loadMenu()
        {
            pnlCAtegories.Controls.Clear();
            List<Categories> categoryList = Service.GetCategories();

            foreach (Categories cat in categoryList)
            {
                UCbtnCategory category = new UCbtnCategory();
                category._Name = cat.name;
                category.Tag = cat.id;

                category.clickCategory = () =>
                {
                    category.btnName.ForeColor = Color.DarkOrange;

                    _selectedCategory = category;
                    foreach (UCbtnCategory c in pnlCAtegories.Controls)
                    {
                        if (c != _selectedCategory)
                        {
                            c.btnName.ForeColor = Color.FromArgb(242, 242, 242);
                        }
                    }

                    pnlItems.Controls.Clear();

                    if (txtSearch != null) txtSearch.Texts="";

                    currentCategoryItems = Service.GetInStockItemsByCategory(Convert.ToInt32(_selectedCategory.Tag));

                    BuildProductCards(currentCategoryItems);
                };

                pnlCAtegories.Controls.Add(category);
            }
        }

        private void BuildProductCards(List<Item> itemsList)
        {
            pnlItems.Controls.Clear();

            foreach (Item i in itemsList)
            {
                UC_ProductCard card = new UC_ProductCard();

                card.Name = i.Name;
                card.Price = i.Price;
                card.Id = i.Id;

                pnlItems.Controls.Add(card);

                card.clickCard = () =>
                {
                    MemoryOrderItem newItem = new MemoryOrderItem();
                    newItem.UniqueId = Guid.NewGuid().ToString();
                    newItem.MenuItemId = i.Id;
                    newItem.ItemName = i.Name;
                    newItem.UnitPrice = i.Price;
                    newItem.Quantity = 1;

                    ItemModifierForm f = new ItemModifierForm(newItem);

                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        bool isMerged = false;

                        foreach (Control ctrl in pnlInvoiceItems.Controls)
                        {
                            if (ctrl is UC_InvoiceItem uiItem && uiItem.Tag is MemoryOrderItem attachedMemoryItem)
                            {
                                bool listsMatch = true;
                                if (attachedMemoryItem.RemovedIngredientIds.Count == newItem.RemovedIngredientIds.Count)
                                {
                                    foreach (int id in attachedMemoryItem.RemovedIngredientIds)
                                    {
                                        if (!newItem.RemovedIngredientIds.Contains(id))
                                        {
                                            listsMatch = false;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    listsMatch = false;
                                }

                                bool isSameItemAndModifiers = attachedMemoryItem.MenuItemId == newItem.MenuItemId &&
                                                              attachedMemoryItem.NoteText == newItem.NoteText &&
                                                              listsMatch;

                                if (isSameItemAndModifiers && !uiItem.IsSavedInDatabase)
                                {
                                    MemoryOrderItem existingItem = null;
                                    foreach (MemoryOrderItem oi in currentOrderItems)
                                    {
                                        if (oi.UniqueId == attachedMemoryItem.UniqueId)
                                        {
                                            existingItem = oi;
                                            break;
                                        }
                                    }

                                    if (existingItem != null)
                                    {
                                        existingItem.Quantity += newItem.Quantity;
                                        existingItem.TotalPrice = existingItem.Quantity * existingItem.UnitPrice;
                                    }

                                    uiItem.Quantity = attachedMemoryItem.Quantity;
                                    isMerged = true;
                                    break;
                                }
                            }
                        }

                        if (!isMerged)
                        {
                            currentOrderItems.Add(newItem);

                            UC_InvoiceItem invoiceUiItem = new UC_InvoiceItem(newItem.ItemName, newItem.Quantity, Convert.ToDouble(newItem.UnitPrice));
                            invoiceUiItem.Tag = newItem;

                            newItem.Quantity = invoiceUiItem.Quantity;
                            newItem.TotalPrice = invoiceUiItem.Subtotal;

                            invoiceUiItem.DataChanged += Item_DataChanged;
                            invoiceUiItem.ItemRemoved += Item_ItemRemoved;

                            pnlInvoiceItems.Controls.Add(invoiceUiItem);
                        }

                        CalTotal();
                    }
                };
            }
        }

        Form form;
        public POSForm()
        {
            InitializeComponent();
        }
        public POSForm(bool isTakeAway, string tableNum, int tableId)
        {
            InitializeComponent();
            this.isTakeAway = isTakeAway;
            this.currentTableNum = tableNum;
            this.currentTableId = tableId;
        }

        public POSForm(Form form, bool isTakeAway)
        {
            InitializeComponent();
            this.isTakeAway = isTakeAway;
            this.form = form;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd /MM /yyyy");
            loadMenu();
            lblUser.Text = Session.CurrentUser.Username;
            currentUserId = Session.CurrentUser.Id;
            lblTableNum.Text = "Table: " + currentTableNum;
            lblOrderNum.Text = "Order: " + currentOrderId;
            LoadOpenOrderItems();
            FillDiscountsCombo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss ");
        }

        private void LoadOpenOrderItems()
        {
            if (!isTakeAway)
            {
                POSService pOSService = new POSService();
                int openOrderId;
                double currentTotal;

                List<MemoryOrderItem> savedItems = pOSService.LoadOpenOrder(currentTableId, out openOrderId, out currentTotal);

                if (openOrderId > 0)
                {
                    currentOrderId = openOrderId;

                    foreach (var item in savedItems)
                    {
                        UC_InvoiceItem invoiceUiItem = new UC_InvoiceItem(item.ItemName, item.Quantity, Convert.ToDouble(item.UnitPrice));
                        invoiceUiItem.Tag = item;
                        invoiceUiItem.MarkAsSavedInDatabase();

                        pnlInvoiceItems.Controls.Add(invoiceUiItem);
                    }
                }
            }

            lblOrderNum.Text = "Order: " + currentOrderId;
            CalTotal();
        }

        private void FillDiscountsCombo()
        {
            try
            {
                POSService pOSService = new POSService();
                DataTable dtDiscounts = pOSService.GetDiscountsForForm();
                DataRow defaultRow = dtDiscounts.NewRow();
                defaultRow["discount_id"] = 0;
                defaultRow["discount_name"] = "No Discount";
                defaultRow["discount_type"] = 0;
                defaultRow["discount_amount"] = 0.00;

                dtDiscounts.Rows.InsertAt(defaultRow, 0);

                cmbDiscounts.DataSource = dtDiscounts;
                cmbDiscounts.DisplayMember = "discount_name";
                cmbDiscounts.ValueMember = "discount_id";

                cmbDiscounts.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading discounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Item_DataChanged(object sender, EventArgs e)
        {
            if (sender is UC_InvoiceItem uiItem && uiItem.Tag is MemoryOrderItem memoryItem)
            {
                memoryItem.Quantity = uiItem.Quantity;
                memoryItem.TotalPrice = uiItem.Subtotal;
            }
            CalTotal();
        }

        private void Item_ItemRemoved(object sender, EventArgs e)
        {
            if (sender is UC_InvoiceItem uiItem && uiItem.Tag is MemoryOrderItem memoryItem)
            {
                for (int i = currentOrderItems.Count - 1; i >= 0; i--)
                {
                    if (currentOrderItems[i].UniqueId == memoryItem.UniqueId)
                    {
                        currentOrderItems.RemoveAt(i);
                    }
                }

                pnlInvoiceItems.Controls.Remove(uiItem);
                uiItem.Dispose();

                CalTotal();
            }
        }

        public double CalTotal()
        {
            double subTotal = 0;

            foreach (Control ctrl in pnlInvoiceItems.Controls)
            {
                if (ctrl is UC_InvoiceItem item)
                {
                    subTotal += item.Subtotal;
                }
            }

            lblSubtotal.Text = subTotal.ToString("N2") + " LYD";

            UpdateNetTotalDisplay(subTotal);

            return subTotal;
        }

        private void UpdateNetTotalDisplay(double subTotalAmount)
        {
            double finalTotalAmount = subTotalAmount;

            if (cmbDiscounts.SelectedIndex > 0 && cmbDiscounts.SelectedItem != null)
            {
                DataRowView selectedDiscount = (DataRowView)cmbDiscounts.SelectedItem;
                byte discountType = Convert.ToByte(selectedDiscount["discount_type"]);
                double discountValue = Convert.ToDouble(selectedDiscount["discount_amount"]);

                if (discountType == 0)
                {
                    finalTotalAmount = subTotalAmount - (subTotalAmount * (discountValue / 100));
                }
                else
                {
                    finalTotalAmount = subTotalAmount - discountValue;
                }

                if (finalTotalAmount < 0) finalTotalAmount = 0;
            }

            lblNetTotal.Text = finalTotalAmount.ToString("N2") + " LYD";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (currentOrderItems == null || currentOrderItems.Count == 0)
            {
                MessageBox.Show("Add Items To The Order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double subTotalAmount = CalTotal();
            double finalTotalAmount = subTotalAmount;

            int? discountId = null;
            byte? discountType = null;
            double discountValue = 0;

            POSService pOSService = new POSService();

            bool isSaved = pOSService.ProcessAndSendOrder(
                currentTableId,
                currentUserId,
                currentOrderItems,
                subTotalAmount,
                finalTotalAmount,
                discountId,
                discountType,
                discountValue,
                isTakeAway,
                out currentOrderId
            );

            if (isSaved)
            {
                if (this.isTakeAway)
                {
                    btnPay.PerformClick();
                    return;
                }

                MessageBox.Show("Batch sent successfully to the kitchen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblOrderNum.Text = "Order: " + currentOrderId.ToString() + "#";

                foreach (Control ctrl in pnlInvoiceItems.Controls)
                {
                    if (ctrl is UC_InvoiceItem uiItem)
                    {
                        uiItem.MarkAsSavedInDatabase();
                    }
                }

                currentOrderItems.Clear();

                CalTotal();
            }
            else
            {
                MessageBox.Show("Error sending batch to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (form != null)
                form.Show();

            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (pnlInvoiceItems.Controls.Count == 0)
            {
                MessageBox.Show("There are no items in the invoice to pay for.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double subTotalAmount = CalTotal();
            double finalTotalAmount = subTotalAmount;
            double discountAmountValueCalculated = 0;

            int? discountId = null;
            byte? discountType = null;
            double discountValue = 0;

            if (cmbDiscounts.SelectedIndex > 0)
            {
                DataRowView selectedDiscount = (DataRowView)cmbDiscounts.SelectedItem;
                discountId = Convert.ToInt32(selectedDiscount["discount_id"]);
                discountType = Convert.ToByte(selectedDiscount["discount_type"]);
                discountValue = Convert.ToDouble(selectedDiscount["discount_amount"]);

                if (discountType == 0)
                {
                    discountAmountValueCalculated = subTotalAmount * (discountValue / 100);
                }
                else
                {
                    discountAmountValueCalculated = discountValue;
                }

                finalTotalAmount = subTotalAmount - discountAmountValueCalculated;
                if (finalTotalAmount < 0) finalTotalAmount = 0;
            }

            string confirmMsg = "";
            if (discountAmountValueCalculated > 0)
            {
                confirmMsg = $"Original Total: {subTotalAmount:N2} LYD\n" +
                             $"Discount Applied: -{discountAmountValueCalculated:N2} LYD\n" +
                             $"-----------------------------------\n" +
                             $"Net Amount to Pay: {finalTotalAmount:N2} LYD\n\n" +
                             $"Do you want to process payment and close this order?";
            }
            else
            {
                confirmMsg = $"Total Amount to Pay: {finalTotalAmount:N2} LYD\n\n" +
                             $"Are you sure you want to complete the payment?";
            }

            DialogResult result = MessageBox.Show(confirmMsg, "Confirm Process Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                POSService pOSService = new POSService();

                if (isTakeAway && currentOrderId == 0)
                {
                    bool isSaved = pOSService.ProcessAndSendOrder(
                        currentTableId, currentUserId, currentOrderItems,
                        subTotalAmount, finalTotalAmount, discountId, discountType, discountValue,
                        isTakeAway, out currentOrderId
                    );

                    if (!isSaved)
                    {
                        MessageBox.Show("Failed to save the takeaway order details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (discountId > 0)
                    {
                        pOSService.UpdateOrderDiscount(currentOrderId, subTotalAmount, finalTotalAmount, discountId, discountType, discountAmountValueCalculated);
                    }
                }
                else if (!isTakeAway && currentOrderId > 0)
                {
                    int tempOrderId;
                    pOSService.ProcessAndSendOrder(
                        currentTableId, currentUserId, new List<MemoryOrderItem>(),
                        subTotalAmount, finalTotalAmount, discountId, discountType, discountValue,
                        isTakeAway, out tempOrderId
                    );

                    pOSService.UpdateOrderDiscount(currentOrderId, subTotalAmount, finalTotalAmount, discountId, discountType, discountAmountValueCalculated);
                }
                else if (!isTakeAway && currentOrderId == 0)
                {
                    MessageBox.Show("Please send the order to the kitchen first before processing payment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isPaid = pOSService.CompleteOrderPayment(currentOrderId);

                if (isPaid)
                {
                    MessageBox.Show("Payment completed successfully! The order is now closed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnPrintInvoice.PerformClick();
                    currentOrderItems.Clear();
                    pnlInvoiceItems.Controls.Clear();
                    currentOrderId = 0;
                    lblOrderNum.Text = "Order: 0";
                    cmbDiscounts.SelectedIndex = 0;
                    CalTotal();
                }
                else
                {
                    MessageBox.Show("An error occurred while processing the payment in the database.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbDiscounts_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            double subTotalAmount = 0;
            foreach (Control ctrl in pnlInvoiceItems.Controls)
            {
                if (ctrl is UC_InvoiceItem item)
                {
                    subTotalAmount += item.Subtotal;
                }
            }
            UpdateNetTotalDisplay(subTotalAmount);
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (currentOrderId == 0)
            {
                MessageBox.Show("Please select or open an active order to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                POSRepository repo = new POSRepository();
                DataTable dtReceipt = repo.GetOrderReceiptDetails(currentOrderId);

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
                    MessageBox.Show($"No data found in the database for order number {currentOrderId}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the display process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (_selectedCategory == null) return;

            string keyword = txtSearch.Texts.Trim().ToLower();

            List<Item> filteredItems = new List<Item>();
            foreach (Item item in currentCategoryItems)
            {
                if (item.Name.ToLower().StartsWith(keyword))
                {
                    filteredItems.Add(item);
                }
            }

            BuildProductCards(filteredItems);
        }
    }
}