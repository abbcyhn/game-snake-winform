using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    class YellowSnake: Snake
    {
        public YellowSnake() : base() { }

        public override void Draw(Graphics g, Color color)
        {
            for (int i = 0; i < Body.Length; i++ )
                g.FillEllipse(new SolidBrush(color), Body[i]);
        }
    }
}