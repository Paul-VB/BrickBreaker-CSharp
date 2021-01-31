using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker.Classes.Walls
{
    abstract public class Wall : Entity
    {


        public enum WallDirection
        {
            Horizontal,
            Vertical
        }

        /// <summary>
        /// A List of all Wall objects. This will be used by the Ball class to check for collisions
        /// </summary>
        static List<Wall> ListOfAllWalls = new List<Wall>();

        public override string DrawString { get; } = "█";

        public abstract WallDirection Direction { get;}

        public override ConsoleColor Color { get; } = ConsoleColor.Blue;
        public Wall(double xPos, double yPos) : base(xPos,yPos)
        {
            ListOfAllWalls.Add(this);
        }
    }
}
