using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_to_Decimal
{
    class BinToDec
    {
        static long ConvertBinaryToDecimal(string inputBinary)
        {
            int digit = 0;
            int position = 0;
            long tempResult = 0;
            for (int i = 0; i < inputBinary.Length; i++)
            {
                digit = inputBinary[i] - '0';
                position = inputBinary.Length - i - 1;
                tempResult += digit * (long)Math.Pow(2, position);
            }
            return tempResult;
        }
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            Console.WriteLine(ConvertBinaryToDecimal(binary));
        }
    }
}