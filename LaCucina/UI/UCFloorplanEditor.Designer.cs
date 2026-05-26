namespace LaCucina
{
    partial class USFloorplanEditor
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
            this.pnlNewTable = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlFormat = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlChairCount = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTableButtons = new System.Windows.Forms.Panel();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.btnDeleteTable = new CustomControls.RJControls.RJButton();
            this.btnEditTable = new CustomControls.RJControls.RJButton();
            this.btnEdit = new CustomControls.RJControls.RJButton();
            this.btnAdd = new CustomControls.RJControls.RJButton();
            this.txtTablenum = new CustomControls.RJControls.RJTextBox();
            this.rbtnCircular = new CustomControls.RJControls.RJRadioButton();
            this.rbtnVertical = new CustomControls.RJControls.RJRadioButton();
            this.rbtnHorizantal = new CustomControls.RJControls.RJRadioButton();
            this.rbtn4 = new CustomControls.RJControls.RJRadioButton();
            this.rbtn8 = new CustomControls.RJControls.RJRadioButton();
            this.rbtn12 = new CustomControls.RJControls.RJRadioButton();
            this.rbtn6 = new CustomControls.RJControls.RJRadioButton();
            this.rbtn10 = new CustomControls.RJControls.RJRadioButton();
            this.rbtn2 = new CustomControls.RJControls.RJRadioButton();
            this.rjPanel3 = new CustomControls.RJControls.RJPanel();
            this.pnlSpases = new CustomControls.RJControls.RJPanel();
            this.hfpnlSpaces = new LaCucina.controls.HorizontalFlowPanel();
            this.rjPanel4 = new CustomControls.RJControls.RJPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btnNewTable = new CustomControls.RJControls.RJButton();
            this.rjButton7 = new CustomControls.RJControls.RJButton();
            this.rjButton8 = new CustomControls.RJControls.RJButton();
            this.rjButton6 = new CustomControls.RJControls.RJButton();
            this.rjButton5 = new CustomControls.RJControls.RJButton();
            this.pnlNewTable.SuspendLayout();
            this.pnlFormat.SuspendLayout();
            this.pnlChairCount.SuspendLayout();
            this.pnlTableButtons.SuspendLayout();
            this.pnlTables.SuspendLayout();
            this.rjPanel3.SuspendLayout();
            this.pnlSpases.SuspendLayout();
            this.rjPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewTable
            // 
            this.pnlNewTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlNewTable.Controls.Add(this.btnEdit);
            this.pnlNewTable.Controls.Add(this.lblError);
            this.pnlNewTable.Controls.Add(this.btnAdd);
            this.pnlNewTable.Controls.Add(this.txtTablenum);
            this.pnlNewTable.Controls.Add(this.label5);
            this.pnlNewTable.Controls.Add(this.pnlFormat);
            this.pnlNewTable.Controls.Add(this.pnlChairCount);
            this.pnlNewTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNewTable.Location = new System.Drawing.Point(780, 0);
            this.pnlNewTable.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNewTable.Name = "pnlNewTable";
            this.pnlNewTable.Size = new System.Drawing.Size(444, 547);
            this.pnlNewTable.TabIndex = 0;
            this.pnlNewTable.Visible = false;
            this.pnlNewTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNewTable_Paint);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblError.ForeColor = System.Drawing.Color.IndianRed;
            this.lblError.Location = new System.Drawing.Point(27, 351);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(288, 19);
            this.lblError.TabIndex = 19;
            this.lblError.Text = "table number alredy Exists in this space";
            this.lblError.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(27, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Table number";
            // 
            // pnlFormat
            // 
            this.pnlFormat.Controls.Add(this.label2);
            this.pnlFormat.Controls.Add(this.rbtnCircular);
            this.pnlFormat.Controls.Add(this.rbtnVertical);
            this.pnlFormat.Controls.Add(this.rbtnHorizantal);
            this.pnlFormat.Location = new System.Drawing.Point(4, 45);
            this.pnlFormat.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormat.Name = "pnlFormat";
            this.pnlFormat.Size = new System.Drawing.Size(417, 96);
            this.pnlFormat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Format";
            // 
            // pnlChairCount
            // 
            this.pnlChairCount.Controls.Add(this.rbtn4);
            this.pnlChairCount.Controls.Add(this.label3);
            this.pnlChairCount.Controls.Add(this.rbtn8);
            this.pnlChairCount.Controls.Add(this.rbtn12);
            this.pnlChairCount.Controls.Add(this.rbtn6);
            this.pnlChairCount.Controls.Add(this.rbtn10);
            this.pnlChairCount.Controls.Add(this.rbtn2);
            this.pnlChairCount.Location = new System.Drawing.Point(4, 151);
            this.pnlChairCount.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChairCount.Name = "pnlChairCount";
            this.pnlChairCount.Size = new System.Drawing.Size(417, 132);
            this.pnlChairCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(18, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chair count";
            // 
            // pnlTableButtons
            // 
            this.pnlTableButtons.Controls.Add(this.btnDeleteTable);
            this.pnlTableButtons.Controls.Add(this.btnEditTable);
            this.pnlTableButtons.Location = new System.Drawing.Point(679, 6);
            this.pnlTableButtons.Name = "pnlTableButtons";
            this.pnlTableButtons.Size = new System.Drawing.Size(94, 46);
            this.pnlTableButtons.TabIndex = 20;
            this.pnlTableButtons.Visible = false;
            // 
            // pnlTables
            // 
            this.pnlTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlTables.Controls.Add(this.pnlTableButtons);
            this.pnlTables.Controls.Add(this.pnlNewTable);
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTables.Location = new System.Drawing.Point(0, 48);
            this.pnlTables.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(1224, 547);
            this.pnlTables.TabIndex = 25;
            this.pnlTables.Click += new System.EventHandler(this.pnlTables_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnDeleteTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnDeleteTable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteTable.BorderRadius = 10;
            this.btnDeleteTable.BorderSize = 0;
            this.btnDeleteTable.FlatAppearance.BorderSize = 0;
            this.btnDeleteTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTable.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTable.Image = global::LaCucina.Properties.Resources.delete__2_;
            this.btnDeleteTable.Location = new System.Drawing.Point(1, 1);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteTable.TabIndex = 18;
            this.btnDeleteTable.TextColor = System.Drawing.Color.White;
            this.btnDeleteTable.UseVisualStyleBackColor = false;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnEditTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnEditTable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditTable.BorderRadius = 10;
            this.btnEditTable.BorderSize = 0;
            this.btnEditTable.FlatAppearance.BorderSize = 0;
            this.btnEditTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTable.ForeColor = System.Drawing.Color.White;
            this.btnEditTable.Image = global::LaCucina.Properties.Resources.edit__1_;
            this.btnEditTable.Location = new System.Drawing.Point(49, 1);
            this.btnEditTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(40, 40);
            this.btnEditTable.TabIndex = 19;
            this.btnEditTable.TextColor = System.Drawing.Color.White;
            this.btnEditTable.UseVisualStyleBackColor = false;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(130, 417);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(172, 39);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(130, 417);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTablenum
            // 
            this.txtTablenum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.txtTablenum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.txtTablenum.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.txtTablenum.BorderRadius = 10;
            this.txtTablenum.BorderSize = 1;
            this.txtTablenum.CustomPasswordChar = '●';
            this.txtTablenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablenum.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtTablenum.Location = new System.Drawing.Point(258, 300);
            this.txtTablenum.Margin = new System.Windows.Forms.Padding(6);
            this.txtTablenum.Multiline = false;
            this.txtTablenum.Name = "txtTablenum";
            this.txtTablenum.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.txtTablenum.PasswordChar = false;
            this.txtTablenum.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTablenum.PlaceholderFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTablenum.PlaceholderText = "";
            this.txtTablenum.Size = new System.Drawing.Size(128, 46);
            this.txtTablenum.TabIndex = 18;
            this.txtTablenum.Texts = "";
            this.txtTablenum.UnderlinedStyle = false;
            this.txtTablenum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTablenum_KeyPress);
            // 
            // rbtnCircular
            // 
            this.rbtnCircular.AutoSize = true;
            this.rbtnCircular.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rbtnCircular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnCircular.Location = new System.Drawing.Point(274, 42);
            this.rbtnCircular.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCircular.MinimumSize = new System.Drawing.Size(0, 31);
            this.rbtnCircular.Name = "rbtnCircular";
            this.rbtnCircular.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.rbtnCircular.Size = new System.Drawing.Size(103, 31);
            this.rbtnCircular.TabIndex = 9;
            this.rbtnCircular.Tag = "circular";
            this.rbtnCircular.Text = "Circular";
            this.rbtnCircular.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnCircular.UseVisualStyleBackColor = true;
            this.rbtnCircular.CheckedChanged += new System.EventHandler(this.rbtnCircular_CheckedChanged);
            // 
            // rbtnVertical
            // 
            this.rbtnVertical.AutoSize = true;
            this.rbtnVertical.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rbtnVertical.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnVertical.Location = new System.Drawing.Point(156, 44);
            this.rbtnVertical.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnVertical.MinimumSize = new System.Drawing.Size(0, 31);
            this.rbtnVertical.Name = "rbtnVertical";
            this.rbtnVertical.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.rbtnVertical.Size = new System.Drawing.Size(101, 31);
            this.rbtnVertical.TabIndex = 11;
            this.rbtnVertical.Tag = "vertical";
            this.rbtnVertical.Text = "Vertical";
            this.rbtnVertical.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnVertical.UseVisualStyleBackColor = true;
            // 
            // rbtnHorizantal
            // 
            this.rbtnHorizantal.AutoSize = true;
            this.rbtnHorizantal.Checked = true;
            this.rbtnHorizantal.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rbtnHorizantal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnHorizantal.Location = new System.Drawing.Point(22, 42);
            this.rbtnHorizantal.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnHorizantal.MinimumSize = new System.Drawing.Size(0, 31);
            this.rbtnHorizantal.Name = "rbtnHorizantal";
            this.rbtnHorizantal.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.rbtnHorizantal.Size = new System.Drawing.Size(120, 31);
            this.rbtnHorizantal.TabIndex = 10;
            this.rbtnHorizantal.TabStop = true;
            this.rbtnHorizantal.Tag = "horizontal";
            this.rbtnHorizantal.Text = "Horizantal";
            this.rbtnHorizantal.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnHorizantal.UseVisualStyleBackColor = true;
            // 
            // rbtn4
            // 
            this.rbtn4.AutoSize = true;
            this.rbtn4.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rbtn4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn4.Location = new System.Drawing.Point(126, 35);
            this.rbtn4.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn4.MinimumSize = new System.Drawing.Size(0, 31);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.rbtn4.Size = new System.Drawing.Size(58, 31);
            this.rbtn4.TabIndex = 16;
            this.rbtn4.Tag = "4";
            this.rbtn4.Text = "4";
            this.rbtn4.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn4.UseVisualStyleBackColor = true;
            // 
            // rbtn8
            // 
            this.rbtn8.AutoSize = true;
            this.rbtn8.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rbtn8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn8.Location = new System.Drawing.Point(320, 35);
            this.rbtn8.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn8.MinimumSize = new System.Drawing.Size(0, 31);
            this.rbtn8.Name = "rbtn8";
            this.rbtn8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.rbtn8.Size = new System.Drawing.Size(58, 31);
            this.rbtn8.TabIndex = 14;
            this.rbtn8.Tag = "8";
            this.rbtn8.Text = "8";
            this.rbtn8.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn8.UseVisualStyleBackColor = true;
            // 
            // rbtn12
            // 
            this.rbtn12.AutoSize = true;
            this.rbtn12.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rbtn12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn12.Location = new System.Drawing.Point(126, 83);
            this.rbtn12.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn12.MinimumSize = new System.Drawing.Size(0, 31);
            this.rbtn12.Name = "rbtn12";
            this.rbtn12.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.rbtn12.Size = new System.Drawing.Size(67, 31);
            this.rbtn12.TabIndex = 17;
            this.rbtn12.Tag = "12";
            this.rbtn12.Text = "12";
            this.rbtn12.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn12.UseVisualStyleBackColor = true;
            // 
            // rbtn6
            // 
            this.rbtn6.AutoSize = true;
            this.rbtn6.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rbtn6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn6.Location = new System.Drawing.Point(219, 35);
            this.rbtn6.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn6.MinimumSize = new System.Drawing.Size(0, 31);
            this.rbtn6.Name = "rbtn6";
            this.rbtn6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.rbtn6.Size = new System.Drawing.Size(58, 31);
            this.rbtn6.TabIndex = 13;
            this.rbtn6.Tag = "6";
            this.rbtn6.Text = "6";
            this.rbtn6.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn6.UseVisualStyleBackColor = true;
            // 
            // rbtn10
            // 
            this.rbtn10.AutoSize = true;
            this.rbtn10.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rbtn10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn10.Location = new System.Drawing.Point(22, 83);
            this.rbtn10.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn10.MinimumSize = new System.Drawing.Size(0, 31);
            this.rbtn10.Name = "rbtn10";
            this.rbtn10.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.rbtn10.Size = new System.Drawing.Size(67, 31);
            this.rbtn10.TabIndex = 15;
            this.rbtn10.Tag = "10";
            this.rbtn10.Text = "10";
            this.rbtn10.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn10.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Checked = true;
            this.rbtn2.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rbtn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn2.Location = new System.Drawing.Point(22, 35);
            this.rbtn2.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn2.MinimumSize = new System.Drawing.Size(0, 31);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.rbtn2.Size = new System.Drawing.Size(58, 31);
            this.rbtn2.TabIndex = 12;
            this.rbtn2.TabStop = true;
            this.rbtn2.Tag = "2";
            this.rbtn2.Text = "2";
            this.rbtn2.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn2.UseVisualStyleBackColor = true;
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
            this.rjPanel3.Location = new System.Drawing.Point(0, 595);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            this.rjPanel3.Size = new System.Drawing.Size(1224, 136);
            this.rjPanel3.TabIndex = 23;
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
            this.hfpnlSpaces.Paint += new System.Windows.Forms.PaintEventHandler(this.hfpnlSpaces_Paint);
            // 
            // rjPanel4
            // 
            this.rjPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjPanel4.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.rjPanel4.BorderRadius = 0;
            this.rjPanel4.BorderSize = 0;
            this.rjPanel4.Controls.Add(this.label4);
            this.rjPanel4.Controls.Add(this.materialDivider2);
            this.rjPanel4.Controls.Add(this.btnNewTable);
            this.rjPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjPanel4.ForeColor = System.Drawing.Color.Black;
            this.rjPanel4.Location = new System.Drawing.Point(0, 0);
            this.rjPanel4.Name = "rjPanel4";
            this.rjPanel4.Padding = new System.Windows.Forms.Padding(0, 4, 22, 4);
            this.rjPanel4.Size = new System.Drawing.Size(1224, 48);
            this.rjPanel4.TabIndex = 24;
            this.rjPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel4_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 31);
            this.label4.TabIndex = 31;
            this.label4.Text = "🗺️ Floorplan editor";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialDivider2.Location = new System.Drawing.Point(0, 43);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1110, 1);
            this.materialDivider2.TabIndex = 0;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // btnNewTable
            // 
            this.btnNewTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNewTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNewTable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewTable.BorderRadius = 10;
            this.btnNewTable.BorderSize = 0;
            this.btnNewTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNewTable.FlatAppearance.BorderSize = 0;
            this.btnNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTable.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTable.ForeColor = System.Drawing.Color.Black;
            this.btnNewTable.Location = new System.Drawing.Point(1110, 4);
            this.btnNewTable.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(92, 40);
            this.btnNewTable.TabIndex = 7;
            this.btnNewTable.Text = "New";
            this.btnNewTable.TextColor = System.Drawing.Color.Black;
            this.btnNewTable.UseVisualStyleBackColor = false;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // rjButton7
            // 
            this.rjButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rjButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.rjButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton7.BorderRadius = 10;
            this.rjButton7.BorderSize = 0;
            this.rjButton7.FlatAppearance.BorderSize = 0;
            this.rjButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton7.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.rjButton7.ForeColor = System.Drawing.Color.Black;
            this.rjButton7.Location = new System.Drawing.Point(0, 0);
            this.rjButton7.Margin = new System.Windows.Forms.Padding(0);
            this.rjButton7.Name = "rjButton7";
            this.rjButton7.Size = new System.Drawing.Size(142, 44);
            this.rjButton7.TabIndex = 2;
            this.rjButton7.Text = "Floor 3";
            this.rjButton7.TextColor = System.Drawing.Color.Black;
            this.rjButton7.UseVisualStyleBackColor = false;
            // 
            // rjButton8
            // 
            this.rjButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.rjButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.rjButton8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton8.BorderRadius = 10;
            this.rjButton8.BorderSize = 0;
            this.rjButton8.FlatAppearance.BorderSize = 0;
            this.rjButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton8.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.rjButton8.ForeColor = System.Drawing.Color.White;
            this.rjButton8.Location = new System.Drawing.Point(142, 0);
            this.rjButton8.Margin = new System.Windows.Forms.Padding(0);
            this.rjButton8.Name = "rjButton8";
            this.rjButton8.Size = new System.Drawing.Size(142, 44);
            this.rjButton8.TabIndex = 3;
            this.rjButton8.Text = "Floor 4";
            this.rjButton8.TextColor = System.Drawing.Color.White;
            this.rjButton8.UseVisualStyleBackColor = false;
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.rjButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 10;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Location = new System.Drawing.Point(284, 0);
            this.rjButton6.Margin = new System.Windows.Forms.Padding(0);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(142, 44);
            this.rjButton6.TabIndex = 1;
            this.rjButton6.Text = "Floor 2";
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.rjButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 10;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(426, 0);
            this.rjButton5.Margin = new System.Windows.Forms.Padding(0);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(142, 44);
            this.rjButton5.TabIndex = 0;
            this.rjButton5.Text = "Floor 1";
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            // 
            // USFloorplanEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.rjPanel3);
            this.Controls.Add(this.rjPanel4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USFloorplanEditor";
            this.Size = new System.Drawing.Size(1224, 731);
            this.Load += new System.EventHandler(this.FloorplanEditorUS_Load);
            this.pnlNewTable.ResumeLayout(false);
            this.pnlNewTable.PerformLayout();
            this.pnlFormat.ResumeLayout(false);
            this.pnlFormat.PerformLayout();
            this.pnlChairCount.ResumeLayout(false);
            this.pnlChairCount.PerformLayout();
            this.pnlTableButtons.ResumeLayout(false);
            this.pnlTables.ResumeLayout(false);
            this.rjPanel3.ResumeLayout(false);
            this.pnlSpases.ResumeLayout(false);
            this.rjPanel4.ResumeLayout(false);
            this.rjPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJButton rjButton5;
        private CustomControls.RJControls.RJButton rjButton6;
        private CustomControls.RJControls.RJButton rjButton7;
        private CustomControls.RJControls.RJButton rjButton8;
        private CustomControls.RJControls.RJButton btnNewTable;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private CustomControls.RJControls.RJPanel rjPanel4;
        private System.Windows.Forms.Panel pnlNewTable;
        private CustomControls.RJControls.RJButton btnAdd;
        private CustomControls.RJControls.RJTextBox txtTablenum;
        private CustomControls.RJControls.RJRadioButton rbtn12;
        private CustomControls.RJControls.RJRadioButton rbtn4;
        private CustomControls.RJControls.RJRadioButton rbtn10;
        private CustomControls.RJControls.RJRadioButton rbtn8;
        private CustomControls.RJControls.RJRadioButton rbtn6;
        private CustomControls.RJControls.RJRadioButton rbtn2;
        private CustomControls.RJControls.RJRadioButton rbtnVertical;
        private CustomControls.RJControls.RJRadioButton rbtnHorizantal;
        private CustomControls.RJControls.RJRadioButton rbtnCircular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlFormat;
        private System.Windows.Forms.Panel pnlChairCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblError;
        public CustomControls.RJControls.RJButton btnEditTable;
        public CustomControls.RJControls.RJButton btnDeleteTable;
        public System.Windows.Forms.Panel pnlTableButtons;
        private CustomControls.RJControls.RJButton btnEdit;
        private CustomControls.RJControls.RJPanel pnlSpases;
        private controls.HorizontalFlowPanel hfpnlSpaces;
        private CustomControls.RJControls.RJPanel rjPanel3;
        private System.Windows.Forms.Panel pnlTables;
    }
}
