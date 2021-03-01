using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker.Models.Moveable
{
    public abstract class Moveable : Entity
    {
        /// <summary>
        /// The list of all entities
        /// </summary>
        public static List<Moveable> listOfAllMovables = new List<Moveable>();
        public double XMomentum { get; set; } = 0;
        public abstract double MaxXMomentum { get; }
        public double YMomentum { get; set; } = 0;
        public abstract double MaxYMomentum { get; }
        public Moveable(double xPos, double yPos) : base(xPos, yPos)
        {
            listOfAllMovables.Add(this);
        }
        public void updatePos(double frameDeltaMultiplier)
        {
            //check if we can even do this


            this.XPos += this.XMomentum * frameDeltaMultiplier;
            this.YPos += this.YMomentum * frameDeltaMultiplier;
        }
    }
}
