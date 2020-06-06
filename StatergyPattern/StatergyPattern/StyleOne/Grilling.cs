using System;
using System.Collections.Generic;
using System.Text;

namespace StatergyPattern.ClientOne
{
    class Grilling : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by grilling it.");
        }
    }
}
