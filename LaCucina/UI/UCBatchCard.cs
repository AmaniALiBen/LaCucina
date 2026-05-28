using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina.UI
{
    public partial class UCBatchCard : UserControl
    {
        int secondsElapsed=0;
        public UCBatchCard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void pnlContiner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderTimer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;

            TimeSpan time = TimeSpan.FromSeconds(secondsElapsed);
            lblTime.Text = time.ToString(@"mm\:ss");
           

            if (secondsElapsed < 18)
            {
                pnlColor.BackColor = Color.DarkGray;
            }

            else if (secondsElapsed >= 18 && secondsElapsed < 30)
            {
                pnlColor.BackColor = Color.FromArgb(255, 255, 193, 7);
            }

            else if (secondsElapsed >= 30 && secondsElapsed < 60)
            {
                pnlColor.BackColor = Color.FromArgb(255, 255, 152, 0);
            }
            else
            {
                pnlColor.BackColor = Color.FromArgb(255, 244, 67, 54);

            }

        }

        private void pnlColor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
