using System;
using System.Text.RegularExpressions;

namespace _11.Binary_to_Decimal
{
    class BinaryToDecimal
    {
        static void Main()
        {

            string binary = Console.ReadLine();
            string[] binaryArray = Regex.Split(binary, "");
            int counter = 1;
            double dec = 0;
         

            for (int i = binaryArray.Length - 2; i > 0; i--)
            {
                dec += counter * Int32.Parse(binaryArray[i]); // 2*counter* next number in array 
                counter *= 2;
            }
            Console.WriteLine(dec);
        }
    }
}


