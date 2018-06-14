using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
   public class HouseCat : Feline
    {
        public override string Habitat { get; set; } = "House";

        public override string FoodAquisition()
        {
            return "Humans";
        }
    }
}
