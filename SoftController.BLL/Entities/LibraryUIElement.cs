using System;
using System.Drawing;

namespace SoftController.BLL.Entities
{
    public abstract class LibraryUIElement
    {
        private Int64 _id;
        private Int64 _itemID;

        public Int64 ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public Int64 ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }

        public abstract override String ToString();
        public abstract void Parse(String value);

        public String Definition
        {
            get { return this.ToString(); }
            set { Parse(value); }
        }
        public abstract PointD CenterOfGravity
        {
            get;
        }
    }
    public class UILine : LibraryUIElement
    {
        private PointD _p1;
        private PointD _p2;
        private Single _width = 0.001f;
        private Color _color = Color.White;

        public override String ToString()
        {
            return string.Format("L;{0:0.0000};{1:0.0000};{2:0.0000};{3:0.0000};{4:0.000};{5:0}",
                P1.X, P1.Y, P2.X, P2.Y, Width, Color.ToArgb());
        }
        public override void Parse(String value)
        {
            string[] split = value.Split(';');
            if (split[0] == "L")
            {
                Double x1, y1, x2, y2;
                Single width;
                Int32 color;
                if (Double.TryParse(split[1], out x1) && Double.TryParse(split[2], out y1) &&
                    Double.TryParse(split[3], out x2) && Double.TryParse(split[4], out y2) &&
                    Single.TryParse(split[5], out width) && Int32.TryParse(split[6], out color))
                {
                    this.P1 = new PointD(x1, y1);
                    this.P2 = new PointD(x2, y2);
                    this.Width = width;
                    this.Color = Color.FromArgb(color);
                    return;
                }
            }

            throw new ApplicationException("Can't parse UILine (value: " + value + ")");
        }

        public PointD P1
        {
            get { return _p1; }
            set { _p1 = value; }
        }
        public PointD P2
        {
            get { return _p2; }
            set { _p2 = value; }
        }
        public PointD M
        {
            get { return new PointD((P1.X + P2.X) / 2, (P1.Y + P2.Y) / 2); }
        }
        public Single Width
        {
            get { return _width; }
            set 
            {
                if (value < 0.001f) throw new ApplicationException("UILine width can't be lower than 1 mm");
                else if (value > 0.010f) throw new ApplicationException("UILine width can't be higher than 10mm");

                _width = value; 
            }
        }
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public override PointD CenterOfGravity
        {
            get { return new PointD((P1.X + P2.X) / 2, (P1.Y + P2.Y) / 2); }
        }
        public Boolean Valid
        {
            get { return !P1.Equals(P2); }
        }
    }

    public class PointD
    {
        private Double _x, _y;

        public PointD()
        {
        }
        public PointD(Double x, Double y)
        {
            _x = x;
            _y = y;
        }

        public PointD Clone()
        {
            return new PointD(X, Y);
        }
        public Boolean Equals(PointD point)
        {
            return (this.X == point.X && this.Y == point.Y);
        }

        public Double X
        {
          get { return _x; }
          set { _x = value; }
        }
        public Double Y
        {
          get { return _y; }
          set { _y = value; }
        }

        public static PointD Empty
        {
            get { return new PointD(); }
        }
        public static implicit operator PointD(Point point)
        {
            return new PointD(point.X, point.Y);
        }
        public static implicit operator PointD(PointF point)
        {
            return new PointD(point.X, point.Y);
        }
    }
}
