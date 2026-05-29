namespace LaCucina.UI
{
    partial class UCOrderItemRow
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlModifiers = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNote = new System.Windows.Forms.Panel();
            this.lblNote = new System.Windows.Forms.Label();
            this.pnlNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblQuantity.Location = new System.Drawing.Point(13, 13);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(36, 30);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "1";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblName.Location = new System.Drawing.Point(57, 13);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(437, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Item Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblPrice.Location = new System.Drawing.Point(430, 13);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(130, 30);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "$0.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlModifiers
            // 
            this.pnlModifiers.AutoSize = true;
            this.pnlModifiers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlModifiers.BackColor = System.Drawing.Color.Transparent;
            this.pnlModifiers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlModifiers.Location = new System.Drawing.Point(57, 46);
            this.pnlModifiers.Margin = new System.Windows.Forms.Padding(0);
            this.pnlModifiers.Name = "pnlModifiers";
            this.pnlModifiers.Size = new System.Drawing.Size(0, 0);
            this.pnlModifiers.TabIndex = 3;
            this.pnlModifiers.WrapContents = false;
            // 
            // pnlNote
            // 
            this.pnlNote.AutoSize = true;
            this.pnlNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNote.BackColor = System.Drawing.Color.Transparent;
            this.pnlNote.Controls.Add(this.lblNote);
            this.pnlNote.Location = new System.Drawing.Point(0, 0);
            this.pnlNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(4, 28);
            this.pnlNote.TabIndex = 4;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Yu Gothic", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(128)))), ((int)(((byte)(16)))));
            this.lblNote.Location = new System.Drawing.Point(0, 0);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblNote.Size = new System.Drawing.Size(0, 28);
            this.lblNote.TabIndex = 0;
            // 
            // UCOrderItemRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pnlModifiers);
            this.Controls.Add(this.pnlNote);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(560, 56);
            this.Name = "UCOrderItemRow";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Size = new System.Drawing.Size(640, 56);
            this.pnlNote.ResumeLayout(false);
            this.pnlNote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.FlowLayoutPanel pnlModifiers;
        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.Label lblNote;
    }
}
