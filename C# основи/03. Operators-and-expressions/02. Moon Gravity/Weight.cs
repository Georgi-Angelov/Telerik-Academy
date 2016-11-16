using System;

namespace _02.Moon_Gravity
{
    class Weight
    {
        static void Main(string[] args)
        {
            double weight;
            if (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Input was not an integer.");
                return;
            }
            
            double weightMoon;
            weightMoon = weight * (17.0 / 100.0);
            if ( weight < 0 && weight > 1000 )
            {
                Console.WriteLine("Choose weight less than 1000");
            }
            else
            {
                Console.WriteLine("{0:F3}", weightMoon);
            }
        }
    }
}
