namespace SoftController.Forms.Library
{
    partial class EditLine
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblWidthUnit = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblStartUnit = new System.Windows.Forms.Label();
            this.lblEndUnit = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.ntxtWidth = new SoftController.Controls.NumericText();
            this.cbtnColor = new SoftController.Controls.ColorButton();
            this.ntxtP2Y = new SoftController.Controls.NumericText();
            this.ntxtP2X = new SoftController.Controls.NumericText();
            this.ntxtP1Y = new SoftController.Controls.NumericText();
            this.ntxtP1X = new SoftController.Controls.NumericText();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(20, 98);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 30;
            this.lblWidth.Text = "Width:";
            // 
            // lblWidthUnit
            // 
            this.lblWidthUnit.AutoSize = true;
            this.lblWidthUnit.Location = new System.Drawing.Point(190, 98);
            this.lblWidthUnit.Name = "lblWidthUnit";
            this.lblWidthUnit.Size = new System.Drawing.Size(23, 13);
            this.lblWidthUnit.TabIndex = 29;
            this.lblWidthUnit.Text = "mm";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(20, 126);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 27;
            this.lblColor.Text = "Color:";
            // 
            // lblStartUnit
            // 
            this.lblStartUnit.AutoSize = true;
            this.lblStartUnit.Location = new System.Drawing.Point(190, 46);
            this.lblStartUnit.Name = "lblStartUnit";
            this.lblStartUnit.Size = new System.Drawing.Size(15, 13);
            this.lblStartUnit.TabIndex = 22;
            this.lblStartUnit.Text = "m";
            // 
            // lblEndUnit
            // 
            this.lblEndUnit.AutoSize = true;
            this.lblEndUnit.Location = new System.Drawing.Point(190, 72);
            this.lblEndUnit.Name = "lblEndUnit";
            this.lblEndUnit.Size = new System.Drawing.Size(15, 13);
            this.lblEndUnit.TabIndex = 21;
            this.lblEndUnit.Text = "m";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(139, 13);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 20;
            this.lblY.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(68, 13);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 19;
            this.lblX.Text = "X:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(20, 72);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(29, 13);
            this.lblEnd.TabIndex = 18;
            this.lblEnd.Text = "End:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(20, 46);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(32, 13);
            this.lblStart.TabIndex = 17;
            this.lblStart.Text = "Start:";
            // 
            // ntxtWidth
            // 
            this.ntxtWidth.AllowComma = true;
            this.ntxtWidth.AllowNegative = false;
            this.ntxtWidth.BackColor = System.Drawing.Color.LightCoral;
            this.ntxtWidth.ColorOutOfRange = System.Drawing.Color.LightCoral;
            this.ntxtWidth.Location = new System.Drawing.Point(124, 95);
            this.ntxtWidth.MaxDigitsAfterComma = 0;
            this.ntxtWidth.Name = "ntxtWidth";
            this.ntxtWidth.ScaleFactor = 0.001;
            this.ntxtWidth.Size = new System.Drawing.Size(60, 20);
            this.ntxtWidth.TabIndex = 28;
            this.ntxtWidth.Text = "0";
            this.ntxtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntxtWidth.ValueByte = ((byte)(0));
            this.ntxtWidth.ValueDouble = 0;
            this.ntxtWidth.ValueInt16 = ((short)(0));
            this.ntxtWidth.ValueInt32 = 0;
            this.ntxtWidth.ValueInt64 = ((long)(0));
            this.ntxtWidth.ValueMax = 10;
            this.ntxtWidth.ValueMin = 1;
            this.ntxtWidth.ValueSingle = 0F;
            // 
            // cbtnColor
            // 
            this.cbtnColor.BackColor = System.Drawing.SystemColors.Control;
            this.cbtnColor.Color = System.Drawing.SystemColors.Control;
            this.cbtnColor.Location = new System.Drawing.Point(124, 121);
            this.cbtnColor.Name = "cbtnColor";
            this.cbtnColor.Size = new System.Drawing.Size(60, 23);
            this.cbtnColor.TabIndex = 26;
            this.cbtnColor.UseVisualStyleBackColor = true;
            // 
            // ntxtP2Y
            // 
            this.ntxtP2Y.AllowComma = true;
            this.ntxtP2Y.AllowNegative = false;
            this.ntxtP2Y.BackColor = System.Drawing.Color.White;
            this.ntxtP2Y.ColorOutOfRange = System.Drawing.Color.LightCoral;
            this.ntxtP2Y.Location = new System.Drawing.Point(124, 69);
            this.ntxtP2Y.MaxDigitsAfterComma = 4;
            this.ntxtP2Y.Name = "ntxtP2Y";
            this.ntxtP2Y.ScaleFactor = 1;
            this.ntxtP2Y.Size = new System.Drawing.Size(60, 20);
            this.ntxtP2Y.TabIndex = 25;
            this.ntxtP2Y.Text = "0.0000";
            this.ntxtP2Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntxtP2Y.ValueByte = ((byte)(0));
            this.ntxtP2Y.ValueDouble = 0;
            this.ntxtP2Y.ValueInt16 = ((short)(0));
            this.ntxtP2Y.ValueInt32 = 0;
            this.ntxtP2Y.ValueInt64 = ((long)(0));
            this.ntxtP2Y.ValueMax = 2147483647;
            this.ntxtP2Y.ValueMin = -2147483648;
            this.ntxtP2Y.ValueSingle = 0F;
            // 
            // ntxtP2X
            // 
            this.ntxtP2X.AllowComma = true;
            this.ntxtP2X.AllowNegative = false;
            this.ntxtP2X.BackColor = System.Drawing.Color.White;
            this.ntxtP2X.ColorOutOfRange = System.Drawing.Color.LightCoral;
            this.ntxtP2X.Location = new System.Drawing.Point(58, 69);
            this.ntxtP2X.MaxDigitsAfterComma = 4;
            this.ntxtP2X.Name = "ntxtP2X";
            this.ntxtP2X.ScaleFactor = 1;
            this.ntxtP2X.Size = new System.Drawing.Size(60, 20);
            this.ntxtP2X.TabIndex = 24;
            this.ntxtP2X.Text = "0.0000";
            this.ntxtP2X.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntxtP2X.ValueByte = ((byte)(0));
            this.ntxtP2X.ValueDouble = 0;
            this.ntxtP2X.ValueInt16 = ((short)(0));
            this.ntxtP2X.ValueInt32 = 0;
            this.ntxtP2X.ValueInt64 = ((long)(0));
            this.ntxtP2X.ValueMax = 2147483647;
            this.ntxtP2X.ValueMin = -2147483648;
            this.ntxtP2X.ValueSingle = 0F;
            // 
            // ntxtP1Y
            // 
            this.ntxtP1Y.AllowComma = true;
            this.ntxtP1Y.AllowNegative = false;
            this.ntxtP1Y.BackColor = System.Drawing.Color.White;
            this.ntxtP1Y.ColorOutOfRange = System.Drawing.Color.LightCoral;
            this.ntxtP1Y.Location = new System.Drawing.Point(124, 43);
            this.ntxtP1Y.MaxDigitsAfterComma = 4;
            this.ntxtP1Y.Name = "ntxtP1Y";
            this.ntxtP1Y.ScaleFactor = 1;
            this.ntxtP1Y.Size = new System.Drawing.Size(60, 20);
            this.ntxtP1Y.TabIndex = 23;
            this.ntxtP1Y.Text = "0.0000";
            this.ntxtP1Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntxtP1Y.ValueByte = ((byte)(0));
            this.ntxtP1Y.ValueDouble = 0;
            this.ntxtP1Y.ValueInt16 = ((short)(0));
            this.ntxtP1Y.ValueInt32 = 0;
            this.ntxtP1Y.ValueInt64 = ((long)(0));
            this.ntxtP1Y.ValueMax = 2147483647;
            this.ntxtP1Y.ValueMin = -2147483648;
            this.ntxtP1Y.ValueSingle = 0F;
            // 
            // ntxtP1X
            // 
            this.ntxtP1X.AllowComma = true;
            this.ntxtP1X.AllowNegative = false;
            this.ntxtP1X.BackColor = System.Drawing.Color.White;
            this.ntxtP1X.ColorOutOfRange = System.Drawing.Color.LightCoral;
            this.ntxtP1X.Location = new System.Drawing.Point(58, 43);
            this.ntxtP1X.MaxDigitsAfterComma = 4;
            this.ntxtP1X.Name = "ntxtP1X";
            this.ntxtP1X.ScaleFactor = 1;
            this.ntxtP1X.Size = new System.Drawing.Size(60, 20);
            this.ntxtP1X.TabIndex = 16;
            this.ntxtP1X.Text = "0.0000";
            this.ntxtP1X.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntxtP1X.ValueByte = ((byte)(0));
            this.ntxtP1X.ValueDouble = 0;
            this.ntxtP1X.ValueInt16 = ((short)(0));
            this.ntxtP1X.ValueInt32 = 0;
            this.ntxtP1X.ValueInt64 = ((long)(0));
            this.ntxtP1X.ValueMax = 2147483647;
            this.ntxtP1X.ValueMin = -2147483648;
            this.ntxtP1X.ValueSingle = 0F;
            // 
            // EditLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblWidthUnit);
            this.Controls.Add(this.ntxtWidth);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cbtnColor);
            this.Controls.Add(this.ntxtP2Y);
            this.Controls.Add(this.ntxtP2X);
            this.Controls.Add(this.ntxtP1Y);
            this.Controls.Add(this.lblStartUnit);
            this.Controls.Add(this.lblEndUnit);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.ntxtP1X);
            this.Name = "EditLine";
            this.Size = new System.Drawing.Size(240, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblWidthUnit;
        private SoftController.Controls.NumericText ntxtWidth;
        private System.Windows.Forms.Label lblColor;
        private SoftController.Controls.ColorButton cbtnColor;
        private SoftController.Controls.NumericText ntxtP2Y;
        private SoftController.Controls.NumericText ntxtP2X;
        private SoftController.Controls.NumericText ntxtP1Y;
        private System.Windows.Forms.Label lblStartUnit;
        private System.Windows.Forms.Label lblEndUnit;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private SoftController.Controls.NumericText ntxtP1X;
    }
}
