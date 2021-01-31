using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker
{
    /// <summary>
    /// The ball that bounces around the field and smashes bricks!
    /// </summary>
    /// <seealso cref="BrickBreaker_CSharp.Classes.Entity" />
    class Ball : Entity
    {
        public double XMomentum { get; set; } = 0;

        public double YMomentum { get; set; } = 0;

        public override string DrawString { get; } = "*";
        public override ConsoleColor Color { get; } = ConsoleColor.Green;

        public Ball(double xPos, double yPos) : base(xPos,yPos)
        {
        }

        public void updatePos(double frameDeltaMultiplier)
        {
            this.XPos += this.XMomentum * frameDeltaMultiplier;
            this.YPos += this.YMomentum * frameDeltaMultiplier;
        }




    }
}
