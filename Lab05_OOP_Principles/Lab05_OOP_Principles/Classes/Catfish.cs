using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Catfish : Fish
    {
        public override string Habitat { get; set; } = "lakes and rivers";

        public override string FoodAquisition()
        {
            return "Eats what it finds";
        }

        public override string Sing()
        {
            return "down here all the fish are happy";
        }
    }
}
