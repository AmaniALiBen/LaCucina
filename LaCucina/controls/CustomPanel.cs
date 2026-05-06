using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomPanel : Panel
{
    private int _opacity = 125; // نسبة الشفافية
    private Color _borderColor = Color.FromArgb(100, 255, 255, 255); // لون الحدود (أبيض شفاف)
    private int _borderRadius = 15; // زاوية الانحناء

    public int Opacity { get => _opacity; set { _opacity = value; Invalidate(); } }
    public Color BorderColor { get => _borderColor; set { _borderColor = value; Invalidate(); } }
    public int BorderRadius { get => _borderRadius; set { _borderRadius = value; Invalidate(); } }

    public CustomPanel()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        SetStyle(ControlStyles.Opaque, false);
        this.BackColor = Color.Transparent;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (var brush = new SolidBrush(Color.FromArgb(_opacity, 18, 18, 18))) // لون الخلفية الداكن الشفاف
        using (var pen = new Pen(_borderColor, 1))
        using (var path = GetRoundedRectanglePath(ClientRectangle, _borderRadius))
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(brush, path); // ملء الخلفية
            e.Graphics.DrawPath(pen, path);  // رسم الحدود
        }
    }

    private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        float diameter = radius * 2.0F;
        path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
        path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
        path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();
        return path;
    }
}