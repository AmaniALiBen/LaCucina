namespace LaCucina
{
    partial class KDS
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
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.rjPanel2 = new CustomControls.RJControls.RJPanel();
            this.btnClose = new CustomControls.RJControls.RJButton();
            this.rjPanel3 = new CustomControls.RJControls.RJPanel();
            this.rjPanel4 = new CustomControls.RJControls.RJPanel();
            this.smoothFlowPanel1 = new SmoothFlowPanel();
            this.rjButton6 = new CustomControls.RJControls.RJButton();
            this.rjPanel1.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            this.rjPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 15;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.rjButton6);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(10, 10);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(152, 430);
            this.rjPanel1.TabIndex = 0;
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.rjPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel2.BorderRadius = 15;
            this.rjPanel2.BorderSize = 0;
            this.rjPanel2.Controls.Add(this.btnClose);
            this.rjPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjPanel2.ForeColor = System.Drawing.Color.Black;
            this.rjPanel2.Location = new System.Drawing.Point(162, 10);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(628, 24);
            this.rjPanel2.TabIndex = 2;
            this.rjPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel2_Paint);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::LaCucina.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(603, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 24);
            this.btnClose.TabIndex = 15;
            this.btnClose.TextColor = System.Drawing.Color.Transparent;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // rjPanel3
            // 
            this.rjPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.rjPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel3.BorderRadius = 15;
            this.rjPanel3.BorderSize = 0;
            this.rjPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjPanel3.ForeColor = System.Drawing.Color.Black;
            this.rjPanel3.Location = new System.Drawing.Point(162, 34);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(12, 406);
            this.rjPanel3.TabIndex = 3;
            // 
            // rjPanel4
            // 
            this.rjPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.rjPanel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel4.BorderRadius = 15;
            this.rjPanel4.BorderSize = 0;
            this.rjPanel4.Controls.Add(this.smoothFlowPanel1);
            this.rjPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjPanel4.ForeColor = System.Drawing.Color.Black;
            this.rjPanel4.Location = new System.Drawing.Point(174, 34);
            this.rjPanel4.Name = "rjPanel4";
            this.rjPanel4.Size = new System.Drawing.Size(616, 406);
            this.rjPanel4.TabIndex = 3;
            // 
            // smoothFlowPanel1
            // 
            this.smoothFlowPanel1.AutoScroll = true;
            this.smoothFlowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smoothFlowPanel1.Location = new System.Drawing.Point(0, 0);
            this.smoothFlowPanel1.Name = "smoothFlowPanel1";
            this.smoothFlowPanel1.Size = new System.Drawing.Size(616, 406);
            this.smoothFlowPanel1.TabIndex = 0;
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rjButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 13;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.rjButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton6.Location = new System.Drawing.Point(22, 15);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(114, 37);
            this.rjButton6.TabIndex = 1;
            this.rjButton6.Text = "PAY and PRINT";
            this.rjButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton6.UseVisualStyleBackColor = false;
            this.rjButton6.Click += new System.EventHandler(this.rjButton6_Click);
            // 
            // KDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rjPanel4);
            this.Controls.Add(this.rjPanel3);
            this.Controls.Add(this.rjPanel2);
            this.Controls.Add(this.rjPanel1);
            this.Name = "KDS";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "KDS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel1;
        private CustomControls.RJControls.RJPanel rjPanel2;
        private CustomControls.RJControls.RJPanel rjPanel3;
        private CustomControls.RJControls.RJPanel rjPanel4;
        private CustomControls.RJControls.RJButton btnClose;
        private SmoothFlowPanel smoothFlowPanel1;
        private CustomControls.RJControls.RJButton rjButton6;
    }
}