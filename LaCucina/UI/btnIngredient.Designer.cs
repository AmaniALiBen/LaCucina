namespace LaCucina.UI
{
    partial class btnIngredient
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
            this.lblIngName = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lblIngName
            // 
            this.lblIngName.AutoSize = true;
            this.lblIngName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblIngName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblIngName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblIngName.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblIngName.BorderRadius = 17;
            this.lblIngName.BorderSize = 0;
            this.lblIngName.FlatAppearance.BorderSize = 0;
            this.lblIngName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lblIngName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lblIngName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIngName.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblIngName.ForeColor = System.Drawing.Color.Gray;
            this.lblIngName.Image = global::LaCucina.Properties.Resources.icons8_check_24;
            this.lblIngName.Location = new System.Drawing.Point(2, 2);
            this.lblIngName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblIngName.Name = "lblIngName";
            this.lblIngName.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblIngName.Size = new System.Drawing.Size(83, 36);
            this.lblIngName.TabIndex = 2;
            this.lblIngName.Text = "Beef ";
            this.lblIngName.TextColor = System.Drawing.Color.Gray;
            this.lblIngName.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lblIngName.UseVisualStyleBackColor = false;
            // 
            // btnIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblIngName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "btnIngredient";
            this.Size = new System.Drawing.Size(87, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton lblIngName;
    }
}
