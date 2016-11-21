using System;
using System.Numerics;

namespace _10.FactorialN
{
    class Factorial
    {
        static BigInteger NFactorial(int input)
        {
            BigInteger result = 1;
            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(NFactorial(input));
        }
    }
}
