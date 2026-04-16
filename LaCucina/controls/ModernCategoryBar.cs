using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

public class ModernCategoryBar : FlowLayoutPanel
{
    [DllImport("user32.dll")]
    private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
    private const int SB_BOTH = 3;

    public ModernCategoryBar()
    {
        // تحسين الأداء ومنع الوميض
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.UserPaint, true);

        this.AutoScroll = true;

        // أهم سطرين للأفقي 👇
        this.FlowDirection = FlowDirection.LeftToRight;
        this.WrapContents = false; // يمنع النزول لسطر جديد
    }

    // تمرير أفقي بعجلة الماوس
    protected override void OnMouseWheel(MouseEventArgs e)
    {
        int scrollStep = 50;
        int delta = e.Delta > 0 ? -scrollStep : scrollStep;

        this.AutoScrollPosition = new Point(
            Math.Abs(this.AutoScrollPosition.X) + delta,
            0
        );

        ((HandledMouseEventArgs)e).Handled = true;
    }

    // إخفاء السكرول بار
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
        SetDoubleBuffered(e.Control);
    }

    private void SetDoubleBuffered(Control control)
    {
        var prop = typeof(Control).GetProperty(
            "DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

        prop?.SetValue(control, true, null);
    }
}