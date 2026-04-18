namespace LaCucina
{
    partial class UCInvoiceCard
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rjPanel2 = new CustomControls.RJControls.RJPanel();
            this.smoothFlowPanel1 = new SmoothFlowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rjPanel3 = new CustomControls.RJControls.RJPanel();
            this.lblTime = new System.Windows.Forms.Label();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.lblTableNum = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.rjPanel2.SuspendLayout();
            this.smoothFlowPanel1.SuspendLayout();
            this.rjPanel3.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.orderTimer_Tick);
            // 
            // rjPanel2
            // 
            this.rjPanel2.AutoSize = true;
            this.rjPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.rjPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.rjPanel2.BorderRadius = 15;
            this.rjPanel2.BorderSize = 2;
            this.rjPanel2.Controls.Add(this.smoothFlowPanel1);
            this.rjPanel2.Controls.Add(this.rjPanel3);
            this.rjPanel2.Controls.Add(this.rjPanel1);
            this.rjPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjPanel2.ForeColor = System.Drawing.Color.Black;
            this.rjPanel2.Location = new System.Drawing.Point(0, 0);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.rjPanel2.Size = new System.Drawing.Size(250, 308);
            this.rjPanel2.TabIndex = 1;
            this.rjPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel2_Paint);
            // 
            // smoothFlowPanel1
            // 
            this.smoothFlowPanel1.AutoScroll = true;
            this.smoothFlowPanel1.AutoSize = true;
            this.smoothFlowPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.smoothFlowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.smoothFlowPanel1.Controls.Add(this.label1);
            this.smoothFlowPanel1.Controls.Add(this.label2);
            this.smoothFlowPanel1.Controls.Add(this.label4);
            this.smoothFlowPanel1.Controls.Add(this.label6);
            this.smoothFlowPanel1.Controls.Add(this.label7);
            this.smoothFlowPanel1.Controls.Add(this.label8);
            this.smoothFlowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smoothFlowPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.smoothFlowPanel1.Location = new System.Drawing.Point(10, 40);
            this.smoothFlowPanel1.Name = "smoothFlowPanel1";
            this.smoothFlowPanel1.Size = new System.Drawing.Size(230, 228);
            this.smoothFlowPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "CHEESE BURGER DOUBLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "FRENCH FRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(10, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "MASHROOM BURGER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(10, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "CHEESE BURGER DOUBLE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(10, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "FRENCH FRICE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label8.Location = new System.Drawing.Point(10, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "MASHROOM BURGER";
            // 
            // rjPanel3
            // 
            this.rjPanel3.AutoSize = true;
            this.rjPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rjPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.rjPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel3.BorderRadius = 5;
            this.rjPanel3.BorderSize = 0;
            this.rjPanel3.Controls.Add(this.materialDivider1);
            this.rjPanel3.Controls.Add(this.lblTime);
            this.rjPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rjPanel3.ForeColor = System.Drawing.Color.Black;
            this.rjPanel3.Location = new System.Drawing.Point(10, 268);
            this.rjPanel3.MinimumSize = new System.Drawing.Size(230, 30);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(230, 30);
            this.rjPanel3.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTime.Location = new System.Drawing.Point(154, 8);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 16);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "_";
            // 
            // rjPanel1
            // 
            this.rjPanel1.AutoSize = true;
            this.rjPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 10;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.lblTableNum);
            this.rjPanel1.Controls.Add(this.lblOrderNum);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(10, 10);
            this.rjPanel1.MinimumSize = new System.Drawing.Size(230, 30);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(230, 30);
            this.rjPanel1.TabIndex = 1;
            // 
            // lblTableNum
            // 
            this.lblTableNum.AutoSize = true;
            this.lblTableNum.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.lblTableNum.ForeColor = System.Drawing.Color.Black;
            this.lblTableNum.Location = new System.Drawing.Point(154, 6);
            this.lblTableNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size(62, 16);
            this.lblTableNum.TabIndex = 13;
            this.lblTableNum.Text = "TABLE:12";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.lblOrderNum.ForeColor = System.Drawing.Color.Black;
            this.lblOrderNum.Location = new System.Drawing.Point(12, 6);
            this.lblOrderNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(75, 16);
            this.lblOrderNum.TabIndex = 12;
            this.lblOrderNum.Text = "ORDER :#23";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(2);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(230, 1);
            this.materialDivider1.TabIndex = 12;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // UCInvoiceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.rjPanel2);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(250, 70);
            this.Name = "UCInvoiceCard";
            this.Size = new System.Drawing.Size(250, 308);
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.smoothFlowPanel1.ResumeLayout(false);
            this.smoothFlowPanel1.PerformLayout();
            this.rjPanel3.ResumeLayout(false);
            this.rjPanel3.PerformLayout();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private CustomControls.RJControls.RJPanel rjPanel2;
        private CustomControls.RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.Label lblTime;
        private SmoothFlowPanel smoothFlowPanel1;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTableNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJPanel rjPanel3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}
