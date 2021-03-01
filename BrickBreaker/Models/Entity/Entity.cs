using BrickBreaker.Models;
using BrickBreaker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BrickBreaker
{
    /// <summary>
    /// This is the parent class of all the game objects.
    /// </summary>
    public abstract class Entity : ICartesianable
    {
        #region properties and fields
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


        protected string[,] asciiSprite = new string[,] { };

        /// <summary>
        ///  a 2d array of strings. Each string represents a "pixel" in the console (pixel meaning one character).
        ///  these "pixels" represent how this entity will appear in the console window.
        /// </summary>
        public abstract string[,] AsciiSprite { get; }

        /// <summary>
        /// a cached backing field for the Width property
        /// </summary>
        private int width = -1;

        /// <summary>
        /// Gets the width of this object. this is based on the DrawStringStripped's width in characters.
        /// </summary>
        public int Width
        {
            get
            {
                if (this.width == -1)
                {
                    this.width = this.AsciiSprite.GetLength(1);
                }
                return this.width;

            }
        }
        /// <summary>
        /// a cached backing field for the Height property
        /// </summary>
        private int height = -1;
        /// <summary>
        /// Gets the height of this object. this is based on the DrawStringStripped's height in characters.
        /// </summary>
        public int Height
        {
            get
            {
                if (this.height == -1)
                {
                    this.height = this.AsciiSprite.GetLength(0);
                }
                return this.height;
            }
        }
        #endregion
        #region constructors
        public Entity(double xPos, double yPos)
        {

            this.XPos = xPos;
            this.YPos = yPos;
            listOfAllEntities.Add(this);
        }

        #endregion



    }


}
