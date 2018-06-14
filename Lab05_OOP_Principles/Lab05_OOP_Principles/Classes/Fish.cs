using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Principles.Interface;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Fish : Animal, ISwim
    {
        public override string Habitat { get; set; } = "ocean";

        public override bool CaresForYoung { get; set; } = false;

        public override string FastestMovement()
        {
            return "swim";
        }

        public virtual string Sing()
        {
            return "Under the sea, under the sea";
        }
    }
}
