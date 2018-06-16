using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Mammal : Animal
    {
        /// <summary>
        /// Here we initialize the Habitat of mammals to be on land; it is specified more in the derived classes
        /// </summary>
        public override string Habitat { get; set; } = "Land";

        /// <summary>
        /// This is a new abstract property which is whether the animal can climb or not
        /// </summary>
        public abstract bool CanClimb { get; set; }

        /// <summary>
        /// This overrides the fastest movement for a mammal which is set to sprinting
        /// </summary>
        /// <returns>sprinting</returns>
        public override string FastestMovement()
        {
            return "sprinting";
        }

        /// <summary>
        /// This overrides the way that mammals are born to be live birth
        /// </summary>
        /// <returns>live birth</returns>
        public override string Birth()
        {
            return "live";
        }
    }
}
