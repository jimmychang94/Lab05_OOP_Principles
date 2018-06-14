using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Shark : Fish
    {
        public override string FoodAquisition()
        {
            return "Hunts for prey on their own";
        }
    }
}
