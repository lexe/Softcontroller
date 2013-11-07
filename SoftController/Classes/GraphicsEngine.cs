using System;
using System.Drawing;
using SoftController.BLL.Entities;

namespace SoftController.Classes
{
    public class GraphicsEngine
    {
        private Graphics _graphics;
        private Point _offset;
        private PointD _scaledOffset;
        private Double _scale;

        public GraphicsEngine(Graphics graphics, Point offset, PointF scaledOffset, Double scale)
        {
            _graphics = graphics;
            _offset = offset;
            _scaledOffset = scaledOffset;
            _scale = scale;
        }

        private Pen _pen = new Pen(Color.White);

        public void DrawPoint(PointD point, Color color)
        {
            _pen.Color = color;
            _pen.Width = 2;
            _graphics.DrawEllipse(_pen,
                _offset.X + RealToPixelDistanceX(point.X) - 3,
                _offset.Y - RealToPixelDistanceY(point.Y) - 3,
                6, 6);
        }
        public void DrawLine(UILine line, Boolean hovered)
        {
            _pen.Color = line.Color;
            _pen.Width = RealToPixelDistance(line.Width, _graphics.DpiX);
            if (hovered) _pen.Width += 2;
            _graphics.DrawLine(_pen,
                _offset.X + RealToPixelDistanceX(line.P1.X + _scaledOffset.X),
                _offset.Y - RealToPixelDistanceY(line.P1.Y + _scaledOffset.Y),
                _offset.X + RealToPixelDistanceX(line.P2.X + _scaledOffset.X),
                _offset.Y - RealToPixelDistanceY(line.P2.Y + _scaledOffset.Y));

            DrawPoint(line.CenterOfGravity, hovered ? Color.Orange : Color.DodgerBlue);
        }

        public void DrawHoneyComb(Int32 areaWidth, Int32 areaHeight)
        {
            _graphics.Clear(Color.Black);

            Single width = 25;
            Single side = Convert.ToSingle(width * Math.Tan(Math.PI / 6));
            Single offsetX, offsetY;
            Pen pen = new Pen(Color.FromArgb(40, 40, 40));

            Int32 xStop = Convert.ToInt32(areaWidth / width);
            Int32 yStop = Convert.ToInt32(areaHeight / (side * 3 / 2));
            for (int y = 0; y <= yStop; y++)
            {
                offsetX = -(y % 2) * width / 2;
                offsetY = y * side * 3 / 2;
                for (int x = 0; x <= xStop; x++)
                {
                    _graphics.DrawLine(pen,
                      offsetX + x * width, offsetY - side / 2,
                      offsetX + x * width, offsetY + side / 2);
                    _graphics.DrawLine(pen,
                        offsetX + x * width, offsetY - (side / 2),
                        offsetX + x * width + width / 2, offsetY - side);
                    _graphics.DrawLine(pen,
                        offsetX + x * width + width / 2, offsetY - side,
                        offsetX + (x + 1) * width, offsetY - (side / 2));
                }
            }
        }

        #region Distances
        public Int32 RealToPixelDistanceX(Double realDistance)
        {
            return RealToPixelDistance(realDistance, _graphics.DpiX);
        }
        public Int32 RealToPixelDistanceY(Double realDistance)
        {
            return RealToPixelDistance(realDistance, _graphics.DpiY);
        }
        private Int32 RealToPixelDistance(Double realDistance, Single dpi)
        {
            return Convert.ToInt32(realDistance * _scale / 0.0254 * dpi);
        }
        public Double PixelToRealDistanceX(Double pixelDistance)
        {
            return PixelToRealDistance(pixelDistance, _graphics.DpiX);
        }
        public Double PixelToRealDistanceY(Double pixelDistance)
        {
            return PixelToRealDistance(pixelDistance, _graphics.DpiY);
        }
        private Double PixelToRealDistance(Double pixelDistance, Single dpi)
        {
            return pixelDistance / dpi * 0.0254 / _scale;
        }

        public Double GetRealDistance(PointD p1, PointD p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
        public Int32 GetPixelDistance(Point p1, Point p2)
        {
            return Convert.ToInt32(Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2)));
        }
        #endregion
    }
}
