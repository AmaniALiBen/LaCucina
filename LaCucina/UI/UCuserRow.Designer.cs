namespace LaCucina
{
    partial class UCuserRow
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblUserName.Location = new System.Drawing.Point(135, 26);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(117, 29);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "Amani_AB";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblRole.Location = new System.Drawing.Point(548, 26);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(78, 29);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "Admin";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.BackColor = System.Drawing.Color.Transparent;
            this.lblIsActive.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.lblIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblIsActive.Location = new System.Drawing.Point(922, 26);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(75, 29);
            this.lblIsActive.TabIndex = 15;
            this.lblIsActive.Text = "Active";
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 10;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.lblIsActive);
            this.rjPanel1.Controls.Add(this.lblRole);
            this.rjPanel1.Controls.Add(this.lblUserName);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(0, 0);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(1180, 72);
            this.rjPanel1.TabIndex = 0;
            this.rjPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel1_Paint);
            // 
            // UCuserRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rjPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCuserRow";
            this.Size = new System.Drawing.Size(1180, 72);
            this.Load += new System.EventHandler(this.UCuserRow_Load);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblIsActive;
        public CustomControls.RJControls.RJPanel rjPanel1;
    }
}
