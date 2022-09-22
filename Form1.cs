using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KP
{
    public partial class Form1 : Form
    {
        private CircleInCircle _circleInCircle;
        private Composition _composition;
        private Polygon _polygon;
        private Graphics g;
        private Random _rand;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            _rand = new Random();
        }

        private void FirstExBtn_Click(object sender, EventArgs e)
        {
            Refresh();
            var firstRadius = 200;
            var secondRadius = 100;
            var bigOutlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var bigFillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var smallOutlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var smallFillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));

            _circleInCircle = new CircleInCircle(
                new Point(Width / 2 - firstRadius - 60, Height / 2 - firstRadius - 20), firstRadius, secondRadius, 
                bigOutlineColor, bigFillColor, smallOutlineColor, smallFillColor);
            _circleInCircle.Draw(g);
        }

        private void SecondExBtn_Click(object sender, EventArgs e)
        {
            Refresh();
            var size = 400;
            var cornersNumber = new Random().Next(3, 10);
            var fillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var outlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            
            _polygon = new Polygon(new Point(Width / 2 - size / 2 - 60, Height / 2 - size / 2 - 20), new Size(size, size), 
                fillColor, outlineColor, cornersNumber);
            _polygon.Draw(g);
        }

        private void ThirdExBtn_Click(object sender, EventArgs e)
        {
            Refresh();
            var firstRadius = 200;
            var secondRadius = 100;
            var bigOutlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var bigFillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var smallOutlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var smallFillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var cornersNumber = new Random().Next(3, 10);
            var fillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var outlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));

            _composition = new Composition(new Point(Width / 2 - firstRadius - 60, Height / 2 - firstRadius - 20),
                firstRadius, secondRadius, bigOutlineColor, bigFillColor, smallOutlineColor, smallFillColor,
                outlineColor, fillColor, cornersNumber);
            _composition.Draw(g);
        }

        private void FourthExBtn_Click(object sender, EventArgs e)
        {
            Refresh();
            var firstRadius = 200;
            var secondRadius = 100;
            var size = 400;
            var bigOutlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var bigFillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var smallOutlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var smallFillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var cornersNumber = new Random().Next(3, 10);
            var fillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var outlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            
            _circleInCircle = new CircleInCircle(
                new Point(Width / 2 - firstRadius - 60, Height / 2 - firstRadius - 20), firstRadius, secondRadius, 
                bigOutlineColor, bigFillColor, smallOutlineColor, smallFillColor);
            _polygon = new Polygon(new Point(Width / 2 - size / 2 - 60, Height / 2 - size / 2 - 20), new Size(size, size), 
                fillColor, outlineColor, cornersNumber);

            var combinedFigure = _circleInCircle + _polygon;
            combinedFigure.Draw(g);
        }

        private void FifthExBtn_Click(object sender, EventArgs e)
        {
            Refresh();
            var firstRadius = 200;
            var secondRadius = 100;
            var size = 400;
            var bigOutlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var bigFillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var smallOutlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var smallFillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var cornersNumber = new Random().Next(3, 10);
            var fillColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));
            var outlineColor = Color.FromArgb(255, _rand.Next(0, 255), _rand.Next(0, 255), _rand.Next(0, 255));

            var finalFigure = new FinalFigure(new Point(Width / 2 - size / 2 - 60, Height / 2 - size / 2 - 20),
                firstRadius, secondRadius, bigOutlineColor, bigFillColor, smallOutlineColor, smallFillColor,
                outlineColor, fillColor, cornersNumber);
            finalFigure.Draw(g);
        }
    }
}