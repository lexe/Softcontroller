using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoftController.Controls
{
    public partial class ColorButton : Button
    {
        public delegate void ColorChangedEventHandler();
        public event ColorChangedEventHandler ColorChanged;

        protected override void OnClick(EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) Color = dialog.Color;
        }

        public Color Color
        {
            get { return this.BackColor; }
            set 
            { 
                this.BackColor = value;
                if (ColorChanged != null) ColorChanged();
            }
        }
    }
}
