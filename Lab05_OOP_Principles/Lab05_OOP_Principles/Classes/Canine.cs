using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Canine : Mammal
    {
        public override string FoodAquisition()
        {
            return "Hunts for prey in a pack";
        }

        public override bool CanClimb { get; set; } = false;
    }
}
