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

        public override string DrawString { get; } = "██████████████████";

        public override ConsoleColor Color { get; } = ConsoleColor.Red;

    }
}
