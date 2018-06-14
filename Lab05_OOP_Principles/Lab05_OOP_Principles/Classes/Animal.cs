using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Animal
    {
        public abstract string Habitat { get; set; }

        public virtual bool CaresForYoung { get; set; } = true;

        public abstract string FoodAquisition();

        public abstract string FastestMovement();

        public virtual string Birth()
        {
            return "eggs";
        }
    }
}
