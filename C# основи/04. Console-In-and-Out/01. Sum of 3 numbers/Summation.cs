using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_of_3_numbers
{
    class Summation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if ( a >= -1000 && a <= 1000 &&  b >= -1000 && b <= 1000 && c >= -1000 && c <= 1000 )
            {
                double value = a + b + c; 
                Console.WriteLine(value);
            }
        }
    }
}
