namespace LaCucina
{
    partial class UCbtnAddItem
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
            this.btnAdd = new CustomControls.RJControls.RJButton();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.rjPanel1.BorderRadius = 15;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.btnAdd);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(0, 0);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.rjPanel1.Size = new System.Drawing.Size(230, 250);
            this.rjPanel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.Gray;
            this.btnAdd.Image = global::LaCucina.Properties.Resources.file;
            this.btnAdd.Location = new System.Drawing.Point(2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 246);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New Item";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextColor = System.Drawing.Color.Gray;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // UCbtnAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rjPanel1);
            this.Margin = new System.Windows.Forms.Padding(11);
            this.Name = "UCbtnAddItem";
            this.Size = new System.Drawing.Size(230, 250);
            this.rjPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel1;
        private CustomControls.RJControls.RJButton btnAdd;
    }
}
