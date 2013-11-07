using System;
using System.Windows.Forms;

namespace SoftController.Controls
{
    public class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            this.SetStyle(ControlStyles.DoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint,
                true);

            this.UpdateStyles();
        }
    }
}
