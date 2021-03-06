using BrickBreaker.Models.Moveable;
using BrickBreaker.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker.Models.Moveable
{
    /// <summary>
    /// The ball that bounces around the field and smashes bricks!
    /// </summary>
    /// <seealso cref="BrickBreaker_CSharp.Classes.Entity" />
    public class Ball : Moveable
    {
        public override double MaxXMomentum { get; } = 5;

        public override double MaxYMomentum { get; } = 5;
        public override string[,] AsciiSprite
        {
            get
            {
                if (this.asciiSprite.GetLength(0) == 0 && this.asciiSprite.GetLength(1) == 0)
                {
                    this.asciiSprite = new string[,] {
                        { $"{AnsiControl.GREEN} ",                  $"N", $"N",                     $" " },
                        { $"{AnsiControl.GREEN}W", $"{AnsiControl.RED}█", $"█", $"{AnsiControl.GREEN}E" },
                        { $"{AnsiControl.GREEN}W", $"{AnsiControl.RED}█", $"█", $"{AnsiControl.GREEN}E" },
                        { $"{AnsiControl.GREEN} ",                  $"S", $"S",                      $" " }
                    };
                }
                return this.asciiSprite;
            }
        }



        public Ball(double xPos, double yPos) : base(xPos, yPos)
        {
        }



    }
}
