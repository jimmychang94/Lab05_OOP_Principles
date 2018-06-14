using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Principles.Interface;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Penguin : Bird, ISwim
    {
        public override string Habitat { get; set; } = "ocean";

        public override string FastestMovement()
        {
            return "swim";
        }

        public override string FoodAquisition()
        {
            return "catches fish";
        }

        public string Sing()
        {
            return "under the SEA, under the sea";
        }
    }
}
