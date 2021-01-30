using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker_CSharp.Classes
{
    /// <summary>
    /// The ball that bounces around the field and smashes bricks!
    /// </summary>
    /// <seealso cref="BrickBreaker_CSharp.Classes.Entity" />
    class Ball : Entity
    {
        public double XMomentum { get; set; } = 0;

        public double YMomentum { get; set; } = 0;

        public Ball(double xPos, double yPos)
        {
            this.XPos = xPos;
            this.YPos = yPos;
        }
        public override void Draw()
        {
            Console.SetCursorPosition((int)this.XPos, (int)this.YPos);
            Console.Write("*");
        }


    }
}
