using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Principles.Interface;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Duck : Bird, ISwim, IFly
    {
        /// <summary>
        /// This overrides the habitat to be on lakes and rivers
        /// </summary>
        public override string Habitat { get; set; } = "lakes and rivers";

        /// <summary>
        /// This is a required method for the IFly interface, doing a barrelroll and ducks can't do it.
        /// </summary>
        /// <returns>fail</returns>
        public bool BarrelRoll()
        {
            return false;
        }

        /// <summary>
        /// This overrides how the duck gets food to be by eating plants and bugs
        /// </summary>
        /// <returns>nom</returns>
        public override string FoodAquisition()
        {
            return "eating plants and bugs";
        }

        /// <summary>
        /// This is a required method for the ISwim interface, singing, which is quacking for a duck
        /// </summary>
        /// <returns>quack-quack-quack</returns>
        public string Sing()
        {
            return "quack-quack-quack";
        }

        /// <summary>
        /// This overrides the method Sound to be a duck's quack
        /// </summary>
        /// <returns>quack</returns>
        public override string Sound()
        {
            return "quack";
        }
    }
}
