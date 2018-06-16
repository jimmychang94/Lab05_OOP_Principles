using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Shark : Fish
    {
        /// <summary>
        /// The shark gets food by hunting for prey by itself
        /// </summary>
        /// <returns>Hunting</returns>
        public override string FoodAquisition()
        {
            return "Hunts for prey on their own";
        }
    }
}
