using System;

namespace _05.Third_Digit
{
    class ThirdDigit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int intSeven = number / 100;
            int intSeven2 = intSeven % 10;

            if (intSeven2 == 7)
            {
                Console.WriteLine("true");
            }
            else
            {

                Console.WriteLine("false {0}", intSeven2);
            }
        }
    }
}
