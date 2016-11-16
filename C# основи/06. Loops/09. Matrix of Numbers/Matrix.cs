using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Matrix_of_Numbers
{
    class Matrix
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int startNumber = 1;
            for (int i = startNumber; i <= x; i++)
            {
                for (int j = i; j < x + i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}