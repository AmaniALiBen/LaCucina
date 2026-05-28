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
            this.pnlBatchItems = new SmoothFlowPanel();
            this.ucItemInBatch1 = new LaCucina.UI.UCItemInBatch();
            this.ucItemInBatch2 = new LaCucina.UI.UCItemInBatch();
            this.ucItemInBatch3 = new LaCucina.UI.UCItemInBatch();
            this.pnlContinue = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.orderTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContiner.SuspendLayout();
            this.pnlBatchItems.SuspendLayout();
            this.pnlContinue.SuspendLayout();
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
            this.pnlContiner.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.pnlContiner.Size = new System.Drawing.Size(395, 790);
            this.pnlContiner.TabIndex = 3;
            this.pnlContiner.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContiner_Paint);
            // 
            // pnlBatchItems
            // 
            this.pnlBatchItems.AutoScroll = true;
            this.pnlBatchItems.AutoSize = true;
            this.pnlBatchItems.Controls.Add(this.ucItemInBatch1);
            this.pnlBatchItems.Controls.Add(this.ucItemInBatch2);
            this.pnlBatchItems.Controls.Add(this.ucItemInBatch3);
            this.pnlBatchItems.Controls.Add(this.pnlContinue);
            this.pnlBatchItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBatchItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlBatchItems.Location = new System.Drawing.Point(0, 62);
            this.pnlBatchItems.MinimumSize = new System.Drawing.Size(375, 0);
            this.pnlBatchItems.Name = "pnlBatchItems";
            this.pnlBatchItems.Size = new System.Drawing.Size(375, 708);
            this.pnlBatchItems.TabIndex = 5;
            this.pnlBatchItems.WrapContents = false;
            // 
            // ucItemInBatch1
            // 
            this.ucItemInBatch1.AutoSize = true;
            this.ucItemInBatch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucItemInBatch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ucItemInBatch1.Location = new System.Drawing.Point(3, 3);
            this.ucItemInBatch1.MinimumSize = new System.Drawing.Size(375, 0);
            this.ucItemInBatch1.Name = "ucItemInBatch1";
            this.ucItemInBatch1.Size = new System.Drawing.Size(375, 210);
            this.ucItemInBatch1.TabIndex = 3;
            // 
            // ucItemInBatch2
            // 
            this.ucItemInBatch2.AutoSize = true;
            this.ucItemInBatch2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucItemInBatch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ucItemInBatch2.Location = new System.Drawing.Point(3, 219);
            this.ucItemInBatch2.MinimumSize = new System.Drawing.Size(375, 0);
            this.ucItemInBatch2.Name = "ucItemInBatch2";
            this.ucItemInBatch2.Size = new System.Drawing.Size(375, 210);
            this.ucItemInBatch2.TabIndex = 4;
            // 
            // ucItemInBatch3
            // 
            this.ucItemInBatch3.AutoSize = true;
            this.ucItemInBatch3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucItemInBatch3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ucItemInBatch3.Location = new System.Drawing.Point(3, 435);
            this.ucItemInBatch3.MinimumSize = new System.Drawing.Size(375, 0);
            this.ucItemInBatch3.Name = "ucItemInBatch3";
            this.ucItemInBatch3.Size = new System.Drawing.Size(375, 210);
            this.ucItemInBatch3.TabIndex = 5;
            // 
            // pnlContinue
            // 
            this.pnlContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlContinue.Controls.Add(this.label2);
            this.pnlContinue.Controls.Add(this.label1);
            this.pnlContinue.Controls.Add(this.label3);
            this.pnlContinue.Location = new System.Drawing.Point(3, 651);
            this.pnlContinue.Name = "pnlContinue";
            this.pnlContinue.Size = new System.Drawing.Size(375, 54);
            this.pnlContinue.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Image = global::LaCucina.Properties.Resources.icons8_arrow_24__3_;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(330, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = " ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlColor_Paint);
            // 
            // orderTimer
            // 
            this.orderTimer.Enabled = true;
            this.orderTimer.Interval = 1000;
            this.orderTimer.Tick += new System.EventHandler(this.orderTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Image = global::LaCucina.Properties.Resources.icons8_arrow_24__3_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(177, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(211, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Continue";
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
            this.Size = new System.Drawing.Size(395, 790);
            this.pnlContiner.ResumeLayout(false);
            this.pnlContiner.PerformLayout();
            this.pnlBatchItems.ResumeLayout(false);
            this.pnlBatchItems.PerformLayout();
            this.pnlContinue.ResumeLayout(false);
            this.pnlContinue.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlContiner;
        private SmoothFlowPanel pnlBatchItems;
        private UCItemInBatch ucItemInBatch1;
        private UCItemInBatch ucItemInBatch2;
        private UCItemInBatch ucItemInBatch3;
        private System.Windows.Forms.Panel pnlContinue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Timer orderTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
