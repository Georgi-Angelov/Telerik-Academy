using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem_1
{
    class MagicCat
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());
            double sum = 0;
            int thirdDigit = magicNumber % 10;
            magicNumber /= 10;
            int secondDigit = magicNumber % 10;
            magicNumber /= 10;
            int firstDigit = magicNumber % 10;
            if (secondDigit % 2 == 0)
            {
                sum = (firstDigit + secondDigit) * thirdDigit;
                
            }
            else if (secondDigit % 2 == 1)
            {
                sum = (double)(firstDigit * secondDigit) / thirdDigit;
            }
            else if ( firstDigit == 0 || thirdDigit == 0)
            {
                sum = 0;
            }
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
