using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Snake : Reptile
    {
        /// <summary>
        /// Has legs has been overridden to be set to false since snakes don't have legs
        /// </summary>
        public override bool HasLegs { get; set; } = false;

        /// <summary>
        /// The method that snakes get food is overridden to show they ambush prey
        /// </summary>
        /// <returns>ambush</returns>
        public override string FoodAquisition()
        {
            return "Hunts by ambushing prey";
        }

        /// <summary>
        /// The method that snakes moves the fastest is overridden to be slithering
        /// </summary>
        /// <returns>slither</returns>
        public override string FastestMovement()
        {
            return "slithering";
        }
    }
}
