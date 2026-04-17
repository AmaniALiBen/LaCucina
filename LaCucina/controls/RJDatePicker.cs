using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LaCucina.Controls
{
    public class CustomDateTimePicker : DateTimePicker
    {
        // Fields - الألوان التي تتماشى مع تصميمك البرتقالي والأسود
        private Color skinColor = Color.FromArgb(18, 18, 18);
        private Color textColor = Color.White;
        private Color borderColor = Color.FromArgb(230, 126, 34); // البرتقالي الخاص بك
        private int borderSize = 1;

        // Icons
        private Image calendarIcon = Properties.Resources.calendar_icon; // تأكدي من وجود الأيقونة في الموارد
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;

        public CustomDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font("Inter", 10F);
        }

        // Properties - لتتمكني من تغيير الألوان من الـ Designer
        public Color SkinColor { get => skinColor; set { skinColor = value; this.Invalidate(); } }
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = e.Graphics)
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 230, 126, 34))) // توهج بسيط عند الضغط
            {
                Rectangle clientArea = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                int iconWidth = GetIconButtonWidth();
                Rectangle iconArea = new Rectangle(this.Width - iconWidth, 0, iconWidth, this.Height);

                graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // 1. Draw surface
                graphics.FillRectangle(skinBrush, clientArea);

                // 2. Draw text - مع إزاحة بسيطة لليسار
                TextRenderer.DrawText(graphics, "  " + this.Text, this.Font, clientArea, textColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                // 3. Draw open calendar highlight
                // ملاحظة: DateTimePicker لا يملك خاصية DroppedDown مباشرة، سنستخدم متغير داخلي أو نعتمد على حالة النقر

                // 4. Draw border 
                if (borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);

                // 5. Draw icon - تأكد من رسمها في المنتصف عمودياً
                if (calendarIcon != null)
                {
                    int iconX = this.Width - calendarIcon.Width - 10;
                    int iconY = (this.Height - calendarIcon.Height) / 2;
                    graphics.DrawImage(calendarIcon, iconX, iconY);
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateIconArea();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateIconArea();
        }

        private void UpdateIconArea()
        {
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            // تغيير شكل المؤشر عند الوقوف على منطقة الأيقونة
            if (iconButtonArea.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
        }

        // Private methods
        private int GetIconButtonWidth()
        {
            int textWidth = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidth <= this.Width - (calendarIconWidth + 20))
                return calendarIconWidth;
            else
                return arrowIconWidth;
        }
    }
}