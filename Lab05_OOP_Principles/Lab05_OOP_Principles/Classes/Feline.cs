using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Feline : Mammal
    {
        public override string FoodAquisition()
        {
            return "Hunts for prey on their own";
        }

        public override bool CanClimb { get; set; } = true;
    }
}
