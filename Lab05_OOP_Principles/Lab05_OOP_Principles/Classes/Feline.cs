using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Feline : Mammal
    {
        /// <summary>
        /// This overrides the food acquisition for feline to be hunting for prey on their own
        /// </summary>
        /// <returns>hunt</returns>
        public override string FoodAquisition()
        {
            return "Hunts for prey on their own";
        }

        /// <summary>
        /// This sets the can climb property to be true
        /// </summary>
        public override bool CanClimb { get; set; } = true;
    }
}
