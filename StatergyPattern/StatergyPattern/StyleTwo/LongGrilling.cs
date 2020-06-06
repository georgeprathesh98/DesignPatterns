using System;
using System.Collections.Generic;
using System.Text;

namespace StatergyPattern.ClientTwo
{
    class LongGrilling : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by Long grilling it.");
        }
    }
}
