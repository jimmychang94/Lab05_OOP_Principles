using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Principles.Classes
{
    public abstract class Animal
    {
        /// <summary>
        /// Here we make an abstract property called habitat for where the animal lives
        /// </summary>
        public abstract string Habitat { get; set; }

        /// <summary>
        /// Here we make a virtual property which determines if an animal cares for its young which we set to true
        /// </summary>
        public virtual bool CaresForYoung { get; set; } = true;

        /// <summary>
        /// This creates an abstract method which is how the animal gets its food
        /// </summary>
        /// <returns>how to get food</returns>
        public abstract string FoodAquisition();

        /// <summary>
        /// This is an abstract method that marks the fastest way this animal can move
        /// </summary>
        /// <returns>Move</returns>
        public abstract string FastestMovement();

        /// <summary>
        /// This sets a virtual method with how an animal is born
        /// </summary>
        /// <returns>How an animal is born</returns>
        public virtual string Birth()
        {
            return "eggs";
        }
    }
}
