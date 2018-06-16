using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Lizard : Reptile
    {
        /// <summary>
        /// This overrides the fastest movement for lizards to be sprinting
        /// </summary>
        /// <returns>sprinting</returns>
        public override string FastestMovement()
        {
            return "sprinting";
        }

        /// <summary>
        /// This overrides the way that lizards get food to be hunting on their own
        /// </summary>
        /// <returns>hunt</returns>
        public override string FoodAquisition()
        {
            return "Hunts for prey on their own";
        }
    }
}
