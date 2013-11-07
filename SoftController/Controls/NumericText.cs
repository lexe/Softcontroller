using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace SoftController.Controls
{
    public partial class NumericText : TextBox
    {
        private NumberFormatInfo oInfo = CultureInfo.CurrentCulture.NumberFormat;

        // fields - general
        private String sDecimalSeparator = "";
        private String sNegativeSign = "";
        private Boolean bAllowComma = false;
        private Boolean bAllowNegative = false;
        private Int32 iMaxDigitsBeforeComma = 10;
        private Int32 iMaxDigitsAfterComma = 3;
        private Color cOutOfRange = Color.LightCoral;
        private Double dScaleFactor = 1;
        // fields - Int16/Int32
        private Int32 iMax = Int32.MaxValue;
        private Int32 iMin = Int32.MinValue;
        // fields - Single/Double
        private String sFormat = "{0:0}";
        private Double dMax = Int32.MaxValue;
        private Double dMin = Int32.MinValue;

        public NumericText()
            : base()
        {
            this.TextAlign = HorizontalAlignment.Right;

            sDecimalSeparator = oInfo.NumberDecimalSeparator;
            sNegativeSign = oInfo.NegativeSign;
        }

        // 
        // methods
        // 
        private void InitText(Int32 value)
        {
            sFormat = "{0:0";
            if (bAllowComma && iMaxDigitsAfterComma != 0)
            {
                sFormat += ",";
                for (int i = 0; i < iMaxDigitsAfterComma; i++) sFormat += "0";
            }
            sFormat += "}";

            this.Text = string.Format(sFormat, value);
            OnTextChanged(EventArgs.Empty);
        }
        private void InitText(Double value)
        {
            sFormat = "{0:0";
            if (bAllowComma && iMaxDigitsAfterComma != 0)
            {
                sFormat += ".";
                for (int i = 0; i < iMaxDigitsAfterComma; i++) sFormat += "0";
            }
            sFormat += "}";

            this.Text = string.Format(sFormat, value);
            OnTextChanged(EventArgs.Empty);
        }

        // 
        // events
        // 
        protected override void WndProc(ref Message m)
        {
            // don't allow paste actions
            if (m.Msg == 0x302) return;

            base.WndProc(ref m);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // substitute values
            // make sure "," and "." are recognized as decimal seperators
            if (e.KeyChar == '.' && "." != sDecimalSeparator) e.KeyChar = sDecimalSeparator[0];
            if (e.KeyChar == ',' && "," != sDecimalSeparator) e.KeyChar = sDecimalSeparator[0];
            // make sure "-" is recognized as a negative sign
            if (e.KeyChar == '-' && "-" != sNegativeSign) e.KeyChar = sNegativeSign[0];

            // 
            // variables
            // 
            string sChar = e.KeyChar.ToString();
            bool bSeparator = Text.Contains(sDecimalSeparator);
            bool bSeparatorS = SelectedText.Contains(sDecimalSeparator);
            bool bNegative = Text.Contains(sNegativeSign);
            bool bNegativeS = SelectedText.Contains(sNegativeSign);

            string[] arr_sSplit = Text.Split(sDecimalSeparator[0]);
            int iSeparatorIndex = -1;
            int iDigitsBefore = (this.Text.Contains(sNegativeSign)) ? arr_sSplit[0].Length - 1 : arr_sSplit[0].Length;
            int iDigitsAfter = -1;
            if (Text.Contains(sDecimalSeparator))
            {
                iSeparatorIndex = Text.IndexOf(sDecimalSeparator[0]);
                iDigitsAfter = arr_sSplit[1].Length;
            }

            // 
            // handle key
            // 
            if (char.IsDigit(e.KeyChar))
            {
                if (!bAllowComma)
                {
                    if (SelectedText == "")
                    {
                        // insert
                        if (iDigitsBefore < iMaxDigitsBeforeComma)
                        {
                            // when inserted after optional negative sign > always allow
                            if (SelectionStart > 0) e.Handled = false;
                            // when inserted at beginning > check for negative sign
                            else if (!bNegative) e.Handled = false;

                            else e.Handled = true;
                        }
                        else e.Handled = true;
                    }
                    else
                    {
                        // replace
                        e.Handled = false;
                    }
                }
                else
                {
                    if (SelectedText == "")
                    {
                        // insert
                        if (iSeparatorIndex != -1 && SelectionStart > iSeparatorIndex)
                        {
                            // insert digit after comma
                            if (iDigitsAfter < iMaxDigitsAfterComma) e.Handled = false;
                            else e.Handled = true;
                        }
                        else
                        {
                            // insert digit before comma
                            if (iDigitsBefore < iMaxDigitsBeforeComma)
                            {
                                // when inserted after optional negative sign > always allow
                                if (SelectionStart > 0) e.Handled = false;
                                // when inserted at beginning > check for negative sign
                                else if (!bNegative) e.Handled = false;

                                else e.Handled = true;
                            }
                            else e.Handled = true;
                        }
                    }
                    else
                    {
                        // replace
                        if (Text == SelectedText) e.Handled = false;
                        else e.Handled = (bSeparatorS);
                    }
                }
            }
            else if (e.KeyChar == '\b')
            {
                if (SelectedText == "")
                {
                    // delete one character
                    // case 1: comma will not be deleted > always allow
                    e.Handled = (SelectionStart == iSeparatorIndex + 1);
                }
                else
                {
                    // delete selection
                    // case 1: all text will be deleted > always allow
                    if (Text == SelectedText) e.Handled = false;
                    // case 2: digits will be deleted without separator > allow
                    else if (!bSeparatorS) e.Handled = false;

                    else e.Handled = true;
                }
            }
            else if (bAllowComma && sChar == sDecimalSeparator)
            {
                if (SelectedText == "")
                {
                    // insert
                    if (!bSeparator) e.Handled = !(SelectionStart == Text.Length);
                    else e.Handled = true;
                }
                else
                {
                    // replace
                    e.Handled = !bSeparatorS;
                }
            }
            else if (bAllowNegative && sChar == sNegativeSign)
            {
                if (SelectedText == "")
                {
                    // insert
                    e.Handled = !(SelectionStart == 0 && !bNegative);
                }
                else
                {
                    // replace
                    if (SelectionStart == 0)
                    {
                        // case 1: no negative sign present yet > allow
                        if (!bNegative) e.Handled = false;
                        // case 2: negative sign present but will be replaced > allow
                        else if (bNegativeS) e.Handled = false;

                        else e.Handled = true;
                    }
                    else e.Handled = true;
                }
            }
            else e.Handled = true;
        }
        protected override void OnClick(EventArgs e)
        {
            if (this.Text.Contains(sDecimalSeparator) && SelectionStart != 0 && SelectedText == "")
            {
                int iSeparatorIndex = this.Text.IndexOf(sDecimalSeparator);
                if (SelectionStart <= iSeparatorIndex)
                {
                    if (this.Text.Contains(sNegativeSign)) SelectionStart = 1;
                    else SelectionStart = 0;
                    SelectionLength = iSeparatorIndex - SelectionStart;
                }
                else
                {
                    if (SelectionStart != Text.Length)
                    {
                        SelectionStart = iSeparatorIndex + 1;
                        SelectionLength = this.Text.Length - SelectionStart;
                    }
                }
            }

            base.OnClick(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            BackColor = (ValueOK) ? Color.White : cOutOfRange;

            base.OnTextChanged(e);
        }

        // 
        // properties - general
        // 
        public Boolean AllowComma
        {
            get { return bAllowComma; }
            set
            {
                if (bAllowComma == value) return;

                bAllowComma = value;
                InitText(0);
            }
        }
        public Boolean AllowNegative
        {
            get { return bAllowNegative; }
            set
            {
                if (bAllowNegative == value) return;

                bAllowNegative = value;
                InitText(0);
            }
        }
        public Int32 MaxDigitsAfterComma
        {
            set
            {
                if (iMaxDigitsAfterComma == value) return;

                iMaxDigitsAfterComma = value;
                InitText(0);
            }
            get { return iMaxDigitsAfterComma; }
        }
        public Double ValueMax
        {
            get { return dMax; }
            set
            {
                if (value <= ValueMin) return;
                dMax = value;
                iMax = Convert.ToInt32(dMax);

                string[] arr_sSplit = dMax.ToString().Replace(sNegativeSign, "").Split(sDecimalSeparator[0]);
                iMaxDigitsBeforeComma = arr_sSplit[0].Length;
            }
        }
        public Double ValueMin
        {
            get { return dMin; }
            set
            {
                if (value >= ValueMax) return;
                dMin = value;
                iMin = Convert.ToInt32(dMin);
            }
        }
        public Boolean ValueOK
        {
            get
            {
                if (bAllowComma)
                {
                    return (ValueMin * ScaleFactor <= ValueDouble && ValueDouble <= ValueMax * ScaleFactor);
                }
                else
                {
                    return (ValueMin * ScaleFactor <= ValueInt32 && ValueInt32 <= ValueMax * ScaleFactor);
                }
            }
        }
        public Color ColorOutOfRange
        {
            get { return cOutOfRange; }
            set { cOutOfRange = value; }
        }
        public Double ScaleFactor
        {
            get { return dScaleFactor; }
            set { dScaleFactor = value; }
        }

        // 
        // properties - Int16/Int32
        // 
        public Byte ValueByte
        {
            set
            {
                if (bAllowComma) return;
                if (bAllowNegative) return;

                InitText(Convert.ToByte(value / dScaleFactor));
            }
            get
            {
                if (bAllowComma) return 0;
                if (bAllowNegative) return 0;

                Byte bRetVal = 0;
                Byte.TryParse(this.Text, out bRetVal);
                return Convert.ToByte(bRetVal * dScaleFactor);
            }
        }
        public Int16 ValueInt16
        {
            set
            {
                if (bAllowComma) return;

                InitText(Convert.ToInt16(value / dScaleFactor));
            }
            get
            {
                if (bAllowComma) return 0;

                Int16 iRetVal = 0;
                Int16.TryParse(this.Text, out iRetVal);
                return Convert.ToInt16(iRetVal * dScaleFactor);
            }
        }
        public Int32 ValueInt32
        {
            set
            {
                if (bAllowComma) return;

                InitText(Convert.ToInt32(value / dScaleFactor));
            }
            get
            {
                if (bAllowComma) return 0;

                Int32 iRetVal = 0;
                Int32.TryParse(this.Text, out iRetVal);
                return Convert.ToInt32(iRetVal * dScaleFactor);
            }
        }
        public Int64 ValueInt64
        {
            set
            {
                if (bAllowComma) return;

                InitText(Convert.ToInt64(value / dScaleFactor));
            }
            get
            {
                if (bAllowComma) return 0;

                Int64 iRetVal = 0;
                Int64.TryParse(this.Text, out iRetVal);
                return Convert.ToInt64(iRetVal * dScaleFactor);
            }
        }

        // 
        // properties - Single/Double
        // 
        public Single ValueSingle
        {
            set 
            { 
                if (!bAllowComma) return;

                InitText(Convert.ToSingle(value / dScaleFactor));
            }
            get
            {
                if (!bAllowComma) return 0f;

                Single fRetVal = 0f;
                Single.TryParse(this.Text, out fRetVal);
                return Convert.ToSingle(fRetVal * dScaleFactor);
            }
        }
        public Double ValueDouble
        {
            set
            {
                if (!bAllowComma) return;

                InitText(value / dScaleFactor);
            }
            get
            {
                if (!bAllowComma) return 0.0;

                Double dRetVal = 0f;
                Double.TryParse(this.Text, out dRetVal);
                return dRetVal * dScaleFactor;
            }
        }
    }
}
