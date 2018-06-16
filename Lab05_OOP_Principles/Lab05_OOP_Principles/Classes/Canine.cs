using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Canine : Mammal
    {
        /// <summary>
        /// This overrides how a canine gets food to be hunting in packs
        /// </summary>
        /// <returns>Pack hunt</returns>
        public override string FoodAquisition()
        {
            return "Hunts for prey in a pack";
        }

        /// <summary>
        /// This overrides the property canClimb to be false
        /// </summary>
        public override bool CanClimb { get; set; } = false;
    }
}
