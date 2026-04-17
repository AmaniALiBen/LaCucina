namespace LaCucina
{
    partial class ManagerForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjPanel2 = new CustomControls.RJControls.RJPanel();
            this.professionalNavPanel1 = new ProfessionalNavPanel();
            this.btnUsers = new CustomControls.RJControls.RJButton();
            this.btnMenu = new CustomControls.RJControls.RJButton();
            this.btnFloorplan = new CustomControls.RJControls.RJButton();
            this.btnDiscounts = new CustomControls.RJControls.RJButton();
            this.btnOrdersHistory = new CustomControls.RJControls.RJButton();
            this.btnClose = new CustomControls.RJControls.RJButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.btnLogout = new CustomControls.RJControls.RJButton();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rjPanel2.SuspendLayout();
            this.professionalNavPanel1.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 438);
            this.panel2.TabIndex = 21;
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjPanel2.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.rjPanel2.BorderRadius = 0;
            this.rjPanel2.BorderSize = 0;
            this.rjPanel2.Controls.Add(this.professionalNavPanel1);
            this.rjPanel2.Controls.Add(this.btnClose);
            this.rjPanel2.Controls.Add(this.materialDivider1);
            this.rjPanel2.Controls.Add(this.rjPanel1);
            this.rjPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjPanel2.ForeColor = System.Drawing.Color.Black;
            this.rjPanel2.Location = new System.Drawing.Point(0, 0);
            this.rjPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjPanel2.Size = new System.Drawing.Size(867, 46);
            this.rjPanel2.TabIndex = 4;
            // 
            // professionalNavPanel1
            // 
            this.professionalNavPanel1.AutoScroll = true;
            this.professionalNavPanel1.Controls.Add(this.btnUsers);
            this.professionalNavPanel1.Controls.Add(this.btnMenu);
            this.professionalNavPanel1.Controls.Add(this.btnFloorplan);
            this.professionalNavPanel1.Controls.Add(this.btnDiscounts);
            this.professionalNavPanel1.Controls.Add(this.btnOrdersHistory);
            this.professionalNavPanel1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(128)))), ((int)(((byte)(16)))));
            this.professionalNavPanel1.Location = new System.Drawing.Point(37, 2);
            this.professionalNavPanel1.Name = "professionalNavPanel1";
            this.professionalNavPanel1.Size = new System.Drawing.Size(767, 44);
            this.professionalNavPanel1.TabIndex = 12;
            this.professionalNavPanel1.WrapContents = false;
            this.professionalNavPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.professionalNavPanel1_Paint);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUsers.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnUsers.BorderRadius = 0;
            this.btnUsers.BorderSize = 0;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnUsers.Location = new System.Drawing.Point(3, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(150, 36);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "👤 Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMenu.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.BorderSize = 0;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnMenu.Location = new System.Drawing.Point(159, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(150, 36);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "🍽️  Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenu.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnFloorplan
            // 
            this.btnFloorplan.BackColor = System.Drawing.Color.Transparent;
            this.btnFloorplan.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnFloorplan.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnFloorplan.BorderRadius = 0;
            this.btnFloorplan.BorderSize = 0;
            this.btnFloorplan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFloorplan.FlatAppearance.BorderSize = 0;
            this.btnFloorplan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFloorplan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFloorplan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloorplan.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.btnFloorplan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFloorplan.Location = new System.Drawing.Point(315, 3);
            this.btnFloorplan.Name = "btnFloorplan";
            this.btnFloorplan.Size = new System.Drawing.Size(150, 36);
            this.btnFloorplan.TabIndex = 8;
            this.btnFloorplan.Text = "🗺️ Floorplan";
            this.btnFloorplan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFloorplan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFloorplan.UseVisualStyleBackColor = false;
            this.btnFloorplan.Click += new System.EventHandler(this.btnFloorplan_Click);
            // 
            // btnDiscounts
            // 
            this.btnDiscounts.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscounts.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDiscounts.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnDiscounts.BorderRadius = 0;
            this.btnDiscounts.BorderSize = 0;
            this.btnDiscounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscounts.FlatAppearance.BorderSize = 0;
            this.btnDiscounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDiscounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscounts.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.btnDiscounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDiscounts.Location = new System.Drawing.Point(471, 3);
            this.btnDiscounts.Name = "btnDiscounts";
            this.btnDiscounts.Size = new System.Drawing.Size(147, 36);
            this.btnDiscounts.TabIndex = 9;
            this.btnDiscounts.Text = "🏷️ Discounts";
            this.btnDiscounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDiscounts.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDiscounts.UseVisualStyleBackColor = false;
            this.btnDiscounts.Click += new System.EventHandler(this.btnDiscounts_Click);
            // 
            // btnOrdersHistory
            // 
            this.btnOrdersHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdersHistory.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOrdersHistory.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnOrdersHistory.BorderRadius = 0;
            this.btnOrdersHistory.BorderSize = 0;
            this.btnOrdersHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdersHistory.FlatAppearance.BorderSize = 0;
            this.btnOrdersHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOrdersHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOrdersHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdersHistory.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.btnOrdersHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnOrdersHistory.Location = new System.Drawing.Point(624, 3);
            this.btnOrdersHistory.Name = "btnOrdersHistory";
            this.btnOrdersHistory.Size = new System.Drawing.Size(147, 36);
            this.btnOrdersHistory.TabIndex = 10;
            this.btnOrdersHistory.Text = "🛒Orders";
            this.btnOrdersHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdersHistory.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnOrdersHistory.UseVisualStyleBackColor = false;
            this.btnOrdersHistory.Click += new System.EventHandler(this.btnOrdersHistory_Click);
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
            this.btnClose.Location = new System.Drawing.Point(0, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 40);
            this.btnClose.TabIndex = 14;
            this.btnClose.TextColor = System.Drawing.Color.Transparent;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialDivider1.Location = new System.Drawing.Point(0, 45);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(2);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(723, 1);
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
            this.rjPanel1.Controls.Add(this.label1);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(723, 5);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.rjPanel1.Size = new System.Drawing.Size(144, 41);
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
            this.btnLogout.Location = new System.Drawing.Point(112, 3);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(28, 29);
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
            this.materialDivider3.Location = new System.Drawing.Point(2, 38);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(140, 1);
            this.materialDivider3.TabIndex = 12;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaCucina.Properties.Resources.user__4_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(28, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "maysem";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(867, 484);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rjPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.rjPanel2.ResumeLayout(false);
            this.professionalNavPanel1.ResumeLayout(false);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel2;
        private CustomControls.RJControls.RJButton btnClose;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Panel panel2;
        private ProfessionalNavPanel professionalNavPanel1;
        private CustomControls.RJControls.RJButton btnUsers;
        private CustomControls.RJControls.RJButton btnMenu;
        private CustomControls.RJControls.RJButton btnFloorplan;
        private CustomControls.RJControls.RJButton btnDiscounts;
        private CustomControls.RJControls.RJPanel rjPanel1;
        private CustomControls.RJControls.RJButton btnLogout;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnOrdersHistory;
    }
}