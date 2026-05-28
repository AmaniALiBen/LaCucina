namespace LaCucina.UI
{
    partial class UCItemInBatch
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
            this.pnlModifiers = new SmoothFlowPanel();
            this.pnlNote = new System.Windows.Forms.Panel();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblNoteTitle = new System.Windows.Forms.Label();
            this.smoothFlowPanel2 = new SmoothFlowPanel();
            this.lblItemNameAndQuantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNote.SuspendLayout();
            this.smoothFlowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModifiers
            // 
            this.pnlModifiers.AutoScroll = true;
            this.pnlModifiers.AutoSize = true;
            this.pnlModifiers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlModifiers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlModifiers.Location = new System.Drawing.Point(3, 3);
            this.pnlModifiers.MinimumSize = new System.Drawing.Size(375, 0);
            this.pnlModifiers.Name = "pnlModifiers";
            this.pnlModifiers.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlModifiers.Size = new System.Drawing.Size(375, 10);
            this.pnlModifiers.TabIndex = 6;
            this.pnlModifiers.WrapContents = false;
            // 
            // pnlNote
            // 
            this.pnlNote.AutoSize = true;
            this.pnlNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNote.Controls.Add(this.lblNote);
            this.pnlNote.Controls.Add(this.lblNoteTitle);
            this.pnlNote.Location = new System.Drawing.Point(3, 19);
            this.pnlNote.MinimumSize = new System.Drawing.Size(375, 0);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlNote.Size = new System.Drawing.Size(375, 110);
            this.pnlNote.TabIndex = 7;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNote.Location = new System.Drawing.Point(0, 35);
            this.lblNote.MaximumSize = new System.Drawing.Size(375, 0);
            this.lblNote.MinimumSize = new System.Drawing.Size(375, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(375, 75);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "i have a garlec alirgy do not add any or it will kill me and my fimily will sue y" +
    "ou\r\n\r\n";
            // 
            // lblNoteTitle
            // 
            this.lblNoteTitle.AutoSize = true;
            this.lblNoteTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNoteTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNoteTitle.Location = new System.Drawing.Point(0, 10);
            this.lblNoteTitle.Name = "lblNoteTitle";
            this.lblNoteTitle.Size = new System.Drawing.Size(60, 25);
            this.lblNoteTitle.TabIndex = 4;
            this.lblNoteTitle.Text = "Note :";
            // 
            // smoothFlowPanel2
            // 
            this.smoothFlowPanel2.AutoScroll = true;
            this.smoothFlowPanel2.AutoSize = true;
            this.smoothFlowPanel2.Controls.Add(this.pnlModifiers);
            this.smoothFlowPanel2.Controls.Add(this.pnlNote);
            this.smoothFlowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.smoothFlowPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.smoothFlowPanel2.Location = new System.Drawing.Point(0, 48);
            this.smoothFlowPanel2.MinimumSize = new System.Drawing.Size(375, 0);
            this.smoothFlowPanel2.Name = "smoothFlowPanel2";
            this.smoothFlowPanel2.Size = new System.Drawing.Size(375, 132);
            this.smoothFlowPanel2.TabIndex = 8;
            this.smoothFlowPanel2.WrapContents = false;
            // 
            // lblItemNameAndQuantity
            // 
            this.lblItemNameAndQuantity.AutoSize = true;
            this.lblItemNameAndQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItemNameAndQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNameAndQuantity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblItemNameAndQuantity.Location = new System.Drawing.Point(0, 1);
            this.lblItemNameAndQuantity.MaximumSize = new System.Drawing.Size(375, 0);
            this.lblItemNameAndQuantity.Name = "lblItemNameAndQuantity";
            this.lblItemNameAndQuantity.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblItemNameAndQuantity.Size = new System.Drawing.Size(258, 47);
            this.lblItemNameAndQuantity.TabIndex = 3;
            this.lblItemNameAndQuantity.Text = "1×Chicken shaworma";
            this.lblItemNameAndQuantity.Click += new System.EventHandler(this.lblItemNameAndQuantity_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 1);
            this.panel1.TabIndex = 0;
            // 
            // UCItemInBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.smoothFlowPanel2);
            this.Controls.Add(this.lblItemNameAndQuantity);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(375, 0);
            this.Name = "UCItemInBatch";
            this.Size = new System.Drawing.Size(375, 180);
            this.pnlNote.ResumeLayout(false);
            this.pnlNote.PerformLayout();
            this.smoothFlowPanel2.ResumeLayout(false);
            this.smoothFlowPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SmoothFlowPanel pnlModifiers;
        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblNoteTitle;
        private SmoothFlowPanel smoothFlowPanel2;
        private System.Windows.Forms.Label lblItemNameAndQuantity;
        private System.Windows.Forms.Panel panel1;
    }
}
