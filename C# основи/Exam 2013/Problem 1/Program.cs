using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            
            double inMachine = n1 * 0.05 + n2 * 0.1 + n3 * 0.2 + n4 * 0.5 + n5 * 1;
            Console.WriteLine(inMachine);
            if ( A >= P )
            {
                double change = A - P;
                if (change <= inMachine)
                {
                    Console.WriteLine("Yes {0:F2}", inMachine - change );
                }
                else
                {
                    Console.WriteLine("No {0:F2}", change - inMachine);
                }
                
            }
            else
            {
                Console.WriteLine("More {0:F2}", P - A);
            }
            
        }
    }
}



