using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Bird : Animal
    {
        /// <summary>
        /// This overrides the habitat for the bird to be in the air; it is changed later on too.
        /// </summary>
        public override string Habitat { get; set; } = "air";

        /// <summary>
        /// This initializes a virtual method called Sound() and sets it to "honk"
        /// </summary>
        /// <returns>honk</returns>
        public virtual string Sound ()
        {
            return "honk";
        }

        /// <summary>
        /// This overrides the fastest movement for a bird to be flying
        /// </summary>
        /// <returns>I belive I can fly</returns>
        public override string FastestMovement()
        {
            return "fly";
        }
    }
}
