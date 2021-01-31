using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker
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

        /// <summary>
        /// the position of this entity along the X axis.
        /// </summary>
        public double XPos { get; set; }

        /// <summary>
        /// the position of this entity along the Y axis.
        /// </summary>
        public double YPos { get; set; }

        /// <summary>
        /// the string representation of this entity class as it will appear in the console window.
        /// </summary>
        public abstract string DrawString { get; }

        public Entity(double xPos, double yPos)
        {
            this.XPos = xPos;
            this.YPos = yPos;
            listOfAllEntities.Add(this);
        }

        /// <summary>
        /// The color of this entity as it will appear in the console window.
        /// </summary>
        public abstract ConsoleColor Color { get; }

        public virtual void Draw()
        {
            try
            {
                Console.SetCursorPosition((int)this.XPos, (int)this.YPos);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //looks like we're off screen.
                return;
            }

            ConsoleColor currColor = Console.ForegroundColor;
            Console.ForegroundColor = this.Color;
            Console.Write(this.DrawString);
            Console.ForegroundColor = currColor;
        }
    }


}
