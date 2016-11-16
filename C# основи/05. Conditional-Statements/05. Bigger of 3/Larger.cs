using System;

namespace _05.Bigger_of_3
{
    class Larger
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ( a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if ( b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
