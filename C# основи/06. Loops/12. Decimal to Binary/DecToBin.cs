using System;

namespace _12.Decimal_to_Binary
{
    class DecToBin
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string counter = "";

            while (n >= 1)
            {
                counter = (n % 2) + counter;
                n = n / 2;
            }
            Console.Write(counter);
        }
    }
}
