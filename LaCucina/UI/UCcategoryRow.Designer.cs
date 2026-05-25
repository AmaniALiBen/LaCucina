namespace LaCucina
{
    partial class UCcategoryRow
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
            this.pnlCategoryRow = new CustomControls.RJControls.RJPanel();
            this.btnEdit = new CustomControls.RJControls.RJButton();
            this.lblcategory = new System.Windows.Forms.Label();
            this.btnDelete = new CustomControls.RJControls.RJButton();
            this.pnlCategoryRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategoryRow
            // 
            this.pnlCategoryRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlCategoryRow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlCategoryRow.BorderRadius = 10;
            this.pnlCategoryRow.BorderSize = 0;
            this.pnlCategoryRow.Controls.Add(this.btnEdit);
            this.pnlCategoryRow.Controls.Add(this.lblcategory);
            this.pnlCategoryRow.Controls.Add(this.btnDelete);
            this.pnlCategoryRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategoryRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlCategoryRow.Location = new System.Drawing.Point(0, 0);
            this.pnlCategoryRow.Name = "pnlCategoryRow";
            this.pnlCategoryRow.Size = new System.Drawing.Size(304, 32);
            this.pnlCategoryRow.TabIndex = 31;
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
            this.btnEdit.Location = new System.Drawing.Point(247, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(22, 22);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblcategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblcategory.Location = new System.Drawing.Point(12, 7);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(52, 18);
            this.lblcategory.TabIndex = 5;
            this.lblcategory.Text = "Burger";
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
            this.btnDelete.Location = new System.Drawing.Point(222, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(22, 22);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UCcategoryRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlCategoryRow);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.Name = "UCcategoryRow";
            this.Size = new System.Drawing.Size(304, 32);
            this.pnlCategoryRow.ResumeLayout(false);
            this.pnlCategoryRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblcategory;
        public CustomControls.RJControls.RJButton btnEdit;
        public CustomControls.RJControls.RJButton btnDelete;
        public CustomControls.RJControls.RJPanel pnlCategoryRow;
    }
}
