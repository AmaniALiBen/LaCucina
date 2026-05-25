namespace LaCucina
{
    partial class ManageSpacesForm
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
            this.btnSaveChanges = new CustomControls.RJControls.RJButton();
            this.pnlRows = new SmoothFlowPanel();
            this.rJgradiantPanal1 = new CustomControls.RJControls.RJgradiantPanal();
            this.btnDone = new CustomControls.RJControls.RJButton();
            this.btnAddSpace = new CustomControls.RJControls.RJButton();
            this.txtSpaceName = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.rjPanel1.SuspendLayout();
            this.rJgradiantPanal1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.Gray;
            this.rjPanel1.BorderRadius = 7;
            this.rjPanel1.BorderSize = 2;
            this.rjPanel1.Controls.Add(this.btnSaveChanges);
            this.rjPanel1.Controls.Add(this.pnlRows);
            this.rjPanel1.Controls.Add(this.rJgradiantPanal1);
            this.rjPanel1.Controls.Add(this.btnAddSpace);
            this.rjPanel1.Controls.Add(this.txtSpaceName);
            this.rjPanel1.Controls.Add(this.label2);
            this.rjPanel1.Controls.Add(this.materialDivider1);
            this.rjPanel1.Controls.Add(this.label1);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(0, 0);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.rjPanel1.Size = new System.Drawing.Size(596, 653);
            this.rjPanel1.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveChanges.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSaveChanges.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSaveChanges.BorderRadius = 0;
            this.btnSaveChanges.BorderSize = 0;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveChanges.Image = global::LaCucina.Properties.Resources.icons8_checkmark_yes_32;
            this.btnSaveChanges.Location = new System.Drawing.Point(526, 130);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(52, 47);
            this.btnSaveChanges.TabIndex = 36;
            this.btnSaveChanges.TextColor = System.Drawing.Color.Transparent;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // pnlRows
            // 
            this.pnlRows.AutoScroll = true;
            this.pnlRows.Location = new System.Drawing.Point(57, 204);
            this.pnlRows.Name = "pnlRows";
            this.pnlRows.Size = new System.Drawing.Size(465, 353);
            this.pnlRows.TabIndex = 35;
            // 
            // rJgradiantPanal1
            // 
            this.rJgradiantPanal1.BackColor = System.Drawing.Color.Transparent;
            this.rJgradiantPanal1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rJgradiantPanal1.BorderRadius = 15;
            this.rJgradiantPanal1.BorderSize = 2;
            this.rJgradiantPanal1.Controls.Add(this.btnDone);
            this.rJgradiantPanal1.ForeColor = System.Drawing.Color.Black;
            this.rJgradiantPanal1.GradientAngle = 0F;
            this.rJgradiantPanal1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.rJgradiantPanal1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.rJgradiantPanal1.Location = new System.Drawing.Point(224, 576);
            this.rJgradiantPanal1.Name = "rJgradiantPanal1";
            this.rJgradiantPanal1.Size = new System.Drawing.Size(128, 47);
            this.rJgradiantPanal1.TabIndex = 34;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDone.BorderRadius = 13;
            this.btnDone.BorderSize = 0;
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.Location = new System.Drawing.Point(0, 0);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(128, 47);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.TextColor = System.Drawing.Color.Black;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAddSpace
            // 
            this.btnAddSpace.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSpace.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddSpace.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddSpace.BorderRadius = 0;
            this.btnAddSpace.BorderSize = 0;
            this.btnAddSpace.FlatAppearance.BorderSize = 0;
            this.btnAddSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpace.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddSpace.Image = global::LaCucina.Properties.Resources.plus;
            this.btnAddSpace.Location = new System.Drawing.Point(526, 130);
            this.btnAddSpace.Name = "btnAddSpace";
            this.btnAddSpace.Size = new System.Drawing.Size(52, 47);
            this.btnAddSpace.TabIndex = 27;
            this.btnAddSpace.TextColor = System.Drawing.Color.Transparent;
            this.btnAddSpace.UseVisualStyleBackColor = false;
            this.btnAddSpace.Click += new System.EventHandler(this.btnAddSpace_Click);
            // 
            // txtSpaceName
            // 
            this.txtSpaceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSpaceName.BorderColor = System.Drawing.Color.Transparent;
            this.txtSpaceName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.txtSpaceName.BorderRadius = 10;
            this.txtSpaceName.BorderSize = 2;
            this.txtSpaceName.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpaceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtSpaceName.Location = new System.Drawing.Point(66, 130);
            this.txtSpaceName.Margin = new System.Windows.Forms.Padding(6);
            this.txtSpaceName.Multiline = false;
            this.txtSpaceName.Name = "txtSpaceName";
            this.txtSpaceName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSpaceName.PasswordChar = false;
            this.txtSpaceName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSpaceName.PlaceholderText = "";
            this.txtSpaceName.Size = new System.Drawing.Size(456, 47);
            this.txtSpaceName.TabIndex = 26;
            this.txtSpaceName.TabStop = false;
            this.txtSpaceName.Texts = "";
            this.txtSpaceName.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(64, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Add new Space";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialDivider1.Location = new System.Drawing.Point(0, 72);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(596, 1);
            this.materialDivider1.TabIndex = 24;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 6, 0, 15);
            this.label1.Size = new System.Drawing.Size(202, 52);
            this.label1.TabIndex = 23;
            this.label1.Text = "Manage Spaces";
            // 
            // ManageSpacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(596, 653);
            this.ControlBox = false;
            this.Controls.Add(this.rjPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageSpacesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ManageSpacesForm_Load);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.rJgradiantPanal1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel1;
        private CustomControls.RJControls.RJgradiantPanal rJgradiantPanal1;
        private CustomControls.RJControls.RJButton btnDone;
        private CustomControls.RJControls.RJButton btnAddSpace;
        public CustomControls.RJControls.RJTextBox txtSpaceName;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label label1;
        private SmoothFlowPanel pnlRows;
        public CustomControls.RJControls.RJButton btnSaveChanges;
    }
}