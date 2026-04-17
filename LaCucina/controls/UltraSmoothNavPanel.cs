using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class UltraSmoothNavPanel : SmoothDraggablePanel
{
    private Timer animTimer;
    private RectangleF currentRect;
    private RectangleF targetRect;
    private float lerpSpeed = 0.15f;
    private Button selectedButton;

    public UltraSmoothNavPanel()
    {
        animTimer = new Timer { Interval = 15 };
        animTimer.Tick += (s, e) => {
            currentRect.X += (targetRect.X - currentRect.X) * lerpSpeed;
            currentRect.Width += (targetRect.Width - currentRect.Width) * lerpSpeed;
            currentRect.Y = targetRect.Y;
            currentRect.Height = targetRect.Height;

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
            btn.BackColor = Color.Transparent;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.Cursor = Cursors.Hand;
            btn.ForeColor = Color.Gray;

            btn.MouseEnter += (s, _) => {
                targetRect = new RectangleF(btn.Left, btn.Top, btn.Width, btn.Height);
                btn.ForeColor = Color.Black;
                animTimer.Start();
            };

            btn.MouseLeave += (s, _) => {
                if (selectedButton != null)
                {
                    // إذا فيه زر مضغوط، ارجع لمكانه وثبت الخط الأبيض عليه
                    targetRect = new RectangleF(selectedButton.Left, selectedButton.Top, selectedButton.Width, selectedButton.Height);
                    selectedButton.ForeColor = Color.Black;
                }
                else
                {
                    // التعديل هنا: إذا مفيش زر مضغوط، خلّي العرض 0 عشان يختفي التأثير
                    targetRect = new RectangleF(btn.Left + (btn.Width / 2), btn.Top, 0, btn.Height);
                }

                // رجّع لون الزر الحالي للرمادي لو مش هو المختار
                if (btn != selectedButton)
                {
                    btn.ForeColor = Color.Gray;
                }
                animTimer.Start();
            };

            btn.Click += (s, _) => {
                if (selectedButton != null)
                    selectedButton.ForeColor = Color.FromArgb(60, 60, 60);

                selectedButton = btn;
                btn.ForeColor = Color.Black;
                targetRect = new RectangleF(btn.Left, btn.Top, btn.Width, btn.Height);
                animTimer.Start();
            };
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // لا ترسم شيئاً إذا كان العرض صغيراً جداً (حالة الاختفاء)
        if (currentRect.Width > 1)
        {
            Color highlightColor = Color.FromArgb(190, 255, 160, 0);
            using (SolidBrush brush = new SolidBrush(highlightColor))
            {
                FillRoundedRectangle(e.Graphics, brush, currentRect, 10);
            }
        }

        base.OnPaint(e);
    }

    private void FillRoundedRectangle(Graphics g, Brush brush, RectangleF rect, int radius)
    {
        using (GraphicsPath path = new GraphicsPath())
        {
            float d = radius * 2;
            if (d > rect.Width) d = rect.Width; // حماية من الأخطاء لو العرض صغير
            if (d > rect.Height) d = rect.Height;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            g.FillPath(brush, path);
        }
    }
}