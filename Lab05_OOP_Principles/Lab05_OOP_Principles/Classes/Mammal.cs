using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Mammal : Animal
    {

        public override string Habitat { get; set; } = "Land";

        public abstract bool CanClimb { get; set; }

        public override string FastestMovement()
        {
            return "sprinting";
        }

        public override string Birth()
        {
            return "live";
        }
    }
}
