using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker.Classes.Walls
{
    public class HorizontalWall : Wall
    {
        public override WallDirection Direction { get { return WallDirection.Horizontal; } }
        public HorizontalWall(double xPos, double yPos) : base(xPos, yPos)
        {

        }

    }
}
