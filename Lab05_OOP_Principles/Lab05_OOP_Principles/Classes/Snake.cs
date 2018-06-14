using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Snake : Reptile
    {
        public override bool HasLegs { get; set; } = false;

        public override string FoodAquisition()
        {
            return "Hunts by ambushing prey";
        }

        public override string FastestMovement()
        {
            return "slithering";
        }
    }
}
