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
    public partial class VerticalTableUserControl : UserControl
    {
        public string tableNum;
        public int chairCount;
        public string tableStatus;
        public VerticalTableUserControl(string tableNum, int chairCount, string tableStatus)
        {
            InitializeComponent();
            this.tableNum = tableNum;
            this.chairCount = chairCount;
            this.tableStatus = tableStatus;
            BuildTable();
        }
        public void BuildTable()
        {
            lblTableNum.Text = tableNum;
            lblTableStatus.Text = tableStatus;
            AdjustTableSize();
            adjustStatusColor();
            createChairs();


        }

        public void AdjustTableSize()
        {

            if (chairCount > 4)
            {
                int hight = chairCount * 22;
                pnlTable.Size = new System.Drawing.Size(80, hight);
            }
            this.Size = new System.Drawing.Size(this.Width, pnlTable.Size.Height+44);
        }


        public void adjustStatusColor()
        {
            if (tableStatus == "occupied")
            {
                pnlStatusColor.GradientBottomColor = Color.FromArgb(255, 249, 115, 22);
                pnlStatusColor.GradientTopColor = Color.FromArgb(255, 249, 115, 22);
            }
            else if (tableStatus == "vacant")
            {
                pnlStatusColor.GradientBottomColor = Color.FromArgb(255, 249, 115, 22);
                pnlStatusColor.GradientTopColor = Color.FromArgb(255, 249, 115, 22);
            }

        }

        public void createChairs()
        {
            switch (chairCount)
            {
                case 12: pnlSeat10.Visible = true; pnlSeat9.Visible = true; goto case 10;
                case 10: pnlSeat8.Visible = true; pnlSeat7.Visible = true; goto case 8;
                case 8: pnlSeat6.Visible = true; pnlSeat5.Visible = true; goto case 6;
                case 6: pnlSeat4.Visible = true; pnlSeat3.Visible = true; goto case 4;
                case 4: pnlTopSeat.Visible = true; pnlBottomSeat.Visible = true; break;
                  


            }

            if (chairCount > 4)
            {
                int y = (chairCount + 1) * 22;
                int  x= pnlBottomSeat.Location.X;

                pnlBottomSeat.Location = new System.Drawing.Point(x, y);
            }

            lblTableStatus.Location = new System.Drawing.Point(lblTableStatus.Location.X, pnlBottomSeat.Location.Y - 50);
            lblTableNum.Location = new System.Drawing.Point(lblTableNum.Location.X,lblTableStatus.Location.Y - 40);
            pnlStatusColor.Size = new System.Drawing.Size(pnlStatusColor.Size.Width,pnlTable.Size.Height);
        }
    }
}
