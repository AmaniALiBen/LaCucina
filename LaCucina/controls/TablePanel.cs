using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina.controls
{
    internal class TablePanel : FlowLayoutPanel
    {
        // لإخفاء شريط التمرير
        [DllImport("user32.dll")]
        private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
        private const int SB_BOTH = 3;

        public TablePanel()
        {
            // 1. تفعيل التخزين المؤقت المزدوج لمنع الوميض (Flickering)
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);

            this.AutoScroll = true;
        }

        // 2. تحسين استجابة عجلة الماوس لجعلها "أنعم" وأسرع
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            // بدلاً من التمرير الافتراضي البطيء، سنقوم بحساب المسافة يدوياً
            int scrollStep = 50; // يمكنك زيادة هذا الرقم لزيادة السرعة
            int delta = e.Delta > 0 ? -scrollStep : scrollStep;

            this.AutoScrollPosition = new Point(0, Math.Abs(this.AutoScrollPosition.Y) + delta);

            // نمنع الحدث الأصلي من التأثير لكي لا يحدث تضارب
            ((HandledMouseEventArgs)e).Handled = true;
        }

        // 3. ضمان إخفاء شريط التمرير في كل الحالات
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (this.Handle != IntPtr.Zero)
            {
                ShowScrollBar(this.Handle, SB_BOTH, false);
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.Width = this.ClientSize.Width - e.Control.Margin.Left - e.Control.Margin.Right;
            // تفعيل الـ DoubleBuffered للعناصر المضافة أيضاً لضمان سلاسة حركتها
            SetDoubleBuffered(e.Control);
           
        }

        private void SetDoubleBuffered(Control control)
        {
            System.Reflection.PropertyInfo propertyInfo = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propertyInfo?.SetValue(control, true, null);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            // هذا الكود يضمن أن جميع الصفوف ستتمدد فوراً عند تغيير حجم الشاشة
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Width = this.ClientSize.Width - ctrl.Margin.Left - ctrl.Margin.Right;
            }
        }
    }
   

        
    }

