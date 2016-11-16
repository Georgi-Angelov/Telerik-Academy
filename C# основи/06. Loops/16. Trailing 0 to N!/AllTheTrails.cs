using System;
using System.Numerics;

namespace _16.Trailing_0_to_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int zeros = 0;

            while ( n >= 5)
            {
                n /= 5;
                zeros += n;
            }
            Console.WriteLine(zeros);
        }
    }
}
