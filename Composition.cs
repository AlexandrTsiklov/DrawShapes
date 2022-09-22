using System;
using System.Drawing;

namespace KP
{
    public class Composition : CircleInCircle
    {
        private const int CornersCount = 5;
        public Polygon[] Polygons = new Polygon[CornersCount];
        
        public Composition(Point pos, int firstRadius, int secondRadius, Color bigOutlineColor, 
            Color bigFillColor, Color smallOutlineColor, Color smallFillColor, Color polygonOutlineColor, 
            Color polygonFillColor, int cornersNumber) 
            : base(pos, firstRadius, secondRadius, bigOutlineColor, bigFillColor, smallOutlineColor, smallFillColor)
        {
            var points = new Point[CornersCount];
            double z = 0;
            var angle = 360.0 / CornersCount;
            var rad = BigRadius + SmallRadius;

            for (int i = 0; i < CornersCount; i++)
            {
                points[i].X = (int)(CenterPos.X - SmallRadius / 2 + (float)Math.Round(Math.Cos(z / 180 * Math.PI) * rad));
                points[i].Y = (int)(CenterPos.Y - SmallRadius / 2 + (float)Math.Round(Math.Sin(z / 180 * Math.PI) * rad));
                z += angle;
            }

            var rand = new Random();

            for (int i = 0; i < CornersCount; i++)
            {
                Polygons[i] = new Polygon(points[i], new Size(SmallRadius, SmallRadius), polygonFillColor, polygonOutlineColor,
                    cornersNumber);
            }
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            for (int i = 0; i < CornersCount; i++)
            {
                Polygons[i].Draw(g);
            }
        }

        public void ChangeColor(Color bigOutlineColor, Color bigFillColor, Color smallFillColor,
            Color polygonOutlineColor, Color polygonFillColor)
        {
            BigCircle.OutlineColor = bigOutlineColor;
            BigCircle.FillColor = bigFillColor;
            SmallCircle.FillColor = smallFillColor;

            for (int i = 0; i < CornersCount; i++)
            {
                Polygons[i].OutlineColor = polygonOutlineColor;
                Polygons[i].FillColor = polygonFillColor;
            }
        }
    }
}