using System;

namespace _03.Divide_by_7_and_5
{
    class Division
    {
        static void Main(string[] args)
        {
            int devider;
            if (!int.TryParse(Console.ReadLine(), out devider))
            {
                Console.WriteLine("Input was not an integer. \nPlease input an intiger!");
                return;
            }

            if (devider % 7 == 0 && devider % 5 == 0)
            {
                Console.WriteLine("true" + " " + devider);
            }
            else
                Console.WriteLine("false" + " " + devider);
        }
    }
}
