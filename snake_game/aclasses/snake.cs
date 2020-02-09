using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SnakeGame
{
    abstract class Snake : ISnake
    {
        private int x, y, width, height;
        private Rectangle[] body = new Rectangle[3];
        private bool up, down, right, left;

        public Rectangle[] Body
        {
            get { return body; }
        }

        public Snake()
        {
            x = 60;
            y = 60;
            width = 10;
            height = 10;
            for (int i = 0; i < body.Length; i++)
            {
                body[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }

        public virtual void Draw(Graphics g, Color color)
        {
        }

        public void Move()
        {
            if (up)
            {
                for (int i = body.Length - 1; i > 0; i--)
                   body[i] = body[i - 1];
                body[0].Y -= 10;
            }
            if (down)
            {
                for (int i = body.Length - 1; i > 0; i--)
                    body[i] = body[i - 1];
                body[0].Y += 10;
            }
            if (right)
            {
                for (int i = body.Length - 1; i > 0; i--)
                    body[i] = body[i - 1];
                body[0].X += 10;
            }
            if (left)
            {
                for (int i = body.Length - 1; i > 0; i--)
                    body[i] = body[i - 1];
                body[0].X -= 10;
            }
        }

        public void KeyControl(KeyEventArgs key, Keys UP, Keys DOWN, Keys RIGHT, Keys LEFT)
        {
            if (key.KeyData == UP && down == false) { up = true; down = false; right = false; left = false; }
            if (key.KeyData == DOWN && up == false) { up = false; down = true; right = false; left = false; }
            if (key.KeyData == RIGHT && left == false) { up = false; down = false; right = true; left = false; }
            if (key.KeyData == LEFT && right == false) { up = false; down = false; right = false; left = true; }
        }

        public void Grow()
        {
            List<Rectangle> addedPart = body.ToList();
            addedPart.Add(new Rectangle(body[body.Length-1].X, body[body.Length- 1].Y, width, height));
            body = addedPart.ToArray();
        }
    }
}