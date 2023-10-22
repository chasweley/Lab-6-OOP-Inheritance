using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class Animal
    {
        public string Color { get; set; }
        public int Paws { get; set; }
        public string Sound { get; set; }
        public string SleepTime { get; set; }
        public string Eat { get; set; }

        public Animal(string color, int paws, string sound, string sleepTime, string eat) 
        {
            Color = color;
            Paws = paws;
            Sound = sound;
            SleepTime = sleepTime;
            Eat = eat;
        }

        public virtual void Sleeping ()
        {
            Console.WriteLine("The animal needs sleep to survive!");
        }

        public virtual void Eating () {
            Console.WriteLine("The animal needs food to survive!");
        }

        public virtual void makeSound () {
            Console.WriteLine("The animal is making a sound!");
        }

    }
}
