namespace LaCucina.UI
{
    partial class UCBatchCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlContiner = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.orderTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlBatchItems = new SmoothFlowPanel();
            this.pnlContiner.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContiner
            // 
            this.pnlContiner.AutoSize = true;
            this.pnlContiner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContiner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlContiner.Controls.Add(this.pnlBatchItems);
            this.pnlContiner.Controls.Add(this.pnlHeader);
            this.pnlContiner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContiner.Location = new System.Drawing.Point(0, 0);
            this.pnlContiner.MinimumSize = new System.Drawing.Size(375, 0);
            this.pnlContiner.Name = "pnlContiner";
            this.pnlContiner.Padding = new System.Windows.Forms.Padding(0, 0, 20, 40);
            this.pnlContiner.Size = new System.Drawing.Size(395, 102);
            this.pnlContiner.TabIndex = 3;
            this.pnlContiner.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContiner_Paint);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlHeader.Controls.Add(this.panel1);
            this.pnlHeader.Controls.Add(this.pnlColor);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(375, 62);
            this.pnlHeader.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.lblTable);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblOrderId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 14);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(375, 48);
            this.panel1.TabIndex = 7;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTable.Location = new System.Drawing.Point(14, 10);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(104, 32);
            this.lblTable.TabIndex = 2;
            this.lblTable.Text = "Table 22";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(289, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 21);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "-";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.ForeColor = System.Drawing.Color.DimGray;
            this.lblOrderId.Location = new System.Drawing.Point(124, 10);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(74, 32);
            this.lblOrderId.TabIndex = 3;
            this.lblOrderId.Text = "#1212";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.DarkGray;
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlColor.Location = new System.Drawing.Point(0, 0);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(375, 14);
            this.pnlColor.TabIndex = 5;
            // 
            // orderTimer
            // 
            this.orderTimer.Enabled = true;
            this.orderTimer.Interval = 1000;
            this.orderTimer.Tick += new System.EventHandler(this.orderTimer_Tick);
            // 
            // pnlBatchItems
            // 
            this.pnlBatchItems.AutoSize = true;
            this.pnlBatchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlBatchItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBatchItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlBatchItems.Location = new System.Drawing.Point(0, 62);
            this.pnlBatchItems.MinimumSize = new System.Drawing.Size(375, 0);
            this.pnlBatchItems.Name = "pnlBatchItems";
            this.pnlBatchItems.Size = new System.Drawing.Size(375, 0);
            this.pnlBatchItems.TabIndex = 5;
            this.pnlBatchItems.WrapContents = false;
            // 
            // UCBatchCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.pnlContiner);
            this.MinimumSize = new System.Drawing.Size(395, 0);
            this.Name = "UCBatchCard";
            this.Size = new System.Drawing.Size(395, 102);
            this.pnlContiner.ResumeLayout(false);
            this.pnlContiner.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlContiner;
        public SmoothFlowPanel pnlBatchItems;
        public System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Timer orderTimer;
    }
}
