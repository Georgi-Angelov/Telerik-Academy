using System;

namespace _13.Comparing_Floats
{
    class CompareFloat
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            if (x - y > 0)
            {
                if (x - y < eps)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                    
            }
            else
            {
                if (y - x < eps)
                {
                    Console.WriteLine("true");
                }
                else
                {
                      Console.WriteLine("false");
                }
                  
            }
        }
    }
}
