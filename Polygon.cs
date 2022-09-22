using System;
using System.Drawing;

namespace KP
{
    public class Polygon : Shape
    {
        public int CornerNumber { get; set; }
        public Point CenterPos { get; set; }

        public Polygon(Point pos, Size size, Color fillColor, Color outlineColor, int cornersNumber) 
            : base(pos, size, fillColor, outlineColor)
        {
            CornerNumber = cornersNumber;
        }

        public override void Draw(Graphics g)
        {
            var points = new PointF[CornerNumber];

            double z = 0;
            var angle = 360.0 / CornerNumber;
            CenterPos = new Point(Pos.X + Size.Width / 2, Pos.Y + Size.Height / 2);
            var rad = CenterPos.X - Pos.X;

            for (int i = 0; i < CornerNumber; i++)
            {
                points[i].X = CenterPos.X + (float)Math.Round(Math.Cos(z / 180 * Math.PI) * rad);
                points[i].Y = CenterPos.Y + (float)Math.Round(Math.Sin(z / 180 * Math.PI) * rad);
                z += angle;
            }
            
            g.DrawPolygon(new Pen(OutlineColor, 3), points);
            g.FillPolygon(new SolidBrush(FillColor), points);
        }
        
        public void Draw(Graphics g, Color outlineColor, Color fillColor)
        {
            var points = new PointF[CornerNumber];

            double z = 0;
            var angle = 360.0 / CornerNumber;
            var centerPos = new Point(Pos.X + Size.Width / 2, Pos.Y + Size.Height / 2);
            var rad = centerPos.X - Pos.X;

            for (int i = 0; i < CornerNumber; i++)
            {
                points[i].X = centerPos.X + (float)Math.Round(Math.Cos(z / 180 * Math.PI) * rad);
                points[i].Y = centerPos.Y + (float)Math.Round(Math.Sin(z / 180 * Math.PI) * rad);
                z += angle;
            }
            
            g.DrawPolygon(new Pen(outlineColor, 3), points);
            g.FillPolygon(new SolidBrush(fillColor), points);
        }
    }
}