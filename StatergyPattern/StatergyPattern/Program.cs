using StatergyPattern.ClientOne;
using StatergyPattern.ClientTwo;
using System;

namespace StatergyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CookingMethod cookMethod = new CookingMethod();

            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();           
            cookMethod.SetFood(food);

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (input)
            {
                case 1:
                    cookMethod.SetCookStrategy(new Grilling());
                    cookMethod.Cook();
                    break;

                case 2:
                    cookMethod.SetCookStrategy(new LongGrilling());
                    cookMethod.Cook();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
