using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class Dachshund : Dog //Subclass inheriting from subclass Dog
    {
        public int Dig { get; set; } //New property for this subclass
        public Dachshund() //Constructor, assigning default value to variable
        {
            Dig = 20;
        }

        public void IsDiggingWell() //Specific method for this subclass
        {
            if (Dig < 50) //If-loop to write out different text dependending on bool result
            {
                Console.WriteLine("This dachshund can't dig very well...");
            }
            else
            {
                Console.WriteLine("This dachshund is digging so well!");
            }
        }
    }
}
