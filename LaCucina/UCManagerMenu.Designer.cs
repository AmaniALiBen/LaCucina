namespace LaCucina
{
    partial class UCManagerMenu
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
            this.pnlItems = new CustomControls.RJControls.RJPanel();
            this.FlowpnlItems = new SmoothFlowPanel();
            this.rjPanel2 = new CustomControls.RJControls.RJPanel();
            this.pnlCategories = new LaCucina.controls.HorizontalFlowPanel();
            this.btnEditCategories = new CustomControls.RJControls.RJButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnUsers = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.pnlItems.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlItems
            // 
            this.pnlItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlItems.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlItems.BorderRadius = 0;
            this.pnlItems.BorderSize = 0;
            this.pnlItems.Controls.Add(this.FlowpnlItems);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.ForeColor = System.Drawing.Color.Black;
            this.pnlItems.Location = new System.Drawing.Point(0, 77);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(1200, 562);
            this.pnlItems.TabIndex = 11;
            // 
            // FlowpnlItems
            // 
            this.FlowpnlItems.AutoScroll = true;
            this.FlowpnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowpnlItems.Location = new System.Drawing.Point(0, 0);
            this.FlowpnlItems.Name = "FlowpnlItems";
            this.FlowpnlItems.Padding = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.FlowpnlItems.Size = new System.Drawing.Size(1200, 562);
            this.FlowpnlItems.TabIndex = 1;
            this.FlowpnlItems.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowpnlItems_Paint);
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjPanel2.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.rjPanel2.BorderRadius = 0;
            this.rjPanel2.BorderSize = 0;
            this.rjPanel2.Controls.Add(this.pnlCategories);
            this.rjPanel2.Controls.Add(this.btnEditCategories);
            this.rjPanel2.Controls.Add(this.materialDivider1);
            this.rjPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjPanel2.ForeColor = System.Drawing.Color.Black;
            this.rjPanel2.Location = new System.Drawing.Point(0, 0);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.rjPanel2.Size = new System.Drawing.Size(1200, 77);
            this.rjPanel2.TabIndex = 5;
            // 
            // pnlCategories
            // 
            this.pnlCategories.AutoScroll = true;
            this.pnlCategories.AutoScrollMinSize = new System.Drawing.Size(1128, 0);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategories.Location = new System.Drawing.Point(0, 7);
            this.pnlCategories.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(1128, 69);
            this.pnlCategories.TabIndex = 14;
            this.pnlCategories.WrapContents = false;
            // 
            // btnEditCategories
            // 
            this.btnEditCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnEditCategories.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEditCategories.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditCategories.BorderRadius = 0;
            this.btnEditCategories.BorderSize = 0;
            this.btnEditCategories.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditCategories.FlatAppearance.BorderSize = 0;
            this.btnEditCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategories.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditCategories.Image = global::LaCucina.Properties.Resources.edit;
            this.btnEditCategories.Location = new System.Drawing.Point(1128, 7);
            this.btnEditCategories.Name = "btnEditCategories";
            this.btnEditCategories.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEditCategories.Size = new System.Drawing.Size(72, 69);
            this.btnEditCategories.TabIndex = 13;
            this.btnEditCategories.TextColor = System.Drawing.Color.Transparent;
            this.btnEditCategories.UseVisualStyleBackColor = false;
            this.btnEditCategories.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialDivider1.Location = new System.Drawing.Point(0, 76);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1200, 1);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
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
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnUsers.Location = new System.Drawing.Point(14, 13);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(225, 53);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Burgers";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.Transparent;
            this.rjButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton3.BorderColor = System.Drawing.Color.PeachPuff;
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rjButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.rjButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rjButton3.Location = new System.Drawing.Point(248, 13);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(220, 53);
            this.rjButton3.TabIndex = 10;
            this.rjButton3.Text = "Pizza";
            this.rjButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rjButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // UCManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.rjPanel2);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.rjButton3);
            this.Name = "UCManagerMenu";
            this.Size = new System.Drawing.Size(1200, 639);
            this.Load += new System.EventHandler(this.UCManagerMenu_Load);
            this.pnlItems.ResumeLayout(false);
            this.rjPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel2;
        private CustomControls.RJControls.RJButton btnUsers;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private CustomControls.RJControls.RJButton btnEditCategories;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJPanel pnlItems;
        private controls.HorizontalFlowPanel pnlCategories;
        private SmoothFlowPanel FlowpnlItems;
    }
}
