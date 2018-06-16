using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Principles.Interface;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Fish : Animal, ISwim
    {
        /// <summary>
        /// This overrides the habitat of a fish to be the ocean
        /// </summary>
        public override string Habitat { get; set; } = "ocean";

        /// <summary>
        /// This overrides the cares for young property to be false
        /// </summary>
        public override bool CaresForYoung { get; set; } = false;

        /// <summary>
        /// This overrides the fastest movement for fish to be swimming
        /// </summary>
        /// <returns>swim</returns>
        public override string FastestMovement()
        {
            return "swim";
        }

        /// <summary>
        /// This is a required method of ISwim which is to swim.
        /// </summary>
        /// <returns></returns>
        public virtual string Sing()
        {
            return "Under the sea, under the sea";
        }
    }
}
