using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Decimal_to_Binary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string[] chain = number.ToString;
            for (int i = 0; i < chain.Length; i++)
            {
                chain /= 10;
                if (  % 2 == 0)
                {
                    Console.Write("0");
                }
                else if (  % 2 != 0)
                {

                }
            }
        }
    }
}
