using System.Drawing;

namespace KP
{
    public abstract class Shape
    {
        public Point Pos { get; set; }
        public Size Size { get; set; }
        public Color FillColor { get; set; }
        public Color OutlineColor {get; set; }
        
        public Shape(Point pos, Size size, Color fillColor, Color outlineColor)
        {
            Pos = pos;
            Size = size;
            FillColor = fillColor;
            OutlineColor = outlineColor;
        }
        
        public abstract void Draw(Graphics g);
    }
}