namespace LaCucina
{
    partial class UCManagerItemCard
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
            this.btnDelete = new CustomControls.RJControls.RJButton();
            this.btnEdit = new CustomControls.RJControls.RJButton();
            this.lblName = new System.Windows.Forms.Label();
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.rjPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.rjPanel1.BorderRadius = 15;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.lblPrice);
            this.rjPanel1.Controls.Add(this.btnDelete);
            this.rjPanel1.Controls.Add(this.btnEdit);
            this.rjPanel1.Controls.Add(this.lblName);
            this.rjPanel1.Controls.Add(this.picboxImage);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(0, 0);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(345, 385);
            this.rjPanel1.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(171)))), ((int)(((byte)(68)))));
            this.lblPrice.Location = new System.Drawing.Point(42, 278);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(60, 28);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "15.50";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Image = global::LaCucina.Properties.Resources.delete__1_;
            this.btnDelete.Location = new System.Drawing.Point(286, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 52);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.TextColor = System.Drawing.Color.Transparent;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 15;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit.Image = global::LaCucina.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(231, 317);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 52);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.TextColor = System.Drawing.Color.Transparent;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(39, 240);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(277, 31);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Double Cheese Burger";
            // 
            // picboxImage
            // 
            this.picboxImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.picboxImage.Image = global::LaCucina.Properties.Resources.برجر_4png;
            this.picboxImage.Location = new System.Drawing.Point(0, 0);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(345, 197);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxImage.TabIndex = 0;
            this.picboxImage.TabStop = false;
            // 
            // UCManagerItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.rjPanel1);
            this.Margin = new System.Windows.Forms.Padding(16, 17, 16, 17);
            this.Name = "UCManagerItemCard";
            this.Size = new System.Drawing.Size(345, 385);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox picboxImage;
        private System.Windows.Forms.Label lblName;
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJButton btnEdit;
    }
}
