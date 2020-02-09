using System;
using System.Drawing;

namespace SnakeGame
{
    abstract class Food : IFood
    {
        private int point = 5;
        private Rectangle food;
        private int x, y, width, height;
        private Random rnd = new Random();

        public Rectangle Body
        {
            get { return food; }
        }

        public virtual int Point
        {
            get { return point; }
        }

        public Food()
        {
            Move();
            width = 10;
            height = 10;
            food = new Rectangle(x, y, width, height);
        }

        public void Move()
        {
            x = rnd.Next(0, 400);
            y = rnd.Next(0, 200);
        }

        public virtual void Draw(Graphics g, Color color)
        {
            food.X = x;
            food.Y = y;
        }
    }
}