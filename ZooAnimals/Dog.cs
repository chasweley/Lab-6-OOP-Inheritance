using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class Dog : Animal
    {
        //Something color
        public override void makeNoise()
        {
            Console.WriteLine("Woof!");
        }
    }
}
