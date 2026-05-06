using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CustomControls.RJControls
{
    public class RJDatePicker : DateTimePicker
    {
        private Color skinColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;
        private Image calendarIcon = LaCucina.Properties.Resources.calendar_icon;
        private const int calendarIconWidth = 34;

        // --- تعريفات الـ API الإضافية لإزالة الحواف ---
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern IntPtr SendMessageRect(IntPtr hWnd, int msg, IntPtr wParam, ref Rectangle lParam);
        [DllImport("user32.dll")]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        public Color SkinColor { get => skinColor; set { skinColor = value; this.Invalidate(); } }
        public Color TextColor { get => textColor; set { textColor = value; this.Invalidate(); } }
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }

        public RJDatePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5F);
            this.CalendarMonthBackground = Color.FromArgb(30, 30, 30);
        }

        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            IntPtr calHandle = SendMessage(this.Handle, 0x1000 + 8, IntPtr.Zero, IntPtr.Zero);
            if (calHandle != IntPtr.Zero)
            {
                SetWindowTheme(calHandle, "", "");

                int winBackground = ColorTranslator.ToWin32(this.CalendarMonthBackground);
                // تلوين كل شيء بما فيها الحاشية
                SendMessage(calHandle, 0x1000 + 10, (IntPtr)0, (IntPtr)winBackground); // Background
                SendMessage(calHandle, 0x1000 + 10, (IntPtr)4, (IntPtr)winBackground); // Month Background

                // إزالة ستايل الحواف (Client Edge) الذي يظهر باللون الأبيض في ويندوز 10/11
                int exStyle = GetWindowLong(calHandle, -20);
                SetWindowLong(calHandle, -20, exStyle & ~0x00000200);

                Rectangle rect = new Rectangle();
                SendMessageRect(calHandle, 0x1000 + 9, IntPtr.Zero, ref rect);
                MoveWindow(calHandle, 0, 0, rect.Width, rect.Height, true);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width, this.Height);
                textFormat.LineAlignment = StringAlignment.Center;
                textFormat.Alignment = StringAlignment.Near;
                graphics.FillRectangle(skinBrush, clientArea);
                graphics.DrawString(this.Text, this.Font, textBrush, new RectangleF(10, 0, this.Width - calendarIconWidth - 10, this.Height), textFormat);
                if (calendarIcon != null) graphics.DrawImage(calendarIcon, this.Width - calendarIconWidth + (calendarIconWidth - 18) / 2, (this.Height - 18) / 2, 18, 18);
                if (borderSize >= 1) { penBorder.Alignment = PenAlignment.Inset; graphics.DrawRectangle(penBorder, 0, 0, this.Width, this.Height); }
            }
        }
    }
}