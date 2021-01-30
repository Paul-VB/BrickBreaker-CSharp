using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker_CSharp.Classes
{
    /// <summary>
    /// This is the parent class of all the game objects.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// The list of all entities
        /// </summary>
        public static List<Entity> listOfAllEntities = new List<Entity>();
        public double XPos { get; set; }

        public double YPos { get; set; }

        public Entity(double xPos, double yPos)
        {
            this.XPos = xPos;
            this.YPos = yPos;
            listOfAllEntities.Add(this);
        }

        public ConsoleColor Color { get; set; } = ConsoleColor.White;

        public abstract void Draw();
    }


}
