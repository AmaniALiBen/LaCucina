using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LaCucina.controls
{
    internal class TablePanel : FlowLayoutPanel
    {
        [DllImport("user32.dll")]
        private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
        private const int SB_BOTH = 3;

        // 1. تعريف حدث مخصص يظهر في الفورم الرئيسي
        public event EventHandler RowDoubleClicked;

        public TablePanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.AutoScroll = true;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.Width = this.ClientSize.Width - e.Control.Margin.Left - e.Control.Margin.Right;
            SetDoubleBuffered(e.Control);

            // 2. السحر هنا: أي عنصر يضاف، نربط حدث الدبل كليك بتاعه وبتاع أولاده بالحدث الموحد
            BindControlEvents(e.Control);
        }

        private void BindControlEvents(Control ctrl)
        {
            // نربط العنصر نفسه
            ctrl.DoubleClick += (s, ev) => OnRowDoubleClicked(ctrl);

            // نربط كل العناصر اللي داخله (Labels, Pictures, etc.)
            foreach (Control child in ctrl.Controls)
            {
                child.DoubleClick += (s, ev) => OnRowDoubleClicked(ctrl);

                // لو فيه حاويات داخلية (Panel داخل الـ UC)
                if (child.HasChildren) BindControlEventsRecursive(child, ctrl);
            }
        }

        private void BindControlEventsRecursive(Control parent, Control rootUC)
        {
            foreach (Control child in parent.Controls)
            {
                child.DoubleClick += (s, ev) => OnRowDoubleClicked(rootUC);
                if (child.HasChildren) BindControlEventsRecursive(child, rootUC);
            }
        }

        protected virtual void OnRowDoubleClicked(Control row)
        {
            // نرسل الصف بالكامل (الـ UC) في الـ sender
            RowDoubleClicked?.Invoke(row, EventArgs.Empty);
        }

        // --- باقي الكود الأصلي الخاص بك (WndProc, OnResize, etc.) ---
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            int scrollStep = 50;
            int delta = e.Delta > 0 ? -scrollStep : scrollStep;
            this.AutoScrollPosition = new Point(0, Math.Abs(this.AutoScrollPosition.Y) + delta);
            ((HandledMouseEventArgs)e).Handled = true;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (this.Handle != IntPtr.Zero) ShowScrollBar(this.Handle, SB_BOTH, false);
        }

        private void SetDoubleBuffered(Control control)
        {
            System.Reflection.PropertyInfo propertyInfo = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propertyInfo?.SetValue(control, true, null);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Width = this.ClientSize.Width - ctrl.Margin.Left - ctrl.Margin.Right;
            }
        }
    }
}