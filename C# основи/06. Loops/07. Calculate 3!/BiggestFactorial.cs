using System;
using System.Numerics;

namespace _06.Calculate_Again_
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factorialZ = 1;
            BigInteger z = n - k;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
                if (i <= z)
                {
                    factorialZ *= i;
                }
            }

            
            Console.WriteLine(factorialN / (factorialK * factorialZ));
        }
    }
}