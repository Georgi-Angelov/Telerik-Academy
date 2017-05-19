using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hexadecimal_To_Decimal
{
    class HexToDec
    {
        static long ConvertHexToDec(string number)
        {
            long result = 0;
            foreach (char digit in number)
            {
                long digitValue = 0;
                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0';
                }
                else
                {
                    digitValue = digit - 'A' + 10;
                }
                result = 16 * result + digitValue;
            }
            return result;
        }

        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ConvertHexToDec(number));
        }
    }
}