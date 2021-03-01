using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker.Models.HitboxShapes.Polygon
{
    public class Polygon : ICartesianable
    {
        List<Vertex> vertices = new List<Vertex>();

        public Polygon(double xPos, double yPos)
        {
            this.XPos = xPos;
            this.YPos = yPos;
        }

        public double XPos { get; set; }
        public double YPos { get; set; }


    }
}
