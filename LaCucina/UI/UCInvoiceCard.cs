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
    public partial class UCInvoiceCard : UserControl
    {
        int secondsElapsed = 0;
        public UCInvoiceCard()
        {
            InitializeComponent();
            
        }

        public string OrderNum
        {
            get => lblOrderNum.Text;
            set => lblOrderNum.Text = value;
        }
        public string TableNum
        {
            get => lblTableNum.Text;
            set => lblTableNum.Text = value;
        }
        private void orderTimer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;

            TimeSpan time = TimeSpan.FromSeconds(secondsElapsed);
            lblTime.Text = time.ToString(@"mm\:ss");

            if (secondsElapsed < 18) 
            {

                //rjPanel2.BorderColor = Color.LimeGreen;
                //rjPanel1.BackColor = Color.LimeGreen;
                rjPanel2.BorderColor = Color.FromArgb(255, 76, 175, 80);
                rjPanel1.BackColor = Color.FromArgb(255, 76, 175, 80);
                this.DoubleBuffered = true;
            }
            else if (secondsElapsed >= 18 && secondsElapsed < 30) 
            {
                //rjPanel2.BorderColor = Color.Yellow;
                //rjPanel1.BackColor = Color.Yellow;
                rjPanel2.BorderColor = Color.FromArgb(255, 255, 193, 7);
                rjPanel1.BackColor = Color.FromArgb(255, 255, 193, 7);
                this.DoubleBuffered = true;
            }

            else if (secondsElapsed >= 30 && secondsElapsed < 60) 
            {
                //rjPanel2.BorderColor = Color.Orange;
                //rjPanel1.BackColor = Color.Orange;
                rjPanel2.BorderColor = Color.FromArgb(255, 255, 152, 0);
                rjPanel1.BackColor = Color.FromArgb(255, 255, 152, 0);
                this.DoubleBuffered = true;
            }
            else 
            {
                //rjPanel2.BorderColor = Color.Red;
                //rjPanel1.BackColor = Color.Red;
                rjPanel2.BorderColor = Color.FromArgb(255, 244, 67, 54);
                rjPanel1.BackColor = Color.FromArgb(255, 244, 67, 54);
                this.DoubleBuffered = true;

            }
        }

        private void rjPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTableNum_Click(object sender, EventArgs e)
        {

        }
    }
}
