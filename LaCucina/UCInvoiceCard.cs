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

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
        

        private void orderTimer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;

            TimeSpan time = TimeSpan.FromSeconds(secondsElapsed);
            lblTime.Text = time.ToString(@"mm\:ss");

            if (secondsElapsed < 18) 
            {
               
                rjPanel2.BorderColor = Color.LimeGreen;
            }
            else if (secondsElapsed >= 18 && secondsElapsed < 30) 
            {
                rjPanel2.BorderColor = Color.Yellow;
            }
            else if (secondsElapsed >= 30 && secondsElapsed < 60) 
            {
                rjPanel2.BorderColor = Color.Orange;
            }
            else 
            {
                rjPanel2.BorderColor = Color.Red;

               
            }
        }

        private void rjPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
