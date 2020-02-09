using System;
using System.Drawing;

namespace SnakeGame
{
    interface ISnake : IDrawable, IMoveable
    {
        Rectangle[] Body { get; }
    }
}