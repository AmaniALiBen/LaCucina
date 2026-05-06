namespace LaCucina
{
    partial class EditCategory
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
            this.pnlMain = new CustomControls.RJControls.RJPanel();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.btnDiscard = new CustomControls.RJControls.RJButton();
            this.rJgradiantPanal1 = new CustomControls.RJControls.RJgradiantPanal();
            this.btnUpdateToppings = new CustomControls.RJControls.RJButton();
            this.btnAddCategory = new CustomControls.RJControls.RJButton();
            this.txtAddCategory = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.tblCategories = new LaCucina.controls.TablePanel();
            this.pnlMain.SuspendLayout();
            this.rJgradiantPanal1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlMain.BorderColor = System.Drawing.Color.Gray;
            this.pnlMain.BorderRadius = 7;
            this.pnlMain.BorderSize = 2;
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnDiscard);
            this.pnlMain.Controls.Add(this.rJgradiantPanal1);
            this.pnlMain.Controls.Add(this.btnAddCategory);
            this.pnlMain.Controls.Add(this.txtAddCategory);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.materialDivider1);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.tblCategories);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.Black;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(2);
            this.pnlMain.Size = new System.Drawing.Size(397, 447);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Click += new System.EventHandler(this.pnlMain_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 0;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = global::LaCucina.Properties.Resources.checked__1_;
            this.btnSave.Location = new System.Drawing.Point(351, 89);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 32);
            this.btnSave.TabIndex = 36;
            this.btnSave.TextColor = System.Drawing.Color.Transparent;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscard.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDiscard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDiscard.BorderRadius = 13;
            this.btnDiscard.BorderSize = 2;
            this.btnDiscard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiscard.FlatAppearance.BorderSize = 0;
            this.btnDiscard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDiscard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.btnDiscard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDiscard.Location = new System.Drawing.Point(55, 401);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(85, 32);
            this.btnDiscard.TabIndex = 33;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDiscard.UseVisualStyleBackColor = false;
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
            this.rJgradiantPanal1.Location = new System.Drawing.Point(255, 401);
            this.rJgradiantPanal1.Margin = new System.Windows.Forms.Padding(2);
            this.rJgradiantPanal1.Name = "rJgradiantPanal1";
            this.rJgradiantPanal1.Size = new System.Drawing.Size(85, 32);
            this.rJgradiantPanal1.TabIndex = 34;
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
            this.btnUpdateToppings.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateToppings.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateToppings.Name = "btnUpdateToppings";
            this.btnUpdateToppings.Size = new System.Drawing.Size(85, 32);
            this.btnUpdateToppings.TabIndex = 1;
            this.btnUpdateToppings.Text = "Done";
            this.btnUpdateToppings.TextColor = System.Drawing.Color.Black;
            this.btnUpdateToppings.UseVisualStyleBackColor = false;
            this.btnUpdateToppings.Click += new System.EventHandler(this.btnUpdateToppings_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddCategory.BorderRadius = 0;
            this.btnAddCategory.BorderSize = 0;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Image = global::LaCucina.Properties.Resources.plus;
            this.btnAddCategory.Location = new System.Drawing.Point(351, 89);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(35, 32);
            this.btnAddCategory.TabIndex = 27;
            this.btnAddCategory.TextColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtAddCategory
            // 
            this.txtAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtAddCategory.BorderColor = System.Drawing.Color.Transparent;
            this.txtAddCategory.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.txtAddCategory.BorderRadius = 10;
            this.txtAddCategory.BorderSize = 2;
            this.txtAddCategory.CustomPasswordChar = '●';
            this.txtAddCategory.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtAddCategory.Location = new System.Drawing.Point(44, 89);
            this.txtAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddCategory.Multiline = false;
            this.txtAddCategory.Name = "txtAddCategory";
            this.txtAddCategory.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtAddCategory.PasswordChar = false;
            this.txtAddCategory.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddCategory.PlaceholderFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAddCategory.PlaceholderText = "";
            this.txtAddCategory.Size = new System.Drawing.Size(304, 32);
            this.txtAddCategory.TabIndex = 26;
            this.txtAddCategory.TabStop = false;
            this.txtAddCategory.Texts = "";
            this.txtAddCategory.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(43, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Add new Category";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialDivider1.Location = new System.Drawing.Point(0, 49);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(2);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(397, 1);
            this.materialDivider1.TabIndex = 24;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 4, 0, 10);
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 23;
            this.label1.Text = "Manage Categories";
            // 
            // tblCategories
            // 
            this.tblCategories.AutoScroll = true;
            this.tblCategories.Location = new System.Drawing.Point(44, 165);
            this.tblCategories.Margin = new System.Windows.Forms.Padding(25, 25, 25, 15);
            this.tblCategories.Name = "tblCategories";
            this.tblCategories.Size = new System.Drawing.Size(304, 218);
            this.tblCategories.TabIndex = 35;
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(397, 447);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditCategory";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.rJgradiantPanal1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJPanel pnlMain;
        private CustomControls.RJControls.RJButton btnDiscard;
        private CustomControls.RJControls.RJgradiantPanal rJgradiantPanal1;
        private CustomControls.RJControls.RJButton btnUpdateToppings;
        private CustomControls.RJControls.RJButton btnAddCategory;
        private CustomControls.RJControls.RJTextBox txtAddCategory;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label label1;
        private controls.TablePanel tblCategories;
        private CustomControls.RJControls.RJButton btnSave;
    }
}