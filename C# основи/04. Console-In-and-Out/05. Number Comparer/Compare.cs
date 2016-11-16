using System;

namespace _07SumOf5Numbers
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double sqrtpart = (b * b) - (4 * a * c);
            
            if ( sqrtpart > 0 )
            {
                double root1 = ((-1) * b - Math.Sqrt(sqrtpart)) / (2 * a);
                double root2 = ((-1) * b + Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("{0:F2}", root1);
                Console.WriteLine("{0:F2}", root2);
            }
            
            else if (sqrtpart == 0)
            {
                double root1 = ((-1) * b) / (2 * a);
                Console.WriteLine("{0:F2}", root1);
              
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}