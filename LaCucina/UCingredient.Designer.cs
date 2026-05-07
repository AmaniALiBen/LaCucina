namespace LaCucina
{
    partial class UCIngredient
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
            this.pnlIngredient = new CustomControls.RJControls.RJPanel();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.btnRemoveIngredient = new CustomControls.RJControls.RJButton();
            this.pnlIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIngredient
            // 
            this.pnlIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlIngredient.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlIngredient.BorderRadius = 6;
            this.pnlIngredient.BorderSize = 0;
            this.pnlIngredient.Controls.Add(this.btnRemoveIngredient);
            this.pnlIngredient.Controls.Add(this.lblIngredient);
            this.pnlIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIngredient.ForeColor = System.Drawing.Color.Black;
            this.pnlIngredient.Location = new System.Drawing.Point(0, 5);
            this.pnlIngredient.Name = "pnlIngredient";
            this.pnlIngredient.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlIngredient.Size = new System.Drawing.Size(590, 55);
            this.pnlIngredient.TabIndex = 0;
            this.pnlIngredient.Click += new System.EventHandler(this.pnlIngredient_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblIngredient.Location = new System.Drawing.Point(21, 11);
            this.lblIngredient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(71, 25);
            this.lblIngredient.TabIndex = 10;
            this.lblIngredient.Text = "tomato";
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
            this.btnRemoveIngredient.Image = global::LaCucina.Properties.Resources.icons8_delete_16;
            this.btnRemoveIngredient.Location = new System.Drawing.Point(546, 8);
            this.btnRemoveIngredient.Name = "btnRemoveIngredient";
            this.btnRemoveIngredient.Size = new System.Drawing.Size(41, 40);
            this.btnRemoveIngredient.TabIndex = 12;
            this.btnRemoveIngredient.TextColor = System.Drawing.Color.White;
            this.btnRemoveIngredient.UseVisualStyleBackColor = false;
            this.btnRemoveIngredient.Click += new System.EventHandler(this.btnRemoveIngredient_Click);
            // 
            // UCIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.pnlIngredient);
            this.Name = "UCIngredient";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.Size = new System.Drawing.Size(600, 65);
            this.pnlIngredient.ResumeLayout(false);
            this.pnlIngredient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel pnlIngredient;
        private System.Windows.Forms.Label lblIngredient;
        private CustomControls.RJControls.RJButton btnRemoveIngredient;
    }
}
