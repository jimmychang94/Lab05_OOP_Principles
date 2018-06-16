using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Catfish : Fish
    {
        /// <summary>
        /// This overrides the habitat for the catfish to be in lakes and rivers
        /// </summary>
        public override string Habitat { get; set; } = "lakes and rivers";

        /// <summary>
        /// This overrides the way a catfish gets food to be scavenging
        /// </summary>
        /// <returns>scavenging</returns>
        public override string FoodAquisition()
        {
            return "Eats what it finds";
        }

        /// <summary>
        /// This overrides the method that is required for the ISwim method to be a different part of the song
        /// It can't be under the sea since catfish don't live in the sea
        /// </summary>
        /// <returns>Under the lake</returns>
        public override string Sing()
        {
            return "down here all the fish are happy";
        }
    }
}
