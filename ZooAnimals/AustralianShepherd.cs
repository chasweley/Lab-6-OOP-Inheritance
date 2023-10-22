using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class AustralianShepherd : Dog
    {
        public int Active { get; set; }

        public AustralianShepherd(int active)
        {
            Active = active;
        }

        public string Agility (int active)
        {
            if (Active < 50) return "The Australian Shepherd is bad at agility.";
            else return "The Australian Shepherd is good at agility.";
        }
    }
}
