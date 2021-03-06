﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BrickBreaker.Models
{
    /// <summary>
    /// This interface represents things that are able to exist in a Cartesian X,Y coordinate system
    /// </summary>
    /// <autogeneratedoc />
    /// TODO Edit XML Comment Template for ICartesianable
    interface ICartesianable
    {
        /// <summary>
        /// The X position.
        /// </summary>
        public double XPos { get; set; }

        /// <summary>
        /// The Y position.
        /// </summary>
        public double YPos { get; set; }
    }
}
