using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Decimal_To_Hexadecimal
{
    class DecToHex
    {
        static void DeciToHexCalc(string input, ref long n, ref string result)
        {
            long number = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (n != 0)
                {
                    number = n % 16;
                    n = n / 16;
                    if (number > 9)
                    {
                        char letter = (char)((number - 9 - 1) + 'A');
                        result = (letter.ToString()) + result;
                    }
                    else
                    {
                        result = number + result;
                    }
                }
                else if (n == 0 & input.Length == 1)
                {
                    result = "0";
                }
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long n = long.Parse(input);
            string result = null;
            DeciToHexCalc(input, ref n, ref result);
            Console.WriteLine(result);

        }
    }
}
