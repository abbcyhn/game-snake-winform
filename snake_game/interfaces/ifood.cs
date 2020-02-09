using System;
using System.Drawing;

namespace SnakeGame
{
    interface IFood : IDrawable, IMoveable
    {
        int Point { get; }
        Rectangle Body { get; }
    }
}