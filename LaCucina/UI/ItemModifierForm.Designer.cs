namespace LaCucina.UI
{
    partial class ItemModifierForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new CustomControls.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::LaCucina.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(500, -2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 38);
            this.btnClose.TabIndex = 15;
            this.btnClose.TextColor = System.Drawing.Color.Transparent;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(80, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // picboxImage
            // 
            this.picboxImage.Image = global::LaCucina.Properties.Resources.برجر_4png;
            this.picboxImage.Location = new System.Drawing.Point(31, 0);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(224, 165);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxImage.TabIndex = 18;
            this.picboxImage.TabStop = false;
            this.picboxImage.Click += new System.EventHandler(this.picboxImage_Click);
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 15;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.picboxImage);
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(175, 245);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(286, 165);
            this.rjPanel1.TabIndex = 19;
            // 
            // ItemModifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(533, 664);
            this.ControlBox = false;
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Name = "ItemModifierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ItemModifierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.rjPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picboxImage;
        private CustomControls.RJControls.RJPanel rjPanel1;
    }
}