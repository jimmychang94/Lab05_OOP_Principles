using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Lizard : Reptile
    {
        public override string FastestMovement()
        {
            return "sprinting";
        }

        public override string FoodAquisition()
        {
            return "Hunts for prey on their own";
        }
    }
}
