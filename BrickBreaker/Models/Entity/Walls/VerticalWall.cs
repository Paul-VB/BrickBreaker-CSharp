using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker.Classes.Walls
{
    public class VertialWall : Wall
    {
        public override WallDirection Direction { get { return WallDirection.Vertical; } }

        public VertialWall(double xPos, double yPos) : base(xPos, yPos)
        {

        }


    }
}
