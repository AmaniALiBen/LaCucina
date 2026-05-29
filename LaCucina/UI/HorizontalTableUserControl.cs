using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using LaCucina.Models;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class HorizontalTableUserControl : UCtable
    {
        public override Label TargetlblTableNum => this.lblTableNum;
        public override Label TargetlblTableStatus => this.lblTableStatus;
        public HorizontalTableUserControl(int id,string tableNum,int chairCount,TableStatus tableStatus, bool isInEditingMode) : base(id,tableNum, chairCount, tableStatus, isInEditingMode)
        {
            InitializeComponent();
           
             BuildTable();
            
        }

        public override void BuildTable()
        {
            base.BuildTable();
            createChairs();
            AdjustTableSize();
        }

        public void AdjustTableSize()
        {

            if (chairCount > 4)
            {
                int width = chairCount *22;
                pnlTable.Size = new System.Drawing.Size(width, 80);
            }
            this.Size = new System.Drawing.Size(pnlTable.Size.Width+34,this.Height);
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

        private void HorizontalTableUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
