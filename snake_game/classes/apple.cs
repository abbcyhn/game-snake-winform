using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    class Apple : Food
    {
        private int point = 10;

        public override int Point
        {
            get { return point; }
        }

        public Apple() : base() { }

        public override void Draw(Graphics g, Color color)
        {
            base.Draw(g, color);
            g.FillEllipse(new SolidBrush(color), Body);
        }
    }
}