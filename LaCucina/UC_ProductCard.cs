using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UC_ProductCard : UserControl
    {
        public string ItemName { get => lblName.Text; set => lblName.Text = value; }
        public string ItemPrice { get => lblPrice.Text; set => lblPrice.Text = value; }
        public Image imgItem { get => picBox.Image; set => picBox.Image = value; }
        public UC_ProductCard()
        {
            InitializeComponent();
            BindClickEvent(this);
        }
    
    private void BindClickEvent(Control parent)
    {
        foreach (Control c in parent.Controls)
        {
            if (c is PictureBox)
            {
                c.Click += (s, e) => this.OnClick(e);
            }
           /* else if (c is Label)
            {
             
                c.Enabled = false;

                // c.Click += (s, e) => this.OnClick(e);
            }*/
            else if (c.HasChildren)
            {
                BindClickEvent(c);
            }
            else
            {
                c.Click += (s, e) => this.OnClick(e);
            }
        }

       
    }
        private void UC_ProductCard_Load(object sender, EventArgs e)
        {

        }
    }


}
