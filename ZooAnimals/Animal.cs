using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class Animal
    {
        public string Color { get; set; } //Setting properties
        public string Species { get; set; }
        public string Sound { get; set; }
        public int HoursOfSleep { get; set; }
        public string Food { get; set; }

        //Constructor for required variables
        public Animal(string color, string species, string sound, int hoursOfSleep, string food) 
        {
            Color = color;
            Species = species;
            Sound = sound;
            HoursOfSleep = hoursOfSleep;
            Food = food;
        }

        //Base class methods all animals to inherit by subclasses
        public void Sleeping ()
        {
            Console.WriteLine($"Zzzzz.... The {Color} {Species} needs about {HoursOfSleep} hours of sleep every day!");
        }

        public void LikeToEat () {
            Console.WriteLine($"{Food} is what the {Color} {Species} likes to eat. Omnomnomnom!");
        }

        public void makeSound () 
        {
            Console.WriteLine($"{Sound}!");
        }

    }
}
