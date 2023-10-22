using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class AustralianShepherd : Dog //Subclass inheriting from subclass Dog
    {
        public int Active { get; set; }

        public AustralianShepherd() //Constructor, assigning default value to variable
        {
            Active = 60; 
        }

        public void Agility() //Specific method for this subclass
        {
            if (Active < 50) //If-loop to write out different text dependending on bool result
            {
                Console.WriteLine("The australian shepherd is bad at agility...");
            }
            else
            {
                Console.WriteLine("The australian shepherd is good at agility!");
            }
        }
    }
}
