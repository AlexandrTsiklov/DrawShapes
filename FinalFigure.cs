using System.Drawing;

namespace KP
{
    public class FinalFigure : Composition
    {
        public FinalFigure(Point pos, int firstRadius, int secondRadius, Color bigOutlineColor, Color bigFillColor, Color smallOutlineColor, Color smallFillColor, Color polygonOutlineColor, Color polygonFillColor, int cornersNumber)
            : base(pos, firstRadius, secondRadius, bigOutlineColor, bigFillColor, smallOutlineColor, smallFillColor, polygonOutlineColor, polygonFillColor, cornersNumber)
        {
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);

            var points = new PointF[Polygons.Length];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new PointF(Polygons[i].CenterPos.X, Polygons[i].CenterPos.Y);
            }
            
            g.DrawPolygon(new Pen(Polygons[0].FillColor, 4), points);
        }
    }
}