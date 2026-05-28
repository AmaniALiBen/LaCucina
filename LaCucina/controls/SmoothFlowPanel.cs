using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

public class SmoothFlowPanel : FlowLayoutPanel
{
    // لإخفاء شريط التمرير
    [DllImport("user32.dll")]
    private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
    private const int SB_BOTH = 3;

    public SmoothFlowPanel()
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
        // حساب المسافة يدوياً لتسريع السكرول
        int scrollStep = 50;
        int delta = e.Delta > 0 ? -scrollStep : scrollStep;
        this.AutoScrollPosition = new Point(0, Math.Abs(this.AutoScrollPosition.Y) + delta);

        // ---- التعديل الآمن لمنع الكراش ----
        // نقوم بعمل تحويل آمن باستخدام (as) بدلاً من الكاست الإجباري القديم
        var handledArgs = e as HandledMouseEventArgs;
        if (handledArgs != null)
        {
            // نمنع الحدث الأصلي فقط إذا كان يدعم الخاصية
            handledArgs.Handled = true;
        }
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
        // تفعيل الـ DoubleBuffered للعناصر المضافة أيضاً لضمان سلاسة حركتها
        SetDoubleBuffered(e.Control);
    }

    private void SetDoubleBuffered(Control control)
    {
        System.Reflection.PropertyInfo propertyInfo = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        propertyInfo?.SetValue(control, true, null);
    }
}
