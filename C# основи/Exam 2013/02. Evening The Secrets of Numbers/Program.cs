using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Evening_The_Secrets_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            var digits = number.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
            
            int specialSum = 0; 
            for (int i = 0; i < digits.Length; i++)
			{
                if (digits[i] % 2 == 1)
	            {
                    specialSum += digits[i] * ((i + 1) * (i + 1));
	            }
                else if (digits[i] % 2 == 0)
                {
                    specialSum += digits[i] * digits[i] * (i + 1);
                }
			}
            Console.WriteLine(specialSum);
            if ()
            {
                
            }
            else
            {
                Console.WriteLine("{0} has no secret alpha-sequence", number);  
            }
        }
    }
}
