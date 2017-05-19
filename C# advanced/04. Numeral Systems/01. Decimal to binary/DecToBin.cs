using System;

namespace _01.Decimal_to_Binary
{
    class DecToBin
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(binary);
        }
    }
}

