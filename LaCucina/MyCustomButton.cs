using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaCucina

{
    public class MyCustomButton : Button
    {
        private Button button1;
        private Panel panel1;

        public MyCustomButton()
        {
            this.BackColor = Color.Beige;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.ForeColor = Color.Black;
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    public class MyCustomePanel: Panel
    {
        public MyCustomePanel()
        {
            this.BackColor = Color.LightBlue;
           
            this.ForeColor = Color.Black;

        }

    }


    public class MyCustomLable : Label
    {

        public MyCustomLable()
        {
            this.BackColor = Color.LightBlue;
            this.FlatStyle = FlatStyle.Flat;
           
            this.ForeColor = Color.Black;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}