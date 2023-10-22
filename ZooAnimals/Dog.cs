using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class Dog : Animal //Subclass inheriting from class Animal
    {
        public bool WagTail { get; set; } //Property specific for this class

        //Constructor, assigning default values for all variables
        public Dog() : base("brown", "dog", "Woof", 13, "Meat")
        {
            WagTail = true;
        }

        public virtual void IsWaggingTail() //Method specificly for this subclass
        {
            if (WagTail) //If-loop to write out different text dependending on bool result
            {
                Console.WriteLine("The dog is happily wagging its tail!");
            }
            else 
            { 
                Console.WriteLine("The dog is not wagging its tail...");
            }
        }
    }
}
