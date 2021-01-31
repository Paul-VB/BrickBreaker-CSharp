using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker
{
    public class Paddle : Entity
    {

        public Paddle(double xPos, double yPos) : base(xPos,yPos)
        {

        }
        public override void Draw()
        {
            Console.SetCursorPosition((int)this.XPos, (int)this.YPos);
            ConsoleColor currColor = Console.ForegroundColor;
            Console.ForegroundColor = this.Color;
            Console.Write("█████");
            Console.ForegroundColor = currColor;
        }
    }
}
