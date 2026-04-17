using System.Drawing;
using System.Windows.Forms;

public class TransparentPanel : Panel
{
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
            return cp;
        }
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        // هنا نتحكم في درجة التعتيم (120 من 255 تعني حوالي 50% شفافية)
        using (var brush = new SolidBrush(Color.FromArgb(2, Color.Black)))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}