using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class UltraSmoothNavPanel : SmoothDraggablePanel
{
    private Timer animTimer;
    private RectangleF currentRect; // موقع الخلفية الحالي
    private RectangleF targetRect;  // الموقع المستهدف
    private float lerpSpeed = 0.15f; // سرعة الانزلاق (من 0 إلى 1)

    public UltraSmoothNavPanel()
    {
        animTimer = new Timer { Interval = 15 };
        animTimer.Tick += (s, e) => {
            // معادلة الحركة السلسة (Linear Interpolation)
            currentRect.X += (targetRect.X - currentRect.X) * lerpSpeed;
            currentRect.Width += (targetRect.Width - currentRect.Width) * lerpSpeed;
            currentRect.Y = targetRect.Y;
            currentRect.Height = targetRect.Height;

            // توفير استهلاك المعالج عند التوقف
            if (Math.Abs(currentRect.X - targetRect.X) < 0.1)
            {
                currentRect = targetRect;
                animTimer.Stop();
            }
            this.Invalidate();
        };

        this.Padding = new Padding(10);
    }

    protected override void OnControlAdded(ControlEventArgs e)
    {
        base.OnControlAdded(e);
        if (e.Control is Button btn)
        {
            // إعدادات الزر ليكون شفافاً وبدون حواف
            btn.BackColor = Color.Transparent;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.Cursor = Cursors.Hand;
            btn.ForeColor = Color.FromArgb(60, 60, 60); // لون النص الافتراضي

            // ربط أحداث الحركة
            btn.MouseEnter += (s, _) => {
                targetRect = new RectangleF(btn.Left, btn.Top, btn.Width, btn.Height);
                btn.ForeColor = Color.White; // تغيير لون النص عند التحويم
                animTimer.Start();
            };

            btn.MouseLeave += (s, _) => {
                btn.ForeColor = Color.FromArgb(60, 60, 60);
            };
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        // رسم التأثير خلف الأزرار
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        if (currentRect.Width > 0)
        {
            // لون الخلفية المتحركة (رمادي فاتح جداً أو أزرق خفيف)
            Color highlightColor = Color.FromArgb(210,239, 128, 16);
            using (SolidBrush brush = new SolidBrush(highlightColor))
            {
                // رسم مستطيل بحواف دائرية خلف الزر
                FillRoundedRectangle(e.Graphics, brush, currentRect, 10);
            }
        }

        base.OnPaint(e); // رسم الأزرار فوق الخلفية
    }

    // دالة مساعدة لرسم مستطيل منحني الحواف احترافي
    private void FillRoundedRectangle(Graphics g, Brush brush, RectangleF rect, int radius)
    {
        using (GraphicsPath path = new GraphicsPath())
        {
            float d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            g.FillPath(brush, path);
        }
    }
}