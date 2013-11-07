using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SoftController.BLL.Components;
using SoftController.BLL.Entities;
using SoftController.Classes;
using SoftController.Forms.Library;

namespace SoftController.Forms
{
    public partial class LibraryEditor : Form
    {
        private Point _originOffset = Point.Empty;
        private Double _scale;
        private PointD _mousePosition = PointD.Empty;
        private PointD _targetPosition, _snapPosition, _snapGridPosition = PointD.Empty, _snapPointPosition;
        private UILine _newLine = null;

        private GraphicsEngine _graphics;
        private LibraryUIElement _hoveredElement;
        private String _hoveredSubElement = string.Empty;

        private Pen penGrid1, penGrid2;

        public LibraryEditor()
        {
            InitializeComponent();
        }
        private void LibraryEditor_Shown(object sender, EventArgs e)
        {
            pnlGraphic.MouseWheel += new MouseEventHandler(pnlGraphic_MouseWheel);

            penGrid1 = new Pen(Color.FromArgb(20, 20, 20));
            penGrid1.DashPattern = new float[] { 1, 1 };
            penGrid2 = new Pen(Color.FromArgb(40, 40, 40));
            penGrid2.DashPattern = new float[] { 3, 3 };

            oLibraryTree.UpdateTree();
            pnlGraphic.Focus();
            UpdateZoomValue(0.1);
        }

        private void UpdateZoomValue(Double newValue)
        {
            // adjust value
            _scale = newValue;
            _scale = Math.Min(10, _scale);
            _scale = Math.Max(0.01, _scale);

            // show value & redraw
            lblZoomValue.Text = string.Format("Zoom: {0:0} %", _scale * 100);
            pnlGraphic.Invalidate();
        }
        private PointD GetTargetPosition()
        {
            if (!btnSnapToPoint.Checked && btnSnapToGrid.Checked)
            {
                // snap to grid
                _snapPosition = _snapGridPosition;
                return _snapGridPosition.Clone();
            }
            else if (btnSnapToPoint.Checked && !btnSnapToGrid.Checked && _snapPointPosition != null)
            {
                // snap to point
                _snapPosition = _snapPointPosition;
                return _snapPointPosition.Clone();
            }
            else if (btnSnapToPoint.Checked && btnSnapToGrid.Checked)
            {
                // closest snap point (grid or point)
                if (_snapPointPosition != null && _graphics.GetRealDistance(_mousePosition, _snapPointPosition) < _graphics.GetRealDistance(_mousePosition, _snapGridPosition))
                {
                    // snap to point
                    _snapPosition = _snapPointPosition;
                    return _snapPointPosition.Clone();
                }
                else
                {
                    // snap to grid
                    _snapPosition = _snapGridPosition;
                    return _snapGridPosition.Clone();
                }
            }
            else
            {
                // default behaviour
                _snapPosition = null;
                return _mousePosition.Clone();
            }
        }

        private void btnCreateLibrary_Click(object sender, EventArgs e)
        {
            oLibraryTree.AddLibrary();
        }

        private void oLibraryTree_AfterItemSelect()
        {
            pnlGraphic.Invalidate();
        }
        private void pnlGraphic_Paint(object sender, PaintEventArgs e)
        {
            #region CalculateVariables
            _graphics = new GraphicsEngine(e.Graphics, _originOffset, PointF.Empty, _scale);

            // grid offsets
            _originOffset.X = pnlGraphic.Width / 2;
            _originOffset.Y = pnlGraphic.Height / 2;

            // mouse position
            _mousePosition.X = Convert.ToSingle(_graphics.PixelToRealDistanceX(pnlGraphic.PointToClient(MousePosition).X - _originOffset.X));
            _mousePosition.Y = -(Convert.ToSingle(_graphics.PixelToRealDistanceY(pnlGraphic.PointToClient(MousePosition).Y - _originOffset.Y)));
            #endregion

            #region Grid
            for (int x = 0; x <= pnlGraphic.Width / _graphics.RealToPixelDistanceX(0.1) / 2; x++)
            {
                e.Graphics.DrawLine(x % 10 != 0 ? penGrid1 : penGrid2,
                    _originOffset.X + _graphics.RealToPixelDistanceX(x * 0.1), 0,
                    _originOffset.X + _graphics.RealToPixelDistanceX(x * 0.1), pnlGraphic.Height);
                e.Graphics.DrawLine(x % 10 != 0 ? penGrid1 : penGrid2,
                    _originOffset.X - _graphics.RealToPixelDistanceX(x * 0.1), 0,
                    _originOffset.X - _graphics.RealToPixelDistanceX(x * 0.1), pnlGraphic.Height);
            }
            for (int y = 0; y <= pnlGraphic.Height / _graphics.RealToPixelDistanceY(0.1) / 2; y++)
            {
                e.Graphics.DrawLine(y % 10 != 0 ? penGrid1 : penGrid2,
                    0, _originOffset.Y + _graphics.RealToPixelDistanceY(y * 0.1),
                    pnlGraphic.Width, _originOffset.Y + _graphics.RealToPixelDistanceY(y * 0.1));
                e.Graphics.DrawLine(y % 10 != 0 ? penGrid1 : penGrid2,
                    0, _originOffset.Y - _graphics.RealToPixelDistanceY(y * 0.1),
                    pnlGraphic.Width, _originOffset.Y - _graphics.RealToPixelDistanceY(y * 0.1));
            }
            #endregion

            #region Origin
            e.Graphics.DrawLine(Pens.Yellow,
                _originOffset.X - _graphics.RealToPixelDistanceX(0.025), _originOffset.Y,
                _originOffset.X + _graphics.RealToPixelDistanceX(0.025), _originOffset.Y);
            e.Graphics.DrawLine(Pens.Yellow,
                _originOffset.X, _originOffset.Y - _graphics.RealToPixelDistanceY(0.025),
                _originOffset.X, _originOffset.Y + _graphics.RealToPixelDistanceY(0.025));
            #endregion

            #region CursorPosition
            e.Graphics.DrawString(string.Format("X: {0:0.000}m", _mousePosition.X),
                Control.DefaultFont, Brushes.White, 0, pnlGraphic.Height - 27);
            e.Graphics.DrawString(string.Format("Y: {0:0.000}m", _mousePosition.Y),
                Control.DefaultFont, Brushes.White, 0, pnlGraphic.Height - 14);
            #endregion

            if (oLibraryTree.SelectedItem == null) return;

            #region SnapPositions
            // snap to grid
            if (btnSnapToGrid.Checked)
            {
                _snapGridPosition.X = Math.Round(_mousePosition.X, 1);
                _snapGridPosition.Y = Math.Round(_mousePosition.Y, 1);
            }

            // snap to point
            _snapPointPosition = null;
            double closestDistance = double.MaxValue, currentDistance, maxSnapDistance = _graphics.PixelToRealDistanceX(10); ;
            foreach (LibraryUIElement element in oLibraryTree.SelectedItem.UIElements)
            {
                if (element is UILine)
                {
                    currentDistance = _graphics.GetRealDistance(_mousePosition, ((UILine)element).P1);
                    if (currentDistance < maxSnapDistance && currentDistance < closestDistance)
                    {
                        if (btnSnapToPoint.Checked) _snapPointPosition = ((UILine)element).P1.Clone();
                        closestDistance = currentDistance;
                    }
                    currentDistance = _graphics.GetRealDistance(_mousePosition, ((UILine)element).P2);
                    if (currentDistance < maxSnapDistance && currentDistance < closestDistance)
                    {
                        if (btnSnapToPoint.Checked) _snapPointPosition = ((UILine)element).P2.Clone();
                        closestDistance = currentDistance;
                    }
                    currentDistance = _graphics.GetRealDistance(_mousePosition, ((UILine)element).M);
                    if (currentDistance < maxSnapDistance && currentDistance < closestDistance)
                    {
                        if (btnSnapToPoint.Checked) _snapPointPosition = ((UILine)element).M.Clone();
                        closestDistance = currentDistance;
                    }
                }
            }

            _targetPosition = GetTargetPosition();
            #endregion

            #region HoveredElement
            _hoveredElement = null;
            if (!Editing && oLibraryTree.SelectedItem.UIElements.Count > 0)
            {
                // within 10 pixels from mouse 
                double hoverDistance = _graphics.PixelToRealDistanceX(10);
                var query =
                    from element in oLibraryTree.SelectedItem.UIElements
                    where _graphics.GetRealDistance(_mousePosition, element.CenterOfGravity) <= hoverDistance
                    orderby _graphics.GetRealDistance(_mousePosition, element.CenterOfGravity)
                    select element;
                if (query.Count() > 0) _hoveredElement = query.First();
            }
            #endregion

            #region Item
            e.Graphics.DrawString(oLibraryTree.SelectedItem.Name, Control.DefaultFont, Brushes.White, 0, 1);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (LibraryUIElement element in oLibraryTree.SelectedItem.UIElements)
            {
                if (element is UILine) _graphics.DrawLine((UILine)element, element == _hoveredElement);
            }
            #endregion

            #region DragAction
            if (_newLine != null && _newLine.Valid)
            {
                _graphics.DrawLine(_newLine, true);
            }
            #endregion

            if (_snapPosition != null)
            {
                _graphics.DrawPoint(_snapPosition, Color.Yellow);
            }

            #region Cursor
            this.Cursor = Cursors.Default;
            if (_hoveredElement != null || Editing) this.Cursor = Cursors.Hand;
            #endregion
        }
        private void pnlGraphic_SizeChanged(object sender, EventArgs e)
        {
            pnlGraphic.Invalidate();
        }
        private void pnlGraphic_MouseMove(object sender, MouseEventArgs e)
        {
            #region UpdateNewUIElements
            if (_newLine != null) _newLine.P2 = _targetPosition;
            #endregion

            pnlGraphic.Invalidate();
        }

        private void lblZoom_Click(object sender, EventArgs e)
        {
            UpdateZoomValue(0.1);
        }
        private void pnlGraphic_MouseEnter(object sender, EventArgs e)
        {
            pnlGraphic.Focus();
        }
        private void pnlGraphic_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) UpdateZoomValue(_scale + _scale * 0.05);
            else UpdateZoomValue(_scale - _scale * 0.05);
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            btnToolLine.Checked = false;
            btnToolCircle.Checked = false;
            btnToolArc.Checked = false;
            btnToolPolygon.Checked = false;

            ((ToolStripButton)sender).Checked = true;
        }

        private void pnlGraphic_MouseDown(object sender, MouseEventArgs e)
        {
            if (oLibraryTree.SelectedItem == null) return;

            if (e.Button == MouseButtons.Left)
            {
                _newLine = new UILine();
                _newLine.ItemID = oLibraryTree.SelectedItem.ID;
                _newLine.P1 = _targetPosition;
                _newLine.P2 = _targetPosition;
            }
        }
        private void pnlGraphic_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            if (_newLine != null && _newLine.Valid)
            {
                LibraryComp comp = new LibraryComp();
                comp.AddUIElement(oLibraryTree.SelectedLibrary, _newLine);
            }
            else if (_hoveredElement != null)
            {
                EditUIElement dialog = new EditUIElement(_hoveredElement);
                dialog.PropertyChanged += new EditUIElement.PropertyChangedEventHandler(dialog_PropertyChanged);
                dialog.ShowDialog();
            }

            _newLine = null;
            pnlGraphic.Invalidate();
        }

        void dialog_PropertyChanged()
        {
            LibraryComp comp = new LibraryComp();
            comp.UpdateItem(oLibraryTree.SelectedLibrary, oLibraryTree.SelectedItem);

            pnlGraphic.Invalidate();
        }

        #region ContextMenu
        private void ctxtEdit_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_hoveredElement == null) e.Cancel = true;
        }
        private void mniDelete_Click(object sender, EventArgs e)
        {
            LibraryComp comp = new LibraryComp();
            comp.DeleteUIElement(oLibraryTree.SelectedLibrary, _hoveredElement);

            pnlGraphic.Invalidate();
        }
        #endregion

        private void btnSnap_Click(object sender, EventArgs e)
        {
            ((ToolStripButton)sender).Checked = !((ToolStripButton)sender).Checked;
        }

        private Boolean Editing
        {
            get { return _newLine != null; }
        }
    }
}
