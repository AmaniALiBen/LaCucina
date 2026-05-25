namespace LaCucina
{
    partial class UCIngredientInItem
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
            this.btnRemoveIngredient = new CustomControls.RJControls.RJButton();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 6;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.btnRemoveIngredient);
            this.rjPanel1.Controls.Add(this.lblIngredient);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(0, 5);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.rjPanel1.Size = new System.Drawing.Size(455, 55);
            this.rjPanel1.TabIndex = 1;
            // 
            // btnRemoveIngredient
            // 
            this.btnRemoveIngredient.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveIngredient.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRemoveIngredient.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemoveIngredient.BorderRadius = 15;
            this.btnRemoveIngredient.BorderSize = 0;
            this.btnRemoveIngredient.FlatAppearance.BorderSize = 0;
            this.btnRemoveIngredient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRemoveIngredient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRemoveIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveIngredient.ForeColor = System.Drawing.Color.White;
            this.btnRemoveIngredient.Image = global::LaCucina.Properties.Resources.icons8_cancel_16__2_;
            this.btnRemoveIngredient.Location = new System.Drawing.Point(403, 8);
            this.btnRemoveIngredient.Name = "btnRemoveIngredient";
            this.btnRemoveIngredient.Size = new System.Drawing.Size(41, 40);
            this.btnRemoveIngredient.TabIndex = 11;
            this.btnRemoveIngredient.TextColor = System.Drawing.Color.White;
            this.btnRemoveIngredient.UseVisualStyleBackColor = false;
            this.btnRemoveIngredient.Click += new System.EventHandler(this.btnRemoveIngredient_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblIngredient.Location = new System.Drawing.Point(21, 14);
            this.lblIngredient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(71, 25);
            this.lblIngredient.TabIndex = 10;
            this.lblIngredient.Text = "tomato";
            // 
            // UCIngredientInItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.rjPanel1);
            this.Name = "UCIngredientInItem";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.Size = new System.Drawing.Size(460, 65);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.Label lblIngredient;
        private CustomControls.RJControls.RJButton btnRemoveIngredient;
    }
}
