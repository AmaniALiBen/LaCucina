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

            // ── lblQuantity ──────────────────────────────────────────────
            this.lblQuantity.AutoSize = false;
            this.lblQuantity.Location = new System.Drawing.Point(10, 10);
            this.lblQuantity.Size = new System.Drawing.Size(28, 24);
            this.lblQuantity.Font = new System.Drawing.Font("Yu Gothic", 9f);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuantity.Text = "1";

            // ── lblName ──────────────────────────────────────────────────
            this.lblName.AutoSize = false;
            this.lblName.Location = new System.Drawing.Point(44, 10);
            this.lblName.Size = new System.Drawing.Size(340, 24);
            this.lblName.Font = new System.Drawing.Font("Yu Gothic", 9f);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Text = "Item Name";

            // ── lblPrice ─────────────────────────────────────────────────
            this.lblPrice.AutoSize = false;
            this.lblPrice.Location = new System.Drawing.Point(394, 10);
            this.lblPrice.Size = new System.Drawing.Size(100, 24);
            this.lblPrice.Font = new System.Drawing.Font("Yu Gothic", 9f);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Text = "$0.00";

            // ── pnlModifiers ─────────────────────────────────────────────
            this.pnlModifiers.Location = new System.Drawing.Point(44, 36);
            this.pnlModifiers.Size = new System.Drawing.Size(450, 0);
            this.pnlModifiers.AutoSize = true;
            this.pnlModifiers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlModifiers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlModifiers.WrapContents = false;
            this.pnlModifiers.BackColor = System.Drawing.Color.Transparent;
            this.pnlModifiers.Padding = new System.Windows.Forms.Padding(0);
            this.pnlModifiers.Margin = new System.Windows.Forms.Padding(0);

            // ── pnlNote ──────────────────────────────────────────────────
            this.pnlNote.AutoSize = true;
            this.pnlNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNote.BackColor = System.Drawing.Color.Transparent;
            this.pnlNote.Padding = new System.Windows.Forms.Padding(0);
            this.pnlNote.Controls.Add(this.lblNote);

            // ── lblNote ──────────────────────────────────────────────────
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Yu Gothic", 8.5f, System.Drawing.FontStyle.Italic);
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(239, 128, 16);
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblNote.Text = "";

            // ── UCOrderItemRow ───────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.MinimumSize = new System.Drawing.Size(500, 44);
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.lblQuantity,
                this.lblName,
                this.lblPrice,
                this.pnlModifiers,
                this.pnlNote
            });

            this.pnlNote.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.FlowLayoutPanel pnlModifiers;
        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.Label lblNote;
    }
}
