using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Reptile : Animal
    {
        public override string Habitat { get; set; } = "Land";

        public override bool CaresForYoung { get; set; } = false;

        public virtual bool HasLegs { get; set; } = true;
    }
}
