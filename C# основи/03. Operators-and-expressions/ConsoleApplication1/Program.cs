using System;
namespace ConsoleApplication10
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int positionN = int.Parse(Console.ReadLine());
            byte valueN = byte.Parse(Console.ReadLine());
            long valueLastBit;
            long mask = 1;

            valueLastBit = number >> positionN;
            valueLastBit = valueLastBit & 1;


            if (valueLastBit == 1 && valueN == 1)
            {
                Console.WriteLine(Convert.ToString(number));
            }

            if (valueLastBit == 1 && valueN == 0)
            {
                mask = ~(mask << positionN);
                Console.WriteLine(Convert.ToString(number & mask));
            }

            if (valueLastBit == 0 && valueN == 1)
            {
                mask = mask << positionN;
                Console.WriteLine(Convert.ToString(number | mask));
            }
            if (valueLastBit == 0 && valueN == 0)
            {
                Console.WriteLine(Convert.ToString(number));
            }

        }
    }
}