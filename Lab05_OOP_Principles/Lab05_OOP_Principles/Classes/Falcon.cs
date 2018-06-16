using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Principles.Interface;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Falcon : Bird, IFly
    {
        /// <summary>
        /// This is a required method of the IFly interface; whether they can do a barrel roll or not; which is true
        /// </summary>
        /// <returns>yes</returns>
        public bool BarrelRoll()
        {
            return true;
        }

        /// <summary>
        /// This overrides how a falcon gets its food; by diving on the prey from the sky
        /// </summary>
        /// <returns>skydive</returns>
        public override string FoodAquisition()
        {
            return "Hunts from the sky";
        }

        /// <summary>
        /// This overrides the sound method to be a falcon's cry 
        /// </summary>
        /// <returns>Cry</returns>
        public override string Sound()
        {
            return "cry";
        }

    }
}
