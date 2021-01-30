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
        public double XPos { get; set; }

        public double YPos { get; set; }

        public abstract void Draw();
    }


}
