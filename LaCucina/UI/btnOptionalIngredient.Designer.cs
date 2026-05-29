namespace LaCucina.UI
{
    partial class btnOptionalIngredient
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
            this.lblIngName = new CustomControls.RJControls.RJRadioButton();
            this.SuspendLayout();
            // 
            // lblIngName
            // 
            this.lblIngName.AutoSize = true;
            this.lblIngName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblIngName.Checked = true;
            this.lblIngName.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblIngName.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblIngName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblIngName.Location = new System.Drawing.Point(3, 3);
            this.lblIngName.MinimumSize = new System.Drawing.Size(0, 22);
            this.lblIngName.Name = "lblIngName";
            this.lblIngName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblIngName.Size = new System.Drawing.Size(135, 30);
            this.lblIngName.TabIndex = 47;
            this.lblIngName.TabStop = true;
            this.lblIngName.Text = "Mayonise";
            this.lblIngName.UnCheckedColor = System.Drawing.Color.Gray;
            this.lblIngName.UseVisualStyleBackColor = false;
            // 
            // btnOptionalIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.lblIngName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "btnOptionalIngredient";
            this.Size = new System.Drawing.Size(141, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJRadioButton lblIngName;
    }
}
