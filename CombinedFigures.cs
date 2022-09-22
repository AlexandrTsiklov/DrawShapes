using System.Drawing;

namespace KP
{
    public class CombinedFigures
    {
        private CircleInCircle _circle;
        private Polygon _polygon;
        private Rectangle _rectangle;
        public CombinedFigures(CircleInCircle circle, Polygon polygon, Rectangle rectangle)
        {
            _circle = circle;
            _polygon = polygon;
            _rectangle = rectangle;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black, 5), _rectangle);
            _circle.Draw(g);
            _polygon.Draw(g);
        }
    }
}