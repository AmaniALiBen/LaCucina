namespace LaCucina
{
    partial class UCSpaceRow
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
            this.pnlRow = new CustomControls.RJControls.RJPanel();
            this.btnEdit = new CustomControls.RJControls.RJButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new CustomControls.RJControls.RJButton();
            this.pnlRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRow
            // 
            this.pnlRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlRow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlRow.BorderRadius = 10;
            this.pnlRow.BorderSize = 0;
            this.pnlRow.Controls.Add(this.btnEdit);
            this.pnlRow.Controls.Add(this.lblName);
            this.pnlRow.Controls.Add(this.btnDelete);
            this.pnlRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlRow.Location = new System.Drawing.Point(0, 0);
            this.pnlRow.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRow.Name = "pnlRow";
            this.pnlRow.Size = new System.Drawing.Size(456, 47);
            this.pnlRow.TabIndex = 29;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::LaCucina.Properties.Resources.edit__1_;
            this.btnEdit.Location = new System.Drawing.Point(370, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(33, 32);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblName.Location = new System.Drawing.Point(18, 10);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 26);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Floor 1";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::LaCucina.Properties.Resources.delete__2_;
            this.btnDelete.Location = new System.Drawing.Point(333, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(33, 32);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UCSpaceRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.pnlRow);
            this.Name = "UCSpaceRow";
            this.Size = new System.Drawing.Size(456, 47);
            this.pnlRow.ResumeLayout(false);
            this.pnlRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel pnlRow;
        private CustomControls.RJControls.RJButton btnEdit;
        private System.Windows.Forms.Label lblName;
        private CustomControls.RJControls.RJButton btnDelete;
    }
}
