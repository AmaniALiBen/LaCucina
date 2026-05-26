using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using CustomControls.RJControls;
using LaCucina.Services;


namespace LaCucina
{

    public partial class UCtable : UserControl
    {FloorPlanService service =new FloorPlanService();

        public int id;
        public string tableNum;
        public int chairCount;
        public TableStatus tableStatus;
        public bool isInEditingMode;
        int offsetx, offsety;

        private bool isDragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Panel pnlTableButtons;






        public static UCtable lastSelectedTable=null;

        public virtual Label TargetlblTableNum { get; }
        public virtual Label TargetlblTableStatus { get; }

        public UCtable() { }

        public UCtable(int id,string tableNum, int chairCount, TableStatus tableStatus,bool isInEditingMode)
        {
            InitializeComponent();
            this.id = id;
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
                
                TargetlblTableStatus.Text =  tableStatus.ToString();
                adjustStatusColor();
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Click += (s, e) =>
                    {
                        POSForm f = new POSForm();
                        f.Show(this);
                    };
                    foreach (Control sub in ctrl.Controls)
                    {
                        sub.Click += (s, e) => 
                        {
                            POSForm f = new POSForm();
                            f.Show(this);
                        };
                    }

                }
            }
            if(isInEditingMode)
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
            if (tableStatus ==TableStatus.preparing)
            {


                foreach (RJgradiantPanal item in this.Controls)
                {
                    item.GradientBottomColor = Color.FromArgb(230, 126, 34);
                    item.GradientTopColor = Color.FromArgb(255, 161, 59);


                }

            }

            else if (tableStatus == TableStatus.vacant)
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
            pnlTableButtons = this.Parent.Controls.Find("pnlTableButtons", true).FirstOrDefault() as Panel;
           
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
                POSForm test = new POSForm(this.FindForm());
                test.Show();
                

            
            }
                lastSelectedTable = this;


        }

        private void HandleMouseDown(object sender, MouseEventArgs e)
        {
            if (isInEditingMode && e.Button == MouseButtons.Left)
            {
                
                
                SelectTable();
                pnlTableButtons.Location = new Point(this.Location.X + this.Width - pnlTableButtons.Width, this.Location.Y - pnlTableButtons.Height - 10);
               
                pnlTableButtons.Visible = true;

                isDragging = true;
                //الفرق بين المكان اللي ضغطنا فيه على الماوس ومكان الطاولة باش مايشدهاش من الحاشية
                offsetx = Cursor.Position.X - this.Location.X;
                offsety = Cursor.Position.Y - this.Location.Y;
                this.Cursor = Cursors.SizeAll;
                
                this.BringToFront();
            }
        }

        private void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                pnlTableButtons.Visible = false;

                int newX = Cursor.Position.X - offsetx;
                int newY = Cursor.Position.Y - offsety;
                //حدود البانل اللي الطاولة فيها باش ماتطلعش منها
                int minX = 0;
                int minY = 0;
                int maxX = this.Parent.Width-this.Width;
                int maxY = this.Parent.Height-this.Height;
                newX = Math.Max(minX, Math.Min(newX, maxX));
                newY=Math.Max(minY, Math.Min(newY, maxY));

                this.Location= new Point(newX, newY);

                
            }
        }

        private void HandleMouseUp(object sender, MouseEventArgs e)
        {
            pnlTableButtons.Location = new Point(this.Location.X + this.Width - pnlTableButtons.Width, this.Location.Y - pnlTableButtons.Height - 10);


            pnlTableButtons.Visible = true;
            isDragging = false;
            this.Cursor = Cursors.Default;
            service.editLocation(this.id, this.Location);


        }

        private void UCtable_Load(object sender, EventArgs e)
        {

        }
    }
}





