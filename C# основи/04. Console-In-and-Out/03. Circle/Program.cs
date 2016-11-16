using System;

namespace _3.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            if ( radius > 0 )
            {
                double pi = Math.PI;
                double peri = 2 * (pi * radius);
                double area = pi * (radius * radius);
                Console.WriteLine("{0:0.00} {1:0.00}", peri, area);
            }
          
        }
    }
}
