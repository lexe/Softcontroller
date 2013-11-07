using System;
using System.Windows.Forms;
using SoftController.BLL.Entities;

namespace SoftController.Forms.Library
{
    public partial class EditLine : UserControl
    {
        private UILine _line;

        public EditLine(UILine line)
        {
            InitializeComponent();

            _line = line;

            ntxtP1X.ValueDouble = _line.P1.X;
            ntxtP1Y.ValueDouble = _line.P1.Y;
            ntxtP2X.ValueDouble = _line.P2.X;
            ntxtP2Y.ValueDouble = _line.P2.Y;
            ntxtWidth.ValueSingle = _line.Width;
            cbtnColor.Color = _line.Color;

            ntxtP1X.TextChanged += new EventHandler(ntxt_TextChanged);
            ntxtP1Y.TextChanged += new EventHandler(ntxt_TextChanged);
            ntxtP2X.TextChanged += new EventHandler(ntxt_TextChanged);
            ntxtP2Y.TextChanged += new EventHandler(ntxt_TextChanged);
            ntxtWidth.TextChanged += new EventHandler(ntxt_TextChanged);
            cbtnColor.ColorChanged += new SoftController.Controls.ColorButton.ColorChangedEventHandler(cbtnColor_ColorChanged);
        }

        private void NotifyParent()
        {
            _line.P1.X = ntxtP1X.ValueDouble;
            _line.P1.Y = ntxtP1Y.ValueDouble;
            _line.P2.X = ntxtP2X.ValueDouble;
            _line.P2.Y = ntxtP2Y.ValueDouble;
            _line.Width = ntxtWidth.ValueSingle;
            _line.Color = cbtnColor.Color;
            ((EditUIElement)this.ParentForm).RaisePropertyChanged();
        }

        void ntxt_TextChanged(object sender, EventArgs e)
        {
            NotifyParent();
        }
        void cbtnColor_ColorChanged()
        {
            NotifyParent();
        }
    }
}
