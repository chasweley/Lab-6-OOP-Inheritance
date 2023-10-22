using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class Bird : Animal 

        //Something with color
    {
        public override void makeSound()
        {
            Console.WriteLine("Pip pip pip!");
        }
    }
}
