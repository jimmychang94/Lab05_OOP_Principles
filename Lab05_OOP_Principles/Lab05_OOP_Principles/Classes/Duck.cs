using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Principles.Interface;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Duck : Bird, ISwim, IFly
    {
        public override string Habitat { get; set; } = "lakes and rivers";

        public bool BarrelRoll()
        {
            return false;
        }

        public override string FoodAquisition()
        {
            return "eating plants and bugs";
        }

        public string Sing()
        {
            return "quack-quack-quack";
        }

        public override string Sound()
        {
            return "quack";
        }
    }
}
