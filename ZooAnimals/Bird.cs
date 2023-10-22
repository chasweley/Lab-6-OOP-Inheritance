using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class Bird : Animal //Subclass inheriting from class Animal
    {
        public bool CanFly { get; set; }

        //Constructor, assigning default value to variables
        public Bird() : base("black", "bird", "Pip pip", 11, "Insects") 
        {
            CanFly = false;
        }
        
        public void CanBirdFly() //Specific method for this subclass
        {
            if (CanFly) //If-loop to write out different text dependending on bool result
            {
                Console.WriteLine("The bird can fly!");
            }
            else
            {
                Console.WriteLine("This is a flightless bird, thus it cannot fly.");
            }
        }
    }
}
