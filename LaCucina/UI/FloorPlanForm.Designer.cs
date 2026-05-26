namespace LaCucina
{
    partial class FloorPlanForm
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
            this.rjPanel2 = new CustomControls.RJControls.RJPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rJgradiantPanal1 = new CustomControls.RJControls.RJgradiantPanal();
            this.btnTakeAway = new CustomControls.RJControls.RJButton();
            this.btnClose = new CustomControls.RJControls.RJButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.btnLogout = new CustomControls.RJControls.RJButton();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.Label();
            this.ucFloorPlan1 = new LaCucina.UI.UCFloorPlan();
            this.rjPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rJgradiantPanal1.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjPanel2.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.rjPanel2.BorderRadius = 0;
            this.rjPanel2.BorderSize = 0;
            this.rjPanel2.Controls.Add(this.panel1);
            this.rjPanel2.Controls.Add(this.btnClose);
            this.rjPanel2.Controls.Add(this.materialDivider1);
            this.rjPanel2.Controls.Add(this.rjPanel1);
            this.rjPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjPanel2.ForeColor = System.Drawing.Color.Black;
            this.rjPanel2.Location = new System.Drawing.Point(0, 0);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.rjPanel2.Size = new System.Drawing.Size(1460, 77);
            this.rjPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rJgradiantPanal1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(792, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(430, 69);
            this.panel1.TabIndex = 21;
            // 
            // rJgradiantPanal1
            // 
            this.rJgradiantPanal1.BackColor = System.Drawing.Color.Transparent;
            this.rJgradiantPanal1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rJgradiantPanal1.BorderRadius = 10;
            this.rJgradiantPanal1.BorderSize = 0;
            this.rJgradiantPanal1.Controls.Add(this.btnTakeAway);
            this.rJgradiantPanal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJgradiantPanal1.ForeColor = System.Drawing.Color.Black;
            this.rJgradiantPanal1.GradientAngle = 0F;
            this.rJgradiantPanal1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(128)))), ((int)(((byte)(16)))));
            this.rJgradiantPanal1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.rJgradiantPanal1.Location = new System.Drawing.Point(10, 10);
            this.rJgradiantPanal1.Margin = new System.Windows.Forms.Padding(4);
            this.rJgradiantPanal1.Name = "rJgradiantPanal1";
            this.rJgradiantPanal1.Size = new System.Drawing.Size(410, 49);
            this.rJgradiantPanal1.TabIndex = 11;
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.BackColor = System.Drawing.Color.Transparent;
            this.btnTakeAway.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTakeAway.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTakeAway.BorderRadius = 10;
            this.btnTakeAway.BorderSize = 0;
            this.btnTakeAway.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTakeAway.FlatAppearance.BorderSize = 0;
            this.btnTakeAway.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTakeAway.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAway.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnTakeAway.ForeColor = System.Drawing.Color.Black;
            this.btnTakeAway.Location = new System.Drawing.Point(0, 0);
            this.btnTakeAway.Margin = new System.Windows.Forms.Padding(6);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(410, 49);
            this.btnTakeAway.TabIndex = 0;
            this.btnTakeAway.Text = "🛒  TAKEAWAY ORDER";
            this.btnTakeAway.TextColor = System.Drawing.Color.Black;
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::LaCucina.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(0, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 69);
            this.btnClose.TabIndex = 14;
            this.btnClose.TextColor = System.Drawing.Color.Transparent;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialDivider1.Location = new System.Drawing.Point(0, 76);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1222, 1);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.Transparent;
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 10;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.btnLogout);
            this.rjPanel1.Controls.Add(this.materialDivider3);
            this.rjPanel1.Controls.Add(this.pictureBox1);
            this.rjPanel1.Controls.Add(this.txtUserName);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(1222, 7);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.rjPanel1.Size = new System.Drawing.Size(238, 70);
            this.rjPanel1.TabIndex = 20;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Silver;
            this.btnLogout.Image = global::LaCucina.Properties.Resources.logout__3_;
            this.btnLogout.Location = new System.Drawing.Point(160, 13);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(58, 44);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.TextColor = System.Drawing.Color.Silver;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider3.ForeColor = System.Drawing.Color.Gray;
            this.materialDivider3.Location = new System.Drawing.Point(3, 66);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(4);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(232, 1);
            this.materialDivider3.TabIndex = 12;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaCucina.Properties.Resources.user__4_;
            this.pictureBox1.Location = new System.Drawing.Point(4, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtUserName.Location = new System.Drawing.Point(36, 20);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(97, 29);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.Text = "maysem";
            // 
            // ucFloorPlan1
            // 
            this.ucFloorPlan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFloorPlan1.Location = new System.Drawing.Point(0, 77);
            this.ucFloorPlan1.Name = "ucFloorPlan1";
            this.ucFloorPlan1.Size = new System.Drawing.Size(1460, 811);
            this.ucFloorPlan1.TabIndex = 6;
            // 
            // FloorPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1460, 888);
            this.ControlBox = false;
            this.Controls.Add(this.ucFloorPlan1);
            this.Controls.Add(this.rjPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FloorPlanForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FloorPlanForm_Load);
            this.rjPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rJgradiantPanal1.ResumeLayout(false);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel2;
        private CustomControls.RJControls.RJButton btnClose;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private CustomControls.RJControls.RJPanel rjPanel1;
        private CustomControls.RJControls.RJButton btnLogout;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtUserName;
        private CustomControls.RJControls.RJgradiantPanal rJgradiantPanal1;
        private CustomControls.RJControls.RJButton btnTakeAway;
        private System.Windows.Forms.Panel panel1;
        private UI.UCFloorPlan ucFloorPlan1;
    }
}