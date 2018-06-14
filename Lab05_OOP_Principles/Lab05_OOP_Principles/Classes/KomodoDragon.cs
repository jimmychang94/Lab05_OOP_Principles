using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Principles.Interface;

namespace Lab05_OOP_Principles.Classes
{
    public class KomodoDragon : Lizard, ISwim
    {
        public override string Habitat { get; set; } = "island";

        public override string FoodAquisition()
        {
            return base.FoodAquisition() + "and scavenges what they can find";
        }

        public string Sing()
        {
            return "A whole new island";
        }
    }
}
