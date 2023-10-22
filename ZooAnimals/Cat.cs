using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class Cat : Animal
    {
        //Something color
        public override void makeNoise()
        {
            Console.WriteLine("Meow!");
        }
    }
}
