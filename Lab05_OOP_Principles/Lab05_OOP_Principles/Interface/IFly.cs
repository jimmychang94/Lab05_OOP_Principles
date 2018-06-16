using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Interface
{
    interface IFly
    {
        /// <summary>
        /// This sets a method that is required for the animals that can fly; whether they can do a barrel roll or not
        /// </summary>
        /// <returns>Do a barrel roll!</returns>
        bool BarrelRoll();
    }
}
