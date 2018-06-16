using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Principles.Interface;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Penguin : Bird, ISwim
    {
        /// <summary>
        /// Here we override where the penguins spend most of their time
        /// </summary>
        public override string Habitat { get; set; } = "ocean";

        /// <summary>
        /// Here we override the fastest way a penguin moves which is swimming
        /// </summary>
        /// <returns></returns>
        public override string FastestMovement()
        {
            return "swim";
        }

        /// <summary>
        /// Here we override the way a penguin gets food to be catches fish
        /// </summary>
        /// <returns></returns>
        public override string FoodAquisition()
        {
            return "catches fish";
        }

        /// <summary>
        ///  Here we have the required method for ISwim; which is singing.
        /// </summary>
        /// <returns></returns>
        public string Sing()
        {
            return "under the SEA, under the sea";
        }
    }
}
