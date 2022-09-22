using System.Drawing;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;

namespace KP
{
    public class CircleInCircle
    {
        public Circle SmallCircle { get; set; }
        public Circle BigCircle { get; set; }
        public Point CenterPos { get; set; }
        public int SmallRadius { get; set; }
        public int BigRadius { get; set; }

        public CircleInCircle(Point pos, int firstRadius, int secondRadius, Color bigOutlineColor, 
            Color bigFillColor, Color smallOutlineColor, Color smallFillColor)
        {
            if (firstRadius > secondRadius)
            {
                BigRadius = firstRadius;
                SmallRadius = secondRadius;
            }
            else
            {
                BigRadius = secondRadius;
                SmallRadius = firstRadius;
            }

            CenterPos = new Point(pos.X + BigRadius, pos.Y + BigRadius);
            BigCircle = new Circle(new Point(CenterPos.X - BigRadius, CenterPos.Y - BigRadius),
                new Size(BigRadius * 2, BigRadius * 2), bigFillColor, bigOutlineColor);
            SmallCircle = new Circle(new Point(CenterPos.X - SmallRadius, CenterPos.Y - SmallRadius),
                new Size(SmallRadius * 2, SmallRadius * 2), smallFillColor, smallOutlineColor);
        }

        public virtual void Draw(Graphics g)
        {
            BigCircle.Draw(g);
            SmallCircle.Draw(g);
            g.DrawString($"{BigRadius}", 
                new Font(FontFamily.GenericSerif, SmallCircle.Size.Height/4),
                new SolidBrush(Color.Black), 
                new PointF(SmallCircle.Pos.X + SmallCircle.Size.Height/4, SmallCircle.Pos.Y + SmallCircle.Size.Height/4));
        }
        
        public static CombinedFigures operator +(Polygon a, CircleInCircle b)
        {
            if (a.Size.Width > b.BigRadius)
            {
                return new CombinedFigures(
                    new CircleInCircle(a.Pos,a.Size.Height/2, b.SmallRadius, b.BigCircle.OutlineColor, b.BigCircle.FillColor, b.SmallCircle.OutlineColor, b.SmallCircle.FillColor),
                    a,
                    new Rectangle(a.Pos, a.Size));
            }
            return new CombinedFigures(b, 
                new Polygon(b.BigCircle.Pos, new Size(b.BigRadius*2, b.BigRadius*2),a.FillColor , a.OutlineColor, a.CornerNumber), 
                new  Rectangle(b.BigCircle.Pos, b.BigCircle.Size));
        }
        
        public static CombinedFigures operator +(CircleInCircle b, Polygon a)
        {
            if (a.Size.Width > b.BigRadius)
            {
                return new CombinedFigures(
                    new CircleInCircle(a.Pos,a.Size.Height/2, b.SmallRadius, b.BigCircle.OutlineColor, b.BigCircle.FillColor, b.SmallCircle.OutlineColor, b.SmallCircle.FillColor),
                    a,
                    new Rectangle(a.Pos, a.Size));
            }
            return new CombinedFigures(b, 
                new Polygon(b.CenterPos, new Size(b.BigRadius*2, b.BigRadius*2),a.FillColor , a.OutlineColor, a.CornerNumber), 
                new  Rectangle(b.BigCircle.Pos, b.BigCircle.Size));
        }
    }
}