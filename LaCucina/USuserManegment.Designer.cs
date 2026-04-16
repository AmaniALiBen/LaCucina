namespace LaCucina
{
    partial class USuserManegment
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
            this.rjPanel4 = new CustomControls.RJControls.RJPanel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.rjPanel4.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjPanel4
            // 
            this.rjPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjPanel4.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.rjPanel4.BorderRadius = 0;
            this.rjPanel4.BorderSize = 0;
            this.rjPanel4.Controls.Add(this.materialDivider2);
            this.rjPanel4.Controls.Add(this.label1);
            this.rjPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjPanel4.ForeColor = System.Drawing.Color.Black;
            this.rjPanel4.Location = new System.Drawing.Point(0, 0);
            this.rjPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.rjPanel4.Name = "rjPanel4";
            this.rjPanel4.Padding = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.rjPanel4.Size = new System.Drawing.Size(816, 33);
            this.rjPanel4.TabIndex = 25;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialDivider2.Location = new System.Drawing.Point(0, 29);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(2);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(801, 1);
            this.materialDivider2.TabIndex = 0;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "👤 User managment";
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 15;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.label2);
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(511, 48);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(290, 433);
            this.rjPanel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // USuserManegment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.rjPanel4);
            this.Name = "USuserManegment";
            this.Size = new System.Drawing.Size(816, 500);
            this.rjPanel4.ResumeLayout(false);
            this.rjPanel4.PerformLayout();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel4;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.Label label2;
    }
}
