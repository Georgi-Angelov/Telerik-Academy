using System;

namespace _02.Not_Divisible_Numbers
{
    class NotDivisibleBy3and7
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write("{0} ", i);
                }

            }
        }
    }
}
