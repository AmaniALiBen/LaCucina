using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

public class SmoothDraggablePanel : FlowLayoutPanel
{
    [DllImport("user32.dll")]
    private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
    private const int SB_BOTH = 3;

    private Point lastPoint;
    private bool isDragging = false;

    public SmoothDraggablePanel()
    {
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.UserPaint, true);

        this.AutoScroll = true;

        this.FlowDirection = FlowDirection.LeftToRight;
        this.WrapContents = false;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        isDragging = true;
        lastPoint = e.Location;
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);

        if (isDragging)
        {
            int dx = e.X - lastPoint.X;

            this.AutoScrollPosition = new Point(
                Math.Abs(this.AutoScrollPosition.X) - dx,
                0
            );

            lastPoint = e.Location;
        }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        isDragging = false;
    }

    // Mouse Wheel أفقي
    protected override void OnMouseWheel(MouseEventArgs e)
    {
        int scrollStep = 50;

        // 👇 ناخذ السكرول العمودي ونستخدمه كأفقي
        int delta = e.Delta > 0 ? -scrollStep : scrollStep;

        this.AutoScrollPosition = new Point(
            Math.Abs(this.AutoScrollPosition.X) + delta,
            0
        );

        ((HandledMouseEventArgs)e).Handled = true;
    }

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
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance);

        prop?.SetValue(control, true, null);
    }
}