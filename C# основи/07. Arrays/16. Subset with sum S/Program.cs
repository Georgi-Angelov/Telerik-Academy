using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _16.Subset_with_sum_S
{
    class Program
    {
        static void Main(string[] args)
        {
            double B = double.Parse(Console.ReadLine());
            double F = double.Parse(Console.ReadLine());
            if ( B == 0 )
            {
                Console.WriteLine("{0:F4}", 0);
                return;
            }
            double magic1 = 123123123123;
            double magic2 = 317;
            double avrg = F / B;

            double sum = avrg * magic1;
            double division = avrg / magic2;
            if ( B % 2 == 0)
            {
                Console.WriteLine("{0:F4}", sum);
            }
            else if (B % 2 != 0)
            {
                Console.WriteLine("{0:F4}", division);
            }
            else
            {
                Console.WriteLine("{0:F4}", 0);
            }
           

        }
    }
}
