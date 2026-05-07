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
            this.rjPanel2 = new CustomControls.RJControls.RJPanel();
            this.pnlCategories = new LaCucina.controls.HorizontalFlowPanel();
            this.btnEditCategories = new CustomControls.RJControls.RJButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnUsers = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.FlowpnlItems = new SmoothFlowPanel();
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
            this.pnlItems.Location = new System.Drawing.Point(0, 53);
            this.pnlItems.Margin = new System.Windows.Forms.Padding(2);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(800, 384);
            this.pnlItems.TabIndex = 11;
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
            this.rjPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjPanel2.Size = new System.Drawing.Size(800, 53);
            this.rjPanel2.TabIndex = 5;
            // 
            // pnlCategories
            // 
            this.pnlCategories.AutoScroll = true;
            this.pnlCategories.AutoScrollMinSize = new System.Drawing.Size(752, 0);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategories.Location = new System.Drawing.Point(0, 5);
            this.pnlCategories.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(752, 47);
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
            this.btnEditCategories.Location = new System.Drawing.Point(752, 5);
            this.btnEditCategories.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCategories.Name = "btnEditCategories";
            this.btnEditCategories.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditCategories.Size = new System.Drawing.Size(48, 47);
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
            this.materialDivider1.Location = new System.Drawing.Point(0, 52);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(2);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(800, 1);
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
            this.btnUsers.Location = new System.Drawing.Point(9, 9);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(150, 36);
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
            this.rjButton3.Location = new System.Drawing.Point(165, 9);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(147, 36);
            this.rjButton3.TabIndex = 10;
            this.rjButton3.Text = "Pizza";
            this.rjButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rjButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // FlowpnlItems
            // 
            this.FlowpnlItems.AutoScroll = true;
            this.FlowpnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowpnlItems.Location = new System.Drawing.Point(0, 0);
            this.FlowpnlItems.Margin = new System.Windows.Forms.Padding(2);
            this.FlowpnlItems.Name = "FlowpnlItems";
            this.FlowpnlItems.Padding = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.FlowpnlItems.Size = new System.Drawing.Size(800, 384);
            this.FlowpnlItems.TabIndex = 1;
            // 
            // UCManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.rjPanel2);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.rjButton3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCManagerMenu";
            this.Size = new System.Drawing.Size(800, 437);
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
