namespace SoftController.Forms
{
    partial class LibraryEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryEditor));
            this.ctxtEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGraphic = new SoftController.Controls.BufferedPanel();
            this.oLibraryTree = new SoftController.Controls.LibraryTree();
            this.btnCreateLibrary = new System.Windows.Forms.ToolStripButton();
            this.btnAddSnapPoint = new System.Windows.Forms.ToolStripButton();
            this.btnAddButton = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolPolygon = new System.Windows.Forms.ToolStripButton();
            this.btnToolArc = new System.Windows.Forms.ToolStripButton();
            this.btnToolCircle = new System.Windows.Forms.ToolStripButton();
            this.btnToolLine = new System.Windows.Forms.ToolStripButton();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblZoomValue = new System.Windows.Forms.ToolStripLabel();
            this.btnSnapToGrid = new System.Windows.Forms.ToolStripButton();
            this.btnSnapToPoint = new System.Windows.Forms.ToolStripButton();
            this.tlsTools = new System.Windows.Forms.ToolStrip();
            this.ctxtEdit.SuspendLayout();
            this.tlsTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxtEdit
            // 
            this.ctxtEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniDelete});
            this.ctxtEdit.Name = "ctxtEdit";
            this.ctxtEdit.Size = new System.Drawing.Size(108, 26);
            this.ctxtEdit.Opening += new System.ComponentModel.CancelEventHandler(this.ctxtEdit_Opening);
            // 
            // mniDelete
            // 
            this.mniDelete.Name = "mniDelete";
            this.mniDelete.Size = new System.Drawing.Size(107, 22);
            this.mniDelete.Text = "Delete";
            this.mniDelete.Click += new System.EventHandler(this.mniDelete_Click);
            // 
            // pnlGraphic
            // 
            this.pnlGraphic.AllowDrop = true;
            this.pnlGraphic.BackColor = System.Drawing.Color.Black;
            this.pnlGraphic.ContextMenuStrip = this.ctxtEdit;
            this.pnlGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGraphic.Location = new System.Drawing.Point(240, 25);
            this.pnlGraphic.Name = "pnlGraphic";
            this.pnlGraphic.Size = new System.Drawing.Size(544, 417);
            this.pnlGraphic.TabIndex = 2;
            this.pnlGraphic.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraphic_Paint);
            this.pnlGraphic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGraphic_MouseMove);
            this.pnlGraphic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGraphic_MouseDown);
            this.pnlGraphic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlGraphic_MouseUp);
            this.pnlGraphic.SizeChanged += new System.EventHandler(this.pnlGraphic_SizeChanged);
            this.pnlGraphic.MouseEnter += new System.EventHandler(this.pnlGraphic_MouseEnter);
            // 
            // oLibraryTree
            // 
            this.oLibraryTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.oLibraryTree.Location = new System.Drawing.Point(0, 25);
            this.oLibraryTree.Name = "oLibraryTree";
            this.oLibraryTree.Size = new System.Drawing.Size(240, 417);
            this.oLibraryTree.TabIndex = 0;
            this.oLibraryTree.AfterItemSelect += new SoftController.Controls.LibraryTree.AfterItemSelectEventHandler(this.oLibraryTree_AfterItemSelect);
            // 
            // btnCreateLibrary
            // 
            this.btnCreateLibrary.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateLibrary.Image")));
            this.btnCreateLibrary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateLibrary.Name = "btnCreateLibrary";
            this.btnCreateLibrary.Size = new System.Drawing.Size(97, 22);
            this.btnCreateLibrary.Text = "Create library";
            this.btnCreateLibrary.Click += new System.EventHandler(this.btnCreateLibrary_Click);
            // 
            // btnAddSnapPoint
            // 
            this.btnAddSnapPoint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAddSnapPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddSnapPoint.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSnapPoint.Image")));
            this.btnAddSnapPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSnapPoint.Name = "btnAddSnapPoint";
            this.btnAddSnapPoint.Size = new System.Drawing.Size(23, 22);
            this.btnAddSnapPoint.Text = "toolStripButton1";
            this.btnAddSnapPoint.ToolTipText = "Add snap point";
            // 
            // btnAddButton
            // 
            this.btnAddButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddButton.Image = ((System.Drawing.Image)(resources.GetObject("btnAddButton.Image")));
            this.btnAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(23, 22);
            this.btnAddButton.ToolTipText = "Add button";
            // 
            // sep1
            // 
            this.sep1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnToolPolygon
            // 
            this.btnToolPolygon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnToolPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolPolygon.Image = global::SoftController.Properties.Resources.polygon_16;
            this.btnToolPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolPolygon.Name = "btnToolPolygon";
            this.btnToolPolygon.Size = new System.Drawing.Size(23, 22);
            this.btnToolPolygon.ToolTipText = "Polygon";
            this.btnToolPolygon.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnToolArc
            // 
            this.btnToolArc.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnToolArc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolArc.Image = global::SoftController.Properties.Resources.arc_16;
            this.btnToolArc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolArc.Name = "btnToolArc";
            this.btnToolArc.Size = new System.Drawing.Size(23, 22);
            this.btnToolArc.Text = "toolStripButton1";
            this.btnToolArc.ToolTipText = "Arc";
            this.btnToolArc.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnToolCircle
            // 
            this.btnToolCircle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnToolCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolCircle.Image = global::SoftController.Properties.Resources.circle_16;
            this.btnToolCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolCircle.Name = "btnToolCircle";
            this.btnToolCircle.Size = new System.Drawing.Size(23, 22);
            this.btnToolCircle.ToolTipText = "Circle";
            this.btnToolCircle.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnToolLine
            // 
            this.btnToolLine.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnToolLine.Checked = true;
            this.btnToolLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnToolLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolLine.Image = global::SoftController.Properties.Resources.line_16;
            this.btnToolLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolLine.Name = "btnToolLine";
            this.btnToolLine.Size = new System.Drawing.Size(23, 22);
            this.btnToolLine.ToolTipText = "Line";
            this.btnToolLine.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // sep2
            // 
            this.sep2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblZoomValue
            // 
            this.lblZoomValue.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblZoomValue.Name = "lblZoomValue";
            this.lblZoomValue.Size = new System.Drawing.Size(29, 22);
            this.lblZoomValue.Text = "10%";
            this.lblZoomValue.Click += new System.EventHandler(this.lblZoom_Click);
            // 
            // btnSnapToGrid
            // 
            this.btnSnapToGrid.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSnapToGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSnapToGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapToGrid.Image")));
            this.btnSnapToGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSnapToGrid.Name = "btnSnapToGrid";
            this.btnSnapToGrid.Size = new System.Drawing.Size(23, 22);
            this.btnSnapToGrid.Text = "Snap";
            this.btnSnapToGrid.Click += new System.EventHandler(this.btnSnap_Click);
            // 
            // btnSnapToPoint
            // 
            this.btnSnapToPoint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSnapToPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSnapToPoint.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapToPoint.Image")));
            this.btnSnapToPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSnapToPoint.Name = "btnSnapToPoint";
            this.btnSnapToPoint.Size = new System.Drawing.Size(23, 22);
            this.btnSnapToPoint.Text = "Snap to point";
            this.btnSnapToPoint.Click += new System.EventHandler(this.btnSnap_Click);
            // 
            // tlsTools
            // 
            this.tlsTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateLibrary,
            this.btnAddSnapPoint,
            this.btnAddButton,
            this.sep1,
            this.btnToolPolygon,
            this.btnToolArc,
            this.btnToolCircle,
            this.btnToolLine,
            this.sep2,
            this.lblZoomValue,
            this.btnSnapToGrid,
            this.btnSnapToPoint});
            this.tlsTools.Location = new System.Drawing.Point(0, 0);
            this.tlsTools.Name = "tlsTools";
            this.tlsTools.Size = new System.Drawing.Size(784, 25);
            this.tlsTools.TabIndex = 1;
            this.tlsTools.Text = "Tools";
            // 
            // LibraryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.pnlGraphic);
            this.Controls.Add(this.oLibraryTree);
            this.Controls.Add(this.tlsTools);
            this.Name = "LibraryEditor";
            this.Text = "LibraryEditor";
            this.Shown += new System.EventHandler(this.LibraryEditor_Shown);
            this.ctxtEdit.ResumeLayout(false);
            this.tlsTools.ResumeLayout(false);
            this.tlsTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoftController.Controls.LibraryTree oLibraryTree;
        private SoftController.Controls.BufferedPanel pnlGraphic;
        private System.Windows.Forms.ContextMenuStrip ctxtEdit;
        private System.Windows.Forms.ToolStripMenuItem mniDelete;
        private System.Windows.Forms.ToolStripButton btnCreateLibrary;
        private System.Windows.Forms.ToolStripButton btnAddSnapPoint;
        private System.Windows.Forms.ToolStripButton btnAddButton;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripButton btnToolPolygon;
        private System.Windows.Forms.ToolStripButton btnToolArc;
        private System.Windows.Forms.ToolStripButton btnToolCircle;
        private System.Windows.Forms.ToolStripButton btnToolLine;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripLabel lblZoomValue;
        private System.Windows.Forms.ToolStripButton btnSnapToGrid;
        private System.Windows.Forms.ToolStripButton btnSnapToPoint;
        private System.Windows.Forms.ToolStrip tlsTools;
    }
}