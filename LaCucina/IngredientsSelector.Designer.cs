namespace LaCucina
{
    partial class IngredientsSelector
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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new CustomControls.RJControls.RJButton();
            this.rjPanel2 = new CustomControls.RJControls.RJPanel();
            this.FpnlRequiredIngredients = new SmoothFlowPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.rjPanel5 = new CustomControls.RJControls.RJPanel();
            this.FpnlIngredients = new SmoothFlowPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.rjPanel4 = new CustomControls.RJControls.RJPanel();
            this.rJgradiantPanal2 = new CustomControls.RJControls.RJgradiantPanal();
            this.rJgradiantPanal1 = new CustomControls.RJControls.RJgradiantPanal();
            this.btnUpdateToppings = new CustomControls.RJControls.RJButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btnDiscard = new CustomControls.RJControls.RJButton();
            this.rjPanel1.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            this.rjPanel5.SuspendLayout();
            this.rjPanel4.SuspendLayout();
            this.rJgradiantPanal2.SuspendLayout();
            this.rJgradiantPanal1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 0;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.materialDivider1);
            this.rjPanel1.Controls.Add(this.label2);
            this.rjPanel1.Controls.Add(this.label1);
            this.rjPanel1.Controls.Add(this.btnClose);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.Location = new System.Drawing.Point(3, 3);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(400, 40);
            this.rjPanel1.TabIndex = 0;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialDivider1.Location = new System.Drawing.Point(0, 39);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(2);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(400, 1);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(321, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Order :#12";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(142, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Customize Order";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::LaCucina.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(3, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 27);
            this.btnClose.TabIndex = 15;
            this.btnClose.TextColor = System.Drawing.Color.Transparent;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.rjPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel2.BorderRadius = 0;
            this.rjPanel2.BorderSize = 0;
            this.rjPanel2.Controls.Add(this.FpnlRequiredIngredients);
            this.rjPanel2.Controls.Add(this.label6);
            this.rjPanel2.Controls.Add(this.materialDivider3);
            this.rjPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rjPanel2.ForeColor = System.Drawing.Color.Black;
            this.rjPanel2.Location = new System.Drawing.Point(3, 242);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(400, 104);
            this.rjPanel2.TabIndex = 2;
            this.rjPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel2_Paint);
            // 
            // FpnlRequiredIngredients
            // 
            this.FpnlRequiredIngredients.AutoScroll = true;
            this.FpnlRequiredIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.FpnlRequiredIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FpnlRequiredIngredients.Location = new System.Drawing.Point(0, 27);
            this.FpnlRequiredIngredients.Name = "FpnlRequiredIngredients";
            this.FpnlRequiredIngredients.Size = new System.Drawing.Size(400, 77);
            this.FpnlRequiredIngredients.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(0, 1);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this.label6.Size = new System.Drawing.Size(145, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Main Ingredients";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialDivider3.Location = new System.Drawing.Point(0, 0);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(2);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(400, 1);
            this.materialDivider3.TabIndex = 18;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // rjPanel5
            // 
            this.rjPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.rjPanel5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel5.BorderRadius = 0;
            this.rjPanel5.BorderSize = 0;
            this.rjPanel5.Controls.Add(this.FpnlIngredients);
            this.rjPanel5.Controls.Add(this.label5);
            this.rjPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjPanel5.ForeColor = System.Drawing.Color.Black;
            this.rjPanel5.Location = new System.Drawing.Point(3, 43);
            this.rjPanel5.Margin = new System.Windows.Forms.Padding(13);
            this.rjPanel5.Name = "rjPanel5";
            this.rjPanel5.Size = new System.Drawing.Size(400, 199);
            this.rjPanel5.TabIndex = 0;
            // 
            // FpnlIngredients
            // 
            this.FpnlIngredients.AutoScroll = true;
            this.FpnlIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.FpnlIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FpnlIngredients.Location = new System.Drawing.Point(0, 26);
            this.FpnlIngredients.Name = "FpnlIngredients";
            this.FpnlIngredients.Size = new System.Drawing.Size(400, 173);
            this.FpnlIngredients.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 5);
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Toppings";
            // 
            // rjPanel4
            // 
            this.rjPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.rjPanel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel4.BorderRadius = 0;
            this.rjPanel4.BorderSize = 0;
            this.rjPanel4.Controls.Add(this.rJgradiantPanal2);
            this.rjPanel4.Controls.Add(this.rJgradiantPanal1);
            this.rjPanel4.Controls.Add(this.materialDivider2);
            this.rjPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rjPanel4.ForeColor = System.Drawing.Color.Black;
            this.rjPanel4.Location = new System.Drawing.Point(3, 346);
            this.rjPanel4.Name = "rjPanel4";
            this.rjPanel4.Size = new System.Drawing.Size(400, 44);
            this.rjPanel4.TabIndex = 2;
            // 
            // rJgradiantPanal2
            // 
            this.rJgradiantPanal2.BackColor = System.Drawing.Color.Transparent;
            this.rJgradiantPanal2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rJgradiantPanal2.BorderRadius = 15;
            this.rJgradiantPanal2.BorderSize = 2;
            this.rJgradiantPanal2.Controls.Add(this.btnDiscard);
            this.rJgradiantPanal2.ForeColor = System.Drawing.Color.Black;
            this.rJgradiantPanal2.GradientAngle = 0F;
            this.rJgradiantPanal2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.rJgradiantPanal2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.rJgradiantPanal2.Location = new System.Drawing.Point(69, 6);
            this.rJgradiantPanal2.Margin = new System.Windows.Forms.Padding(2);
            this.rJgradiantPanal2.Name = "rJgradiantPanal2";
            this.rJgradiantPanal2.Size = new System.Drawing.Size(86, 33);
            this.rJgradiantPanal2.TabIndex = 5;
            this.rJgradiantPanal2.Paint += new System.Windows.Forms.PaintEventHandler(this.rJgradiantPanal2_Paint);
            // 
            // rJgradiantPanal1
            // 
            this.rJgradiantPanal1.BackColor = System.Drawing.Color.Transparent;
            this.rJgradiantPanal1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rJgradiantPanal1.BorderRadius = 15;
            this.rJgradiantPanal1.BorderSize = 2;
            this.rJgradiantPanal1.Controls.Add(this.btnUpdateToppings);
            this.rJgradiantPanal1.ForeColor = System.Drawing.Color.Black;
            this.rJgradiantPanal1.GradientAngle = 0F;
            this.rJgradiantPanal1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.rJgradiantPanal1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.rJgradiantPanal1.Location = new System.Drawing.Point(194, 5);
            this.rJgradiantPanal1.Margin = new System.Windows.Forms.Padding(2);
            this.rJgradiantPanal1.Name = "rJgradiantPanal1";
            this.rJgradiantPanal1.Size = new System.Drawing.Size(133, 33);
            this.rJgradiantPanal1.TabIndex = 4;
            // 
            // btnUpdateToppings
            // 
            this.btnUpdateToppings.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateToppings.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUpdateToppings.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdateToppings.BorderRadius = 13;
            this.btnUpdateToppings.BorderSize = 0;
            this.btnUpdateToppings.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdateToppings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateToppings.FlatAppearance.BorderSize = 0;
            this.btnUpdateToppings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateToppings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateToppings.Font = new System.Drawing.Font("Yu Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnUpdateToppings.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateToppings.Name = "btnUpdateToppings";
            this.btnUpdateToppings.Size = new System.Drawing.Size(133, 33);
            this.btnUpdateToppings.TabIndex = 1;
            this.btnUpdateToppings.Text = "Update Toppings";
            this.btnUpdateToppings.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnUpdateToppings.UseVisualStyleBackColor = false;
            this.btnUpdateToppings.Click += new System.EventHandler(this.btnUpdateToppings_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialDivider2.Location = new System.Drawing.Point(0, 43);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(2);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(400, 1);
            this.materialDivider2.TabIndex = 3;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // btnDiscard
            // 
            this.btnDiscard.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscard.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDiscard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDiscard.BorderRadius = 15;
            this.btnDiscard.BorderSize = 0;
            this.btnDiscard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiscard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiscard.FlatAppearance.BorderSize = 0;
            this.btnDiscard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDiscard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.btnDiscard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDiscard.Location = new System.Drawing.Point(0, 0);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(86, 33);
            this.btnDiscard.TabIndex = 0;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDiscard.UseVisualStyleBackColor = false;
            // 
            // IngredientsSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(406, 393);
            this.Controls.Add(this.rjPanel5);
            this.Controls.Add(this.rjPanel2);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.rjPanel4);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngredientsSelector";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IngredientsSelector";
            this.Load += new System.EventHandler(this.IngredientsSelector_Load);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.rjPanel5.ResumeLayout(false);
            this.rjPanel5.PerformLayout();
            this.rjPanel4.ResumeLayout(false);
            this.rJgradiantPanal2.ResumeLayout(false);
            this.rJgradiantPanal1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnClose;
        private CustomControls.RJControls.RJPanel rjPanel2;
        private CustomControls.RJControls.RJPanel rjPanel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private SmoothFlowPanel FpnlIngredients;
        private SmoothFlowPanel FpnlRequiredIngredients;
        private CustomControls.RJControls.RJPanel rjPanel4;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJgradiantPanal rJgradiantPanal2;
        private CustomControls.RJControls.RJgradiantPanal rJgradiantPanal1;
        private CustomControls.RJControls.RJButton btnUpdateToppings;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private CustomControls.RJControls.RJButton btnDiscard;
    }
}