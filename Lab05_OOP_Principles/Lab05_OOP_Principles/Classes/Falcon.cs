using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Principles.Interface;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Falcon : Bird, IFly
    {
        public bool BarrelRoll()
        {
            return true;
        }

        public override string FoodAquisition()
        {
            return "Hunts from the sky";
        }

        public override string Sound()
        {
            return "cry";
        }

    }
}
