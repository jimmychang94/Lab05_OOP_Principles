using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Principles.Interface;

namespace Lab05_OOP_Principles.Classes
{
    public class Anaconda : Snake, ISwim
    {
        public override string Habitat { get; set; } = "rainforest";

        public string Sing()
        {
            return "I see a sna-... I mean friend";
        }
    }
}
