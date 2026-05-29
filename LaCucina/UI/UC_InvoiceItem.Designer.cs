namespace LaCucina
{
    partial class UC_InvoiceItem
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
            this.lblQty = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.btnDelete = new CustomControls.RJControls.RJButton();
            this.btnMinus = new CustomControls.RJControls.RJButton();
            this.btnPlus = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblQty.Location = new System.Drawing.Point(51, 14);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(28, 21);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "15";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQty.Click += new System.EventHandler(this.lblQty_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblItemName.Location = new System.Drawing.Point(111, -3);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(174, 52);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "تتت";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTotal.Location = new System.Drawing.Point(396, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 21);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "15.15 ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider1.Location = new System.Drawing.Point(0, 47);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(502, 2);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblUnitPrice.Location = new System.Drawing.Point(312, 12);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(55, 21);
            this.lblUnitPrice.TabIndex = 7;
            this.lblUnitPrice.Text = "15.15 ";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnDelete.Image = global::LaCucina.Properties.Resources.close;
            this.btnDelete.Location = new System.Drawing.Point(460, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(27, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TextColor = System.Drawing.Color.SpringGreen;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnMinus.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMinus.BorderColor = System.Drawing.Color.Black;
            this.btnMinus.BorderRadius = 12;
            this.btnMinus.BorderSize = 0;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnMinus.Location = new System.Drawing.Point(0, 6);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(51, 31);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMinus.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click_1);
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnPlus.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPlus.BorderColor = System.Drawing.Color.Black;
            this.btnPlus.BorderRadius = 12;
            this.btnPlus.BorderSize = 0;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPlus.Location = new System.Drawing.Point(57, 6);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(51, 31);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPlus.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click_1);
            // 
            // UC_InvoiceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lblItemName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_InvoiceItem";
            this.Size = new System.Drawing.Size(502, 49);
            this.Load += new System.EventHandler(this.UC_InvoiceItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblItemName;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private CustomControls.RJControls.RJButton btnPlus;
        private CustomControls.RJControls.RJButton btnMinus;
        private CustomControls.RJControls.RJButton btnDelete;
        private System.Windows.Forms.Label lblUnitPrice;
        public System.Windows.Forms.Label lblTotal;
    }
}
