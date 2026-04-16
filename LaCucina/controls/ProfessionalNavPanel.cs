using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

public class ProfessionalNavPanel : SmoothDraggablePanel
{
    private Timer transitionTimer;
    private Rectangle targetBounds;
    private Rectangle currentBounds;
    private Control selectedControl; // الزر المختار حالياً (الذي تم الضغط عليه)

    private Color _indicatorColor = Color.FromArgb(255, 160, 0);
    private int _lineThickness = 3;

    [Category("Appearance")]
    public Color IndicatorColor
    {
        get => _indicatorColor;
        set { _indicatorColor = value; this.Invalidate(); }
    }

    public ProfessionalNavPanel()
    {
        transitionTimer = new Timer { Interval = 10 };
        transitionTimer.Tick += (s, e) => SmoothMove();
        this.DoubleBuffered = true;
    }

    protected override void OnControlAdded(ControlEventArgs e)
    {
        base.OnControlAdded(e);
        if (e.Control is Button btn)
        {
            // 1. عند مرور الماوس (يتحرك الخط للمعاينة)
            btn.MouseEnter += (s, _) => UpdateTarget(btn);

            // 2. عند خروج الماوس (يعود الخط للزر المختار أو يختفي)
            btn.MouseLeave += (s, _) => UpdateTarget(selectedControl);

            // 3. عند الضغط (يتم تثبيت الزر كـ "Selected")
            btn.Click += (s, _) => {
                selectedControl = btn;
                UpdateTarget(btn);
            };

            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Transparent;
            btn.Cursor = Cursors.Hand;
        }
    }

    private void UpdateTarget(Control target)
    {
        if (target != null)
        {
            // تحديد مكان الخط أسفل العنصر الحالي
            targetBounds = new Rectangle(target.Left, target.Height +4, target.Width, _lineThickness);
        }
        else
        {
            // إذا لم يكن هناك زر مختار بعد، نجعل العرض 0 ليختفي الخط
            targetBounds = new Rectangle(currentBounds.X, currentBounds.Y, 0, _lineThickness);
        }
        transitionTimer.Start();
    }

    private void SmoothMove()
    {
        float speed = 0.3f;
        int nextX = currentBounds.X + (int)((targetBounds.X - currentBounds.X) * speed);
        int nextW = currentBounds.Width + (int)((targetBounds.Width - currentBounds.Width) * speed);

        currentBounds = new Rectangle(nextX, targetBounds.Y, nextW, targetBounds.Height);

        if (Math.Abs(currentBounds.X - targetBounds.X) <= 1 && Math.Abs(currentBounds.Width - targetBounds.Width) <= 1)
        {
            currentBounds = targetBounds;
            transitionTimer.Stop();
        }
        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (currentBounds.Width > 0)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(_indicatorColor))
            {
                GraphicsPath path = GetRoundedRect(currentBounds, 2);
                e.Graphics.FillPath(brush, path);
            }
        }
    }

    private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        if (rect.Width <= 2 * radius) radius = rect.Width / 2;
        int d = radius * 2;
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }
}