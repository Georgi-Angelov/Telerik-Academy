using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _03.Saddy_Kopper
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int transCount = 0;
            while ( number.Length > 1 && transCount < 10)
            {
                BigInteger product = 1;
                while (number.Length > 0)
                {
                    number = number.Substring(0, number.Length - 1);
                    int sum = 0;
                    for (int i = 0; i < number.Length; i+=2)
                    {
                        sum += (number[i] - '0');
                    }
                    product *= sum != 0 ? sum : 1;
                }
            transCount++;
            number = product.ToString();
            }
            if (transCount < 10) 
            {
                Console.WriteLine(transCount);
            }
            Console.WriteLine(number);
        }
    }
}
