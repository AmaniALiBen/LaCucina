//namespace LaCucina.UI
//{
//    partial class UCOrderRow
//    {
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//                components.Dispose();
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            this.lblOrderId = new System.Windows.Forms.Label();
//            this.lblType = new System.Windows.Forms.Label();
//            this.lblTable = new System.Windows.Forms.Label();
//            this.lblServedBy = new System.Windows.Forms.Label();
//            this.lblDateTime = new System.Windows.Forms.Label();
//            this.pnlStatus = new System.Windows.Forms.Panel();
//            this.lblStatus = new System.Windows.Forms.Label();
//            this.lblTotal = new System.Windows.Forms.Label();
//            this.pnlStatus.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // lblOrderId
//            // 
//            this.lblOrderId.BackColor = System.Drawing.Color.Transparent;
//            this.lblOrderId.Font = new System.Drawing.Font("Yu Gothic", 10F);
//            this.lblOrderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
//            this.lblOrderId.Location = new System.Drawing.Point(26, 0);
//            this.lblOrderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblOrderId.Name = "lblOrderId";
//            this.lblOrderId.Size = new System.Drawing.Size(154, 61);
//            this.lblOrderId.TabIndex = 0;
//            this.lblOrderId.Text = "#000000";
//            this.lblOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // lblType
//            // 
//            this.lblType.BackColor = System.Drawing.Color.Transparent;
//            this.lblType.Font = new System.Drawing.Font("Yu Gothic", 10F);
//            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
//            this.lblType.Location = new System.Drawing.Point(206, 0);
//            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblType.Name = "lblType";
//            this.lblType.Size = new System.Drawing.Size(129, 61);
//            this.lblType.TabIndex = 1;
//            this.lblType.Text = "Dine-in";
//            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // lblTable
//            // 
//            this.lblTable.BackColor = System.Drawing.Color.Transparent;
//            this.lblTable.Font = new System.Drawing.Font("Yu Gothic", 10F);
//            this.lblTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
//            this.lblTable.Location = new System.Drawing.Point(347, 0);
//            this.lblTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblTable.Name = "lblTable";
//            this.lblTable.Size = new System.Drawing.Size(154, 61);
//            this.lblTable.TabIndex = 2;
//            this.lblTable.Text = "T-00";
//            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // lblServedBy
//            // 
//            this.lblServedBy.BackColor = System.Drawing.Color.Transparent;
//            this.lblServedBy.Font = new System.Drawing.Font("Yu Gothic", 10F);
//            this.lblServedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
//            this.lblServedBy.Location = new System.Drawing.Point(514, 0);
//            this.lblServedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblServedBy.Name = "lblServedBy";
//            this.lblServedBy.Size = new System.Drawing.Size(193, 61);
//            this.lblServedBy.TabIndex = 3;
//            this.lblServedBy.Text = "Waiter";
//            this.lblServedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // lblDateTime
//            // 
//            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
//            this.lblDateTime.Font = new System.Drawing.Font("Yu Gothic", 10F);
//            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
//            this.lblDateTime.Location = new System.Drawing.Point(720, 0);
//            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblDateTime.Name = "lblDateTime";
//            this.lblDateTime.Size = new System.Drawing.Size(231, 61);
//            this.lblDateTime.TabIndex = 4;
//            this.lblDateTime.Text = "00:00 0000-00-00";
//            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // pnlStatus
//            // 
//            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(60)))));
//            this.pnlStatus.Controls.Add(this.lblStatus);
//            this.pnlStatus.Location = new System.Drawing.Point(977, 15);
//            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.pnlStatus.Name = "pnlStatus";
//            this.pnlStatus.Size = new System.Drawing.Size(103, 30);
//            this.pnlStatus.TabIndex = 5;
//            // 
//            // lblStatus
//            // 
//            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
//            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.lblStatus.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Bold);
//            this.lblStatus.ForeColor = System.Drawing.Color.White;
//            this.lblStatus.Location = new System.Drawing.Point(0, 0);
//            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblStatus.Name = "lblStatus";
//            this.lblStatus.Size = new System.Drawing.Size(103, 30);
//            this.lblStatus.TabIndex = 0;
//            this.lblStatus.Text = "Closed";
//            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // lblTotal
//            // 
//            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
//            this.lblTotal.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
//            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
//            this.lblTotal.Location = new System.Drawing.Point(1119, 0);
//            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblTotal.Name = "lblTotal";
//            this.lblTotal.Size = new System.Drawing.Size(154, 61);
//            this.lblTotal.TabIndex = 6;
//            this.lblTotal.Text = "$0.00";
//            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // UCOrderRow
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
//            this.Controls.Add(this.lblOrderId);
//            this.Controls.Add(this.lblType);
//            this.Controls.Add(this.lblTable);
//            this.Controls.Add(this.lblServedBy);
//            this.Controls.Add(this.lblDateTime);
//            this.Controls.Add(this.pnlStatus);
//            this.Controls.Add(this.lblTotal);
//            this.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.Name = "UCOrderRow";
//            this.Size = new System.Drawing.Size(1404, 61);
//            this.Load += new System.EventHandler(this.UCOrderRow_Load);
//            this.pnlStatus.ResumeLayout(false);
//            this.ResumeLayout(false);

//        }

//        private System.Windows.Forms.Label lblOrderId;
//        private System.Windows.Forms.Label lblType;
//        private System.Windows.Forms.Label lblTable;
//        private System.Windows.Forms.Label lblServedBy;
//        private System.Windows.Forms.Label lblDateTime;
//        private System.Windows.Forms.Panel pnlStatus;
//        private System.Windows.Forms.Label lblStatus;
//        private System.Windows.Forms.Label lblTotal;
//    }
//}

namespace LaCucina.UI
{
    partial class UCOrderRow
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblServedBy = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            this.lblOrderId.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderId.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOrderId.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblOrderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblOrderId.Location = new System.Drawing.Point(20, 0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(120, 61);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "#000000";
            this.lblOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblType.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblType.Location = new System.Drawing.Point(140, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(110, 61);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Dine-in";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTable
            // 
            this.lblTable.BackColor = System.Drawing.Color.Transparent;
            this.lblTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTable.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblTable.Location = new System.Drawing.Point(250, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(100, 61);
            this.lblTable.TabIndex = 2;
            this.lblTable.Text = "T-00";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServedBy
            // 
            this.lblServedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblServedBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblServedBy.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblServedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblServedBy.Location = new System.Drawing.Point(350, 0);
            this.lblServedBy.Name = "lblServedBy";
            this.lblServedBy.Size = new System.Drawing.Size(150, 61);
            this.lblServedBy.TabIndex = 3;
            this.lblServedBy.Text = "Waiter";
            this.lblServedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateTime.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblDateTime.Location = new System.Drawing.Point(500, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDateTime.Size = new System.Drawing.Size(569, 61);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "00:00 2026-05-29";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTotal.Location = new System.Drawing.Point(1069, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(315, 61);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCOrderRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblServedBy);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblOrderId);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCOrderRow";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Size = new System.Drawing.Size(1404, 61);
            this.Load += new System.EventHandler(this.UCOrderRow_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblServedBy;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTotal;
    }
}
