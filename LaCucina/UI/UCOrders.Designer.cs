namespace LaCucina
{
    partial class UCOrders
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.flowOrders = new SmoothFlowPanel();
            this.pnlHeaders = new System.Windows.Forms.Panel();
            this.lblHOrderId = new System.Windows.Forms.Label();
            this.lblHType = new System.Windows.Forms.Label();
            this.lblHTable = new System.Windows.Forms.Label();
            this.lblHServedBy = new System.Windows.Forms.Label();
            this.lblHDateTime = new System.Windows.Forms.Label();
            this.lblHTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFilters = new CustomControls.RJControls.RJPanel();
            this.btnClear = new CustomControls.RJControls.RJButton();
            this.cmbWaiter = new CustomControls.RJControls.RJComboBox();
            this.btnFilter = new CustomControls.RJControls.RJButton();
            this.lblFilterDate = new System.Windows.Forms.Label();
            this.dtpFrom = new CustomControls.RJControls.RJDatePicker();
            this.lblFilterWaiter = new System.Windows.Forms.Label();
            this.dtpTo = new CustomControls.RJControls.RJDatePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlReceiptWrap = new CustomControls.RJControls.RJPanel();
            this.flowReceiptItems = new SmoothFlowPanel();
            this.pnlReceiptFooter = new System.Windows.Forms.Panel();
            this.pnlPrintWrap = new CustomControls.RJControls.RJgradiantPanal();
            this.btnPrint = new CustomControls.RJControls.RJButton();
            this.lblTotalV = new System.Windows.Forms.Label();
            this.lblTotalL = new System.Windows.Forms.Label();
            this.lblDiscountV = new System.Windows.Forms.Label();
            this.lblDiscountL = new System.Windows.Forms.Label();
            this.lblSubtotalV = new System.Windows.Forms.Label();
            this.lblSubtotalL = new System.Windows.Forms.Label();
            this.pnlReceiptHeader = new System.Windows.Forms.Panel();
            this.lblReceiptOrderId = new System.Windows.Forms.Label();
            this.lblReceiptMeta = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlHeaders.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlReceiptWrap.SuspendLayout();
            this.pnlReceiptFooter.SuspendLayout();
            this.pnlPrintWrap.SuspendLayout();
            this.pnlReceiptHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pnlLeft.Controls.Add(this.flowOrders);
            this.pnlLeft.Controls.Add(this.pnlHeaders);
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(34, 21, 34, 21);
            this.pnlLeft.Size = new System.Drawing.Size(1281, 1133);
            this.pnlLeft.TabIndex = 0;
            // 
            // flowOrders
            // 
            this.flowOrders.AutoScroll = true;
            this.flowOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.flowOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowOrders.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowOrders.Location = new System.Drawing.Point(34, 315);
            this.flowOrders.Name = "flowOrders";
            this.flowOrders.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.flowOrders.Size = new System.Drawing.Size(1213, 797);
            this.flowOrders.TabIndex = 0;
            this.flowOrders.WrapContents = false;
            // 
            // pnlHeaders
            // 
            this.pnlHeaders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlHeaders.Controls.Add(this.lblHOrderId);
            this.pnlHeaders.Controls.Add(this.lblHType);
            this.pnlHeaders.Controls.Add(this.lblHTable);
            this.pnlHeaders.Controls.Add(this.lblHServedBy);
            this.pnlHeaders.Controls.Add(this.lblHDateTime);
            this.pnlHeaders.Controls.Add(this.lblHTotal);
            this.pnlHeaders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaders.Location = new System.Drawing.Point(34, 264);
            this.pnlHeaders.Name = "pnlHeaders";
            this.pnlHeaders.Size = new System.Drawing.Size(1213, 51);
            this.pnlHeaders.TabIndex = 1;
            // 
            // lblHOrderId
            // 
            this.lblHOrderId.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHOrderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblHOrderId.Location = new System.Drawing.Point(37, 0);
            this.lblHOrderId.Name = "lblHOrderId";
            this.lblHOrderId.Size = new System.Drawing.Size(120, 51);
            this.lblHOrderId.TabIndex = 0;
            this.lblHOrderId.Text = "Order ID";
            this.lblHOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHType
            // 
            this.lblHType.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblHType.Location = new System.Drawing.Point(231, 0);
            this.lblHType.Name = "lblHType";
            this.lblHType.Size = new System.Drawing.Size(100, 51);
            this.lblHType.TabIndex = 1;
            this.lblHType.Text = "Type";
            this.lblHType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHTable
            // 
            this.lblHTable.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblHTable.Location = new System.Drawing.Point(393, 0);
            this.lblHTable.Name = "lblHTable";
            this.lblHTable.Size = new System.Drawing.Size(120, 51);
            this.lblHTable.TabIndex = 2;
            this.lblHTable.Text = "Table";
            this.lblHTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHServedBy
            // 
            this.lblHServedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHServedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblHServedBy.Location = new System.Drawing.Point(599, 0);
            this.lblHServedBy.Name = "lblHServedBy";
            this.lblHServedBy.Size = new System.Drawing.Size(150, 51);
            this.lblHServedBy.TabIndex = 3;
            this.lblHServedBy.Text = "Served By";
            this.lblHServedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHDateTime
            // 
            this.lblHDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblHDateTime.Location = new System.Drawing.Point(823, 0);
            this.lblHDateTime.Name = "lblHDateTime";
            this.lblHDateTime.Size = new System.Drawing.Size(180, 51);
            this.lblHDateTime.TabIndex = 4;
            this.lblHDateTime.Text = "Date & Time";
            this.lblHDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHTotal
            // 
            this.lblHTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblHTotal.Location = new System.Drawing.Point(1067, 0);
            this.lblHTotal.Name = "lblHTotal";
            this.lblHTotal.Size = new System.Drawing.Size(120, 51);
            this.lblHTotal.TabIndex = 6;
            this.lblHTotal.Text = "Total";
            this.lblHTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlFilters);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(34, 118);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.panel1.Size = new System.Drawing.Size(1213, 146);
            this.panel1.TabIndex = 5;
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlFilters.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlFilters.BorderRadius = 15;
            this.pnlFilters.BorderSize = 0;
            this.pnlFilters.Controls.Add(this.btnClear);
            this.pnlFilters.Controls.Add(this.cmbWaiter);
            this.pnlFilters.Controls.Add(this.btnFilter);
            this.pnlFilters.Controls.Add(this.lblFilterDate);
            this.pnlFilters.Controls.Add(this.dtpFrom);
            this.pnlFilters.Controls.Add(this.lblFilterWaiter);
            this.pnlFilters.Controls.Add(this.dtpTo);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.ForeColor = System.Drawing.Color.Black;
            this.pnlFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1213, 114);
            this.pnlFilters.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClear.BorderRadius = 8;
            this.btnClear.BorderSize = 1;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnClear.Location = new System.Drawing.Point(1091, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 45);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbWaiter
            // 
            this.cmbWaiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.cmbWaiter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbWaiter.BorderSize = 1;
            this.cmbWaiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbWaiter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbWaiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cmbWaiter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(128)))), ((int)(((byte)(16)))));
            this.cmbWaiter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.cmbWaiter.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cmbWaiter.Location = new System.Drawing.Point(727, 35);
            this.cmbWaiter.MinimumSize = new System.Drawing.Size(200, 32);
            this.cmbWaiter.Name = "cmbWaiter";
            this.cmbWaiter.Padding = new System.Windows.Forms.Padding(1);
            this.cmbWaiter.Size = new System.Drawing.Size(217, 54);
            this.cmbWaiter.TabIndex = 2;
            this.cmbWaiter.Texts = "";
            this.cmbWaiter.OnSelectedIndexChanged += new System.EventHandler(this.cmbWaiter_OnSelectedIndexChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(128)))), ((int)(((byte)(16)))));
            this.btnFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(128)))), ((int)(((byte)(16)))));
            this.btnFilter.BorderColor = System.Drawing.Color.Transparent;
            this.btnFilter.BorderRadius = 8;
            this.btnFilter.BorderSize = 0;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Location = new System.Drawing.Point(978, 36);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 45);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextColor = System.Drawing.Color.Black;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.AutoSize = true;
            this.lblFilterDate.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblFilterDate.Location = new System.Drawing.Point(37, 42);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(59, 28);
            this.lblFilterDate.TabIndex = 6;
            this.lblFilterDate.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dtpFrom.BorderSize = 1;
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(114, 35);
            this.dtpFrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(234, 35);
            this.dtpFrom.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.dtpFrom.TabIndex = 5;
            this.dtpFrom.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            // 
            // lblFilterWaiter
            // 
            this.lblFilterWaiter.AutoSize = true;
            this.lblFilterWaiter.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterWaiter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterWaiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblFilterWaiter.Location = new System.Drawing.Point(643, 42);
            this.lblFilterWaiter.Name = "lblFilterWaiter";
            this.lblFilterWaiter.Size = new System.Drawing.Size(70, 28);
            this.lblFilterWaiter.TabIndex = 3;
            this.lblFilterWaiter.Text = "Waiter";
            this.lblFilterWaiter.Click += new System.EventHandler(this.lblFilterWaiter_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dtpTo.BorderSize = 1;
            this.dtpTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(374, 35);
            this.dtpTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(234, 35);
            this.dtpTo.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.dtpTo.TabIndex = 4;
            this.dtpTo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTitle.Location = new System.Drawing.Point(34, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 32);
            this.lblTitle.Size = new System.Drawing.Size(1213, 97);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "🛒  Orders History";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pnlRight.Controls.Add(this.pnlReceiptWrap);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1281, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10, 26, 25, 26);
            this.pnlRight.Size = new System.Drawing.Size(639, 1133);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlReceiptWrap
            // 
            this.pnlReceiptWrap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnlReceiptWrap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlReceiptWrap.BorderRadius = 14;
            this.pnlReceiptWrap.BorderSize = 1;
            this.pnlReceiptWrap.Controls.Add(this.flowReceiptItems);
            this.pnlReceiptWrap.Controls.Add(this.pnlReceiptFooter);
            this.pnlReceiptWrap.Controls.Add(this.pnlReceiptHeader);
            this.pnlReceiptWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReceiptWrap.ForeColor = System.Drawing.Color.Black;
            this.pnlReceiptWrap.Location = new System.Drawing.Point(10, 26);
            this.pnlReceiptWrap.Name = "pnlReceiptWrap";
            this.pnlReceiptWrap.Size = new System.Drawing.Size(604, 1081);
            this.pnlReceiptWrap.TabIndex = 0;
            // 
            // flowReceiptItems
            // 
            this.flowReceiptItems.AutoScroll = true;
            this.flowReceiptItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.flowReceiptItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowReceiptItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowReceiptItems.Location = new System.Drawing.Point(0, 84);
            this.flowReceiptItems.Name = "flowReceiptItems";
            this.flowReceiptItems.Padding = new System.Windows.Forms.Padding(20, 11, 20, 11);
            this.flowReceiptItems.Size = new System.Drawing.Size(604, 776);
            this.flowReceiptItems.TabIndex = 0;
            this.flowReceiptItems.WrapContents = false;
            // 
            // pnlReceiptFooter
            // 
            this.pnlReceiptFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnlReceiptFooter.Controls.Add(this.pnlPrintWrap);
            this.pnlReceiptFooter.Controls.Add(this.lblTotalV);
            this.pnlReceiptFooter.Controls.Add(this.lblTotalL);
            this.pnlReceiptFooter.Controls.Add(this.lblDiscountV);
            this.pnlReceiptFooter.Controls.Add(this.lblDiscountL);
            this.pnlReceiptFooter.Controls.Add(this.lblSubtotalV);
            this.pnlReceiptFooter.Controls.Add(this.lblSubtotalL);
            this.pnlReceiptFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlReceiptFooter.Location = new System.Drawing.Point(0, 860);
            this.pnlReceiptFooter.Name = "pnlReceiptFooter";
            this.pnlReceiptFooter.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.pnlReceiptFooter.Size = new System.Drawing.Size(604, 221);
            this.pnlReceiptFooter.TabIndex = 1;
            // 
            // pnlPrintWrap
            // 
            this.pnlPrintWrap.BackColor = System.Drawing.Color.White;
            this.pnlPrintWrap.BorderColor = System.Drawing.Color.Transparent;
            this.pnlPrintWrap.BorderRadius = 10;
            this.pnlPrintWrap.BorderSize = 0;
            this.pnlPrintWrap.Controls.Add(this.btnPrint);
            this.pnlPrintWrap.ForeColor = System.Drawing.Color.Black;
            this.pnlPrintWrap.GradientAngle = 45F;
            this.pnlPrintWrap.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(128)))), ((int)(((byte)(16)))));
            this.pnlPrintWrap.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            this.pnlPrintWrap.Location = new System.Drawing.Point(24, 142);
            this.pnlPrintWrap.Name = "pnlPrintWrap";
            this.pnlPrintWrap.Size = new System.Drawing.Size(497, 53);
            this.pnlPrintWrap.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderRadius = 10;
            this.btnPrint.BorderSize = 0;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(0, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(497, 53);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "🖨️  Print Invoice";
            this.btnPrint.TextColor = System.Drawing.Color.Black;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTotalV
            // 
            this.lblTotalV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalV.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(128)))), ((int)(((byte)(16)))));
            this.lblTotalV.Location = new System.Drawing.Point(420, 84);
            this.lblTotalV.Name = "lblTotalV";
            this.lblTotalV.Size = new System.Drawing.Size(160, 29);
            this.lblTotalV.TabIndex = 1;
            this.lblTotalV.Text = "$0.00";
            this.lblTotalV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalL
            // 
            this.lblTotalL.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTotalL.Location = new System.Drawing.Point(20, 84);
            this.lblTotalL.Name = "lblTotalL";
            this.lblTotalL.Size = new System.Drawing.Size(200, 29);
            this.lblTotalL.TabIndex = 2;
            this.lblTotalL.Text = "Grand Total";
            // 
            // lblDiscountV
            // 
            this.lblDiscountV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscountV.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscountV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiscountV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lblDiscountV.Location = new System.Drawing.Point(420, 48);
            this.lblDiscountV.Name = "lblDiscountV";
            this.lblDiscountV.Size = new System.Drawing.Size(160, 25);
            this.lblDiscountV.TabIndex = 3;
            this.lblDiscountV.Text = "$0.00";
            this.lblDiscountV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountL
            // 
            this.lblDiscountL.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscountL.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiscountL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblDiscountL.Location = new System.Drawing.Point(20, 48);
            this.lblDiscountL.Name = "lblDiscountL";
            this.lblDiscountL.Size = new System.Drawing.Size(200, 25);
            this.lblDiscountL.TabIndex = 4;
            this.lblDiscountL.Text = "Discount";
            // 
            // lblSubtotalV
            // 
            this.lblSubtotalV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotalV.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotalV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtotalV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSubtotalV.Location = new System.Drawing.Point(420, 16);
            this.lblSubtotalV.Name = "lblSubtotalV";
            this.lblSubtotalV.Size = new System.Drawing.Size(160, 25);
            this.lblSubtotalV.TabIndex = 5;
            this.lblSubtotalV.Text = "$0.00";
            this.lblSubtotalV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotalL
            // 
            this.lblSubtotalL.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotalL.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtotalL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblSubtotalL.Location = new System.Drawing.Point(20, 16);
            this.lblSubtotalL.Name = "lblSubtotalL";
            this.lblSubtotalL.Size = new System.Drawing.Size(200, 25);
            this.lblSubtotalL.TabIndex = 6;
            this.lblSubtotalL.Text = "Subtotal";
            // 
            // pnlReceiptHeader
            // 
            this.pnlReceiptHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pnlReceiptHeader.Controls.Add(this.lblReceiptOrderId);
            this.pnlReceiptHeader.Controls.Add(this.lblReceiptMeta);
            this.pnlReceiptHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReceiptHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlReceiptHeader.Name = "pnlReceiptHeader";
            this.pnlReceiptHeader.Padding = new System.Windows.Forms.Padding(20, 13, 20, 13);
            this.pnlReceiptHeader.Size = new System.Drawing.Size(604, 84);
            this.pnlReceiptHeader.TabIndex = 2;
            // 
            // lblReceiptOrderId
            // 
            this.lblReceiptOrderId.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiptOrderId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiptOrderId.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblReceiptOrderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblReceiptOrderId.Location = new System.Drawing.Point(20, 38);
            this.lblReceiptOrderId.Name = "lblReceiptOrderId";
            this.lblReceiptOrderId.Size = new System.Drawing.Size(564, 38);
            this.lblReceiptOrderId.TabIndex = 0;
            this.lblReceiptOrderId.Text = "Select an order";
            // 
            // lblReceiptMeta
            // 
            this.lblReceiptMeta.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiptMeta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiptMeta.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblReceiptMeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblReceiptMeta.Location = new System.Drawing.Point(20, 13);
            this.lblReceiptMeta.Name = "lblReceiptMeta";
            this.lblReceiptMeta.Size = new System.Drawing.Size(564, 25);
            this.lblReceiptMeta.TabIndex = 1;
            this.lblReceiptMeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Name = "UCOrders";
            this.Size = new System.Drawing.Size(1920, 1133);
            this.Load += new System.EventHandler(this.UCOrders_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlHeaders.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlReceiptWrap.ResumeLayout(false);
            this.pnlReceiptFooter.ResumeLayout(false);
            this.pnlPrintWrap.ResumeLayout(false);
            this.pnlReceiptHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // ── Left ─────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilterDate;
        private CustomControls.RJControls.RJDatePicker dtpFrom;
        private CustomControls.RJControls.RJDatePicker dtpTo;
        private System.Windows.Forms.Label lblFilterWaiter;
        private CustomControls.RJControls.RJComboBox cmbWaiter;
        private CustomControls.RJControls.RJButton btnFilter;
        private CustomControls.RJControls.RJButton btnClear;
        private System.Windows.Forms.Panel pnlHeaders;
        private System.Windows.Forms.Label lblHOrderId;
        private System.Windows.Forms.Label lblHType;
        private System.Windows.Forms.Label lblHTable;
        private System.Windows.Forms.Label lblHServedBy;
        private System.Windows.Forms.Label lblHDateTime;
        private System.Windows.Forms.Label lblHTotal;
        private SmoothFlowPanel flowOrders;

        // ── Right ─────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlRight;
        private CustomControls.RJControls.RJPanel pnlReceiptWrap;
        private System.Windows.Forms.Panel pnlReceiptHeader;
        private System.Windows.Forms.Label lblReceiptOrderId;
        private System.Windows.Forms.Label lblReceiptMeta;
        private SmoothFlowPanel flowReceiptItems;
        private System.Windows.Forms.Panel pnlReceiptFooter;
        private System.Windows.Forms.Label lblSubtotalL;
        private System.Windows.Forms.Label lblSubtotalV;
        private System.Windows.Forms.Label lblDiscountL;
        private System.Windows.Forms.Label lblDiscountV;
        private System.Windows.Forms.Label lblTotalL;
        private System.Windows.Forms.Label lblTotalV;
        private CustomControls.RJControls.RJgradiantPanal pnlPrintWrap;
        private CustomControls.RJControls.RJButton btnPrint;
        private CustomControls.RJControls.RJPanel pnlFilters;
        private System.Windows.Forms.Panel panel1;
    }
}