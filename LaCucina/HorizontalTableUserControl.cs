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
    public partial class HorizontalTableUserControl : UserControl
    {
        public string tableNum;
        public int chairCount;
        public string tableStatus;

        public HorizontalTableUserControl(string tableNum,int chairCount,string tableStatus)
        {
            InitializeComponent();
            this.tableNum=tableNum;
            this.chairCount=chairCount;
            this.tableStatus=tableStatus;
            BuildTable();

        }

        public void BuildTable()
        {
            lblTableNum.Text = tableNum;
            lblTableStatus.Text =tableStatus;
            AdjustTableSize();
            adjustStatusColor();
            createChairs();


        }

        public void AdjustTableSize()
        {

            if (chairCount > 4)
            {
                int width = chairCount *22;
                pnlTable.Size = new System.Drawing.Size(width, 80);
            }
            this.Size = new System.Drawing.Size(pnlTable.Size.Width+44,this.Height);
        }

        public void adjustStatusColor() 
        {
            if (tableStatus == "occupied")
            {
                pnlStatusColor.GradientBottomColor = Color.FromArgb(255, 249, 115, 22);
                pnlStatusColor.GradientTopColor= Color.FromArgb(255, 249, 115, 22);
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
                case 12: pnlSeat10.Visible = true; pnlSeat9.Visible = true;goto case 10;
                case 10:pnlSeat8.Visible = true; pnlSeat7.Visible = true; goto case 8;
                case 8: pnlSeat6.Visible = true; pnlSeat5.Visible = true; goto case 6;
                case 6: pnlSeat4.Visible = true; pnlSeat3.Visible = true; goto case 4;
                case 4: pnlRightSeat.Visible = true;pnlLeftSeat.Visible = true;break;


            }

            if (chairCount > 4)
            {
                int x = (chairCount+1) *22;
                int y = pnlLeftSeat.Location.Y;

                pnlLeftSeat.Location = new System.Drawing.Point(x, y);
            }

        }

        private void lblTableNum_Click(object sender, EventArgs e)
        {

        }
    }
}
