namespace LaCucina
{
    partial class UC_ProductCard
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
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.rjPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 15;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.lblPrice);
            this.rjPanel1.Controls.Add(this.lblName);
            this.rjPanel1.Controls.Add(this.picBox);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(0, 0);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(230, 220);
            this.rjPanel1.TabIndex = 3;
            this.rjPanel1.Click += new System.EventHandler(this.rjPanel1_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(171)))), ((int)(((byte)(68)))));
            this.lblPrice.Location = new System.Drawing.Point(26, 176);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 19);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "15.50";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(25, 146);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(183, 21);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Double Cheese Burger";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.picBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBox.Image = global::LaCucina.Properties.Resources.برجر_4png;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(230, 128);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // UC_ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rjPanel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UC_ProductCard";
            this.Size = new System.Drawing.Size(230, 220);
            this.Load += new System.EventHandler(this.UC_ProductCard_Load);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel1;
        public System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
    }
}
