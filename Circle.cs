using System.Drawing;
using System.Windows.Forms;

namespace KP
{
    public class Circle : Shape
    {
        private Brush _brush;
        private Pen _pen;

        public Circle(Point pos, Size size, Color fillColor, Color outlineColor = new Color() ) 
            : base(pos, size, fillColor, outlineColor) { }
        public override void Draw(Graphics g)
        {
            _brush = new SolidBrush(FillColor);
            _pen = new Pen(OutlineColor, 4);
            
            g.FillEllipse(_brush, new Rectangle(Pos, Size) );
            g.DrawEllipse(_pen, new Rectangle(Pos, Size));
        }
    }
}