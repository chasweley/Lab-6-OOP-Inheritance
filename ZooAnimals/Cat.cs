using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class Cat : Animal //Subclass inheriting from class Animal
    {
        public bool Purring { get; set; } //New specific property for this class

        //Constructor, assigning default value to variables
        public Cat() : base("orange", "cat", "Meow", 15, "Meat") 
        {
            Purring = true;
        }

        public void IsPurring() //Specific method for this subclass
        {
            if (Purring) //If-loop to write out different text dependending on bool result
            {
                Console.WriteLine("The cat is purring, it is happy and comfortable!");
            }
            else
            {
                Console.WriteLine("The cat is not purring, beware!");
            }
        }
    }
}
