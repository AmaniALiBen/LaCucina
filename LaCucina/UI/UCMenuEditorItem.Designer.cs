namespace LaCucina
{
    partial class UCMenuEditorItem
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.rjToggleButton1 = new CustomControls.RJControls.RJToggleButton();
            this.lblName = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.rjPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 15;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.lblStatus);
            this.rjPanel1.Controls.Add(this.rjToggleButton1);
            this.rjPanel1.Controls.Add(this.lblName);
            this.rjPanel1.Controls.Add(this.picItem);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(0, 0);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(345, 374);
            this.rjPanel1.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.Silver;
            this.lblStatus.Location = new System.Drawing.Point(168, 296);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(16, 17, 16, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(105, 29);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Available";
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(128)))), ((int)(((byte)(16)))));
            this.rjToggleButton1.Checked = true;
            this.rjToggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjToggleButton1.Location = new System.Drawing.Point(71, 296);
            this.rjToggleButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(68, 34);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.Size = new System.Drawing.Size(68, 34);
            this.rjToggleButton1.TabIndex = 5;
            this.rjToggleButton1.UseVisualStyleBackColor = false;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(70, 218);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(203, 29);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "CHEESE BURGER";
            // 
            // picItem
            // 
            this.picItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.picItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.picItem.Image = global::LaCucina.Properties.Resources.برجر3;
            this.picItem.Location = new System.Drawing.Point(0, 0);
            this.picItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(345, 197);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem.TabIndex = 3;
            this.picItem.TabStop = false;
            // 
            // UCMenuEditorItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rjPanel1);
            this.Margin = new System.Windows.Forms.Padding(16, 17, 16, 17);
            this.Name = "UCMenuEditorItem";
            this.Size = new System.Drawing.Size(345, 374);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.PictureBox picItem;
        private CustomControls.RJControls.RJToggleButton rjToggleButton1;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblName;
    }
}
