using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Bird : Animal
    {
        public override string Habitat { get; set; } = "air";

        public virtual string Sound ()
        {
            return "honk";
        }

        public override string FastestMovement()
        {
            return "fly";
        }
    }
}
