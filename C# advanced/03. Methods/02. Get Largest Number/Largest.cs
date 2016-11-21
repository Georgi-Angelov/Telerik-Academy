using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Get_Largest_Number
{
    class Largest
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            int c = int.Parse(tokens[2]);
            GetMax(a,b,c);
        }
        static void GetMax(int a, int b, int c)
        {
            if (a > b && a > c)
	        {
		        Console.WriteLine(a);
	        }
            else if (b > a && b > c)
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
