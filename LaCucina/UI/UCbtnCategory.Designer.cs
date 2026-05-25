namespace LaCucina
{
    partial class UCbtnCategory
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
            this.btnName = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.Transparent;
            this.btnName.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnName.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnName.BorderRadius = 0;
            this.btnName.BorderSize = 0;
            this.btnName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnName.FlatAppearance.BorderSize = 0;
            this.btnName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnName.ForeColor = System.Drawing.Color.Gray;
            this.btnName.Location = new System.Drawing.Point(0, 0);
            this.btnName.Margin = new System.Windows.Forms.Padding(0);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(147, 36);
            this.btnName.TabIndex = 15;
            this.btnName.Text = "Burgers";
            this.btnName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnName.TextColor = System.Drawing.Color.Gray;
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // UCbtnCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnName);
            this.Name = "UCbtnCategory";
            this.Size = new System.Drawing.Size(147, 36);
            this.ResumeLayout(false);

        }

        #endregion

        public CustomControls.RJControls.RJButton btnName;
    }
}
