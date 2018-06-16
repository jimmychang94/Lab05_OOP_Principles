using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Reptile : Animal
    {
        /// <summary>
        /// The habitat is first set to land and then will be overridden again for specific environments
        /// </summary>
        public override string Habitat { get; set; } = "Land";

        /// <summary>
        /// CaresForYoung is overridden to be set to false
        /// </summary>
        public override bool CaresForYoung { get; set; } = false;

        /// <summary>
        /// A new virtual property is created to mark whether the reptile has legs or not; it is initially set to true.
        /// </summary>
        public virtual bool HasLegs { get; set; } = true;
    }
}
