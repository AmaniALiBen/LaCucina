namespace LaCucina.UI
{
    partial class UCFloorPlan
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
            this.pnlTables = new System.Windows.Forms.Panel();
            this.rjPanel3 = new CustomControls.RJControls.RJPanel();
            this.pnlSpases = new CustomControls.RJControls.RJPanel();
            this.hfpnlSpaces = new LaCucina.controls.HorizontalFlowPanel();
            this.rjPanel3.SuspendLayout();
            this.pnlSpases.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTables
            // 
            this.pnlTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTables.Location = new System.Drawing.Point(0, 0);
            this.pnlTables.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(1186, 628);
            this.pnlTables.TabIndex = 27;
            this.pnlTables.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTables_Paint);
            // 
            // rjPanel3
            // 
            this.rjPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel3.BorderRadius = 0;
            this.rjPanel3.BorderSize = 0;
            this.rjPanel3.Controls.Add(this.pnlSpases);
            this.rjPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rjPanel3.ForeColor = System.Drawing.Color.Black;
            this.rjPanel3.Location = new System.Drawing.Point(0, 628);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            this.rjPanel3.Size = new System.Drawing.Size(1186, 136);
            this.rjPanel3.TabIndex = 26;
            // 
            // pnlSpases
            // 
            this.pnlSpases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.pnlSpases.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlSpases.BorderRadius = 10;
            this.pnlSpases.BorderSize = 0;
            this.pnlSpases.Controls.Add(this.hfpnlSpaces);
            this.pnlSpases.ForeColor = System.Drawing.Color.Black;
            this.pnlSpases.Location = new System.Drawing.Point(209, 32);
            this.pnlSpases.Margin = new System.Windows.Forms.Padding(3, 3, 3, 39);
            this.pnlSpases.Name = "pnlSpases";
            this.pnlSpases.Size = new System.Drawing.Size(773, 44);
            this.pnlSpases.TabIndex = 1;
            // 
            // hfpnlSpaces
            // 
            this.hfpnlSpaces.AutoScroll = true;
            this.hfpnlSpaces.AutoScrollMinSize = new System.Drawing.Size(773, 0);
            this.hfpnlSpaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.hfpnlSpaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hfpnlSpaces.Location = new System.Drawing.Point(0, 0);
            this.hfpnlSpaces.Margin = new System.Windows.Forms.Padding(0);
            this.hfpnlSpaces.Name = "hfpnlSpaces";
            this.hfpnlSpaces.Size = new System.Drawing.Size(773, 44);
            this.hfpnlSpaces.TabIndex = 1;
            this.hfpnlSpaces.WrapContents = false;
            // 
            // UCFloorPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.rjPanel3);
            this.Name = "UCFloorPlan";
            this.Size = new System.Drawing.Size(1186, 764);
            this.Load += new System.EventHandler(this.UCFloorPlan_Load);
            this.rjPanel3.ResumeLayout(false);
            this.pnlSpases.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTables;
        private CustomControls.RJControls.RJPanel rjPanel3;
        private CustomControls.RJControls.RJPanel pnlSpases;
        private controls.HorizontalFlowPanel hfpnlSpaces;
    }
}
