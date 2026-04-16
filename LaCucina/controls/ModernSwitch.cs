using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernSwitch : CheckBox
{
    // ألوان متناسقة مع تصميمك (الخلفية الداكنة والبرتقالي)
    private Color _onColor = Color.FromArgb(255, 140, 0); // البرتقالي الزاهي الخاص بك
    private Color _offColor = Color.FromArgb(60, 60, 60); // رمادي غامق جداً للخلفية
    private Color _thumbColor = Color.White; // لون الدائرة (المقبض)
    private int _switchWidth = 40; // عرض المفتاح
    private int _switchHeight = 20; // ارتفاع المفتاح

    public ModernSwitch()
    {
        this.Cursor = Cursors.Hand; // تغيير المؤشر ليد عند الوقوف عليه
        this.DoubleBuffered = true; // لمنع الوميض (Flickering)
        this.Font = new Font("Segoe UI", 11F); // خط مودرن وواضح
        this.ForeColor = Color.White; // لون النص أبيض
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        Graphics g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias; // لتنعيم الحواف

        // مسح الخلفية القديمة
        g.Clear(this.Parent.BackColor);

        // 1. رسم مستطيل الخلفية (المسار)
        Rectangle switchRect = new Rectangle(0, (Height - _switchHeight) / 2, _switchWidth, _switchHeight);
        GraphicsPath path = GetRoundedRect(switchRect, _switchHeight / 2);

        using (SolidBrush brush = new SolidBrush(Checked ? _onColor : _offColor))
        {
            g.FillPath(brush, path);
        }

        // 2. رسم الدائرة (المقبض - Thumb)
        int thumbSize = _switchHeight - 4; // أصغر قليلاً من الخلفية
        int thumbX = Checked ? (_switchWidth - thumbSize - 2) : 2; // موقع الدائرة بناءً على الحالة
        int thumbY = (Height - thumbSize) / 2;

        using (SolidBrush thumbBrush = new SolidBrush(_thumbColor))
        {
            g.FillEllipse(thumbBrush, thumbX, thumbY, thumbSize, thumbSize);
        }

        // 3. رسم النص بجانب المفتاح
        using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
        {
            g.DrawString(this.Text, this.Font, textBrush, _switchWidth + 10, (Height - Font.Height) / 2);
        }
    }

    // دالة مساعدة لرسم مستطيل بزوايا منحنية (Rounded Rectangle)
    private GraphicsPath GetRoundedRect(Rectangle rect, float radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();
        path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
        path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
        path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
        path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
        path.CloseFigure();
        return path;
    }
}