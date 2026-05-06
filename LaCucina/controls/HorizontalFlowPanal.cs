using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace LaCucina.controls
{
    internal class HorizontalFlowPanel : FlowLayoutPanel
    {
        [DllImport("user32.dll")]
        private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
        private const int SB_BOTH = 3;
        private const int WM_MOUSEHWHEEL = 0x020E;

        public bool ReverseDirection = true;

        public HorizontalFlowPanel()
        {
            this.DoubleBuffered = true;
            this.AutoScroll = true;
            this.FlowDirection = FlowDirection.LeftToRight;
            this.WrapContents = false;
            this.Padding = new Padding(0);
            this.Margin = new Padding(0);
        }

        // Calculate exact content width
        private int GetContentWidth()
        {
            if (this.Controls.Count == 0) return this.Width;

            int totalWidth = 0;
            foreach (Control ctrl in this.Controls)
            {
                totalWidth += ctrl.Width + ctrl.Margin.Left + ctrl.Margin.Right;
            }
            return totalWidth;
        }

        // Update scroll area to exact content size
        private void UpdateScrollArea()
        {
            int contentWidth = GetContentWidth();
            int scrollWidth = Math.Max(contentWidth, this.Width);
            this.AutoScrollMinSize = new Size(scrollWidth, 0);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.Margin = new Padding(0);
            UpdateScrollArea();
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            UpdateScrollArea();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateScrollArea();
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            UpdateScrollArea();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MOUSEHWHEEL)
            {
                int delta = (short)((m.WParam.ToInt64() >> 16) & 0xFFFF);
                int scrollStep = 60;
                int currentX = Math.Abs(this.AutoScrollPosition.X);
                int newX;

                if (!ReverseDirection)
                {
                    newX = delta > 0 ? currentX - scrollStep : currentX + scrollStep;
                }
                else
                {
                    newX = delta > 0 ? currentX + scrollStep : currentX - scrollStep;
                }

                // Calculate maximum scroll (last button exactly at the end)
                int maxScroll = Math.Max(0, GetContentWidth() - this.Width);
                newX = Math.Max(0, Math.Min(newX, maxScroll));

                this.AutoScrollPosition = new Point(newX, 0);
                this.Refresh();

                m.Result = (IntPtr)1;
                return;
            }

            base.WndProc(ref m);

            if (this.Handle != IntPtr.Zero)
            {
                ShowScrollBar(this.Handle, SB_BOTH, false);
            }
        }
    }
}