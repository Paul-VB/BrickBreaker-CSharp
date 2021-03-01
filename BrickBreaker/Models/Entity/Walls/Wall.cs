using BrickBreaker.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker.Classes.Walls
{
    abstract public class Wall : Entity
    {
        public override string[,] AsciiSprite
        {
            get
            {
                if (this.asciiSprite.GetLength(0) == 0 && this.asciiSprite.GetLength(1) == 0)
                {
                    this.asciiSprite = new string[,] {
                        { $"{AnsiControl.BLUE}█" } 
                    };
                }
                return this.asciiSprite;
            }
        }

        public enum WallDirection
        {
            Horizontal,
            Vertical
        }

        /// <summary>
        /// A List of all Wall objects. This will be used by the Ball class to check for collisions
        /// </summary>
        static List<Wall> ListOfAllWalls = new List<Wall>();

        public abstract WallDirection Direction { get;}

        public Wall(double xPos, double yPos) : base(xPos,yPos)
        {
            ListOfAllWalls.Add(this);
        }
    }
}
