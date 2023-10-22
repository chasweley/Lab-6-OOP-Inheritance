using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPInheritance
{
    internal class Dachshund : Dog
    {
        public int Dig { get; set; }
        public Dachshund(int dig) 
        {
            Dig = dig;
        }

        public string Digging (int dig)
        {
            if (dig < 50) return "This Dachshund can't dig very well.";
            else return "This dachshund is digging so well!";
        }
    }
}
