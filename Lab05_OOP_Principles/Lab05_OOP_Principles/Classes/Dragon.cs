using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Principles.Interface;

namespace Lab05_OOP_Principles.Classes
{
    public class Dragon : Lizard, IFly
    {
        public override string Habitat { get; set; } = "mountain";

        public override bool CaresForYoung { get; set; } = true;

        public override string FastestMovement()
        {
            return "flying";
        }

        public string Breath()
        {
            return "Fire";
        }

        public bool BarrelRoll()
        {
            return true;
        }
    }
}
