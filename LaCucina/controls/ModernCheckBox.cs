using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernCheckBox : CheckBox
{
    // ألوان مخصصة يمكنك تغييرها من الخصائص
    public Color CheckedColor { get; set; } = Color.FromArgb(212, 175, 55); // لون ذهبي Luxury
    public Color UnCheckedColor { get; set; } = Color.LightGray;

    public ModernCheckBox()
    {
        this.Cursor = Cursors.Hand;
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        Graphics g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        // مسح الخلفية القديمة
        g.Clear(this.Parent.BackColor);

        // رسم المربع الخارجي بزوايا منحنية (Rounded Rect)
        Rectangle rect = new Rectangle(0, (Height / 2) - 9, 18, 18);
        using (Pen pen = new Pen(Checked ? CheckedColor : UnCheckedColor, 2))
        {
            g.DrawRectangle(pen, rect);
        }

        // إذا كان مختاراً، نرسم علامة الصح أو مربع صغير داخلي
        if (Checked)
        {
            using (SolidBrush brush = new SolidBrush(CheckedColor))
            {
                // رسم مربع داخلي صغير كعلامة اختيار (أكثر مودرن من الصح التقليدية)
                g.FillRectangle(brush, rect.X + 4, rect.Y + 4, 11, 11);
            }
        }

        // رسم النص بجانب المربع
        using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
        {
            g.DrawString(this.Text, this.Font, textBrush, 25, (Height / 2) - (Font.Height / 2));
        }
    }
}