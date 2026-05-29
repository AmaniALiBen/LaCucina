using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using LaCucina.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class CircularTableUserControl : UCtable
    {
        public override Label TargetlblTableNum => this.lblTableNum;
        public override Label TargetlblTableStatus => this.lblTableStatus;

        public CircularTableUserControl(int id, string tableNum, int chairCount, TableStatus tableStatus, bool isInEditingMode) : base(id,tableNum, chairCount, tableStatus, isInEditingMode)
        {
            InitializeComponent();
          
            BuildTable();
            
        }
        public override void BuildTable()
        {
            base.BuildTable();
            createChairs();

        }

       
        public void createChairs()
        {

            if (chairCount == 4)
            {
                pnlSeat4.Visible = true; 
                pnlSeat3.Visible = true;
            }


           

           

        }

        private void CircularTableUserControl_Load(object sender, EventArgs e)
        {

        }
    }

}