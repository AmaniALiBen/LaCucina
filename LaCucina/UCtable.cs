using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.RJControls;


namespace LaCucina
{

    public   partial class UCtable : UserControl
    {
        public string tableNum;
        public int chairCount;
        public string tableStatus;
        public bool isInEditingMode;

        private bool isDragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;



        public static UCtable lastSelectedTable=null;
        public virtual Label TargetlblTableNum { get; }
        public virtual Label TargetlblTableStatus { get; }

        public UCtable() { }

        public UCtable(string tableNum, int chairCount, string tableStatus,bool isInEditingMode)
        {
            InitializeComponent();
            this.tableNum = tableNum;
            this.chairCount = chairCount;
            this.tableStatus = tableStatus;
            this.isInEditingMode = isInEditingMode;
           
        }

        public virtual void BuildTable()
        {
            TargetlblTableNum.Text = tableNum;
            if (!isInEditingMode)
            {
                TargetlblTableStatus.Text = tableStatus;
                adjustStatusColor();
            }

            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += (s, e) => SelectTable();
                ctrl.MouseDown += HandleMouseDown;
                ctrl.MouseMove += HandleMouseMove;
                ctrl.MouseUp += HandleMouseUp;



                foreach (Control sub in ctrl.Controls)
                {
                    sub.Click += (s, e) => SelectTable();
                    sub.MouseDown += HandleMouseDown;
                    sub.MouseMove += HandleMouseMove;
                    sub.MouseUp += HandleMouseUp;
                }

            }

            


        }


        public void adjustStatusColor()
        {
            if (tableStatus == "occupied")
            {


                foreach (RJgradiantPanal item in this.Controls)
                {
                    item.GradientBottomColor = Color.FromArgb(230, 126, 34);
                    item.GradientTopColor = Color.FromArgb(255, 161, 59);


                }

            }

            else if (tableStatus == "vacant")
            {

                foreach (RJgradiantPanal item in this.Controls)
                {
                    item.GradientBottomColor = Color.FromArgb(255, 76, 175, 80);
                    item.GradientTopColor = Color.FromArgb(255, 129, 199, 132);

                }

            }



        }


        public void SelectTable() 
        {
            if (isInEditingMode)
            {
                if (lastSelectedTable != null && lastSelectedTable != this)
                {
                    foreach (RJgradiantPanal item in lastSelectedTable.Controls)
                    {

                        item.BorderSize = 0;

                    }


                }
                foreach (RJgradiantPanal item in this.Controls)
                {

                    item.BorderSize = 1;

                }
            }

            else { 
                Test test = new Test();
                test.Show();
                

            
            }
                lastSelectedTable = this;


        }

        private void HandleMouseDown(object sender, MouseEventArgs e)
        {
            if (isInEditingMode && e.Button == MouseButtons.Left)
            {
                SelectTable();
                isDragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
                this.Cursor = Cursors.SizeAll;
                this.BringToFront();
            }
        }

        private void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int difX = Cursor.Position.X - dragCursorPoint.X;
                int difY = Cursor.Position.Y - dragCursorPoint.Y;
                this.Location = new Point(dragFormPoint.X + difX, dragFormPoint.Y + difY);
            }
        }

        private void HandleMouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            this.Cursor = Cursors.Default;
        }

        private void UCtable_Load(object sender, EventArgs e)
        {

        }
    }
}





