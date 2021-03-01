using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker.Models.HitboxShapes
{
    public class Circle : ICartesianable
    {
        public double radius;
        public double XPos { get; set; }
        public double YPos { get; set; }
    }
}
