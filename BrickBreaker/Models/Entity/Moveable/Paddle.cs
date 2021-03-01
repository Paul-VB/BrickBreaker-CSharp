using BrickBreaker.Models.Moveable;
using BrickBreaker.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker
{
    public class Paddle : Moveable
    {
        public override double MaxXMomentum { get; } = 5;

        public override double MaxYMomentum { get; } = 5;
        public Paddle(double xPos, double yPos) : base(xPos,yPos)
        {

        }
        public override string[,] AsciiSprite
        {
            get
            {
                if (this.asciiSprite.GetLength(0) == 0 && this.asciiSprite.GetLength(1) == 0)
                {
                    this.asciiSprite = new string[,] {
                        { $"{AnsiControl.RED}█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█" }
                    };
                }
                return this.asciiSprite;
            }
        }


        //AnsiControl.RED + "█ █ █ █ █ █ █ █ █ █    █ █ █ █ █   █ █";
    }
}
