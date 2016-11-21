using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_Polynomials
{
    class Polynomials
    {
        
        static void CompareArrays(string[] first, string[] second, int size)
        {
            int result;
            int firstNumber = 0;
            int secondNumber = 0;

            for (int i = 0; i < size; i++)
            {
                firstNumber = int.Parse(first[i]);
                secondNumber = int.Parse(second[i]);
                result = firstNumber + secondNumber;
                if (i + 1 == size)
                {
                    Console.Write(result);
                }
                else
                {
                    Console.Write(result + " ");
                }
            }

        }
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            
            string[] first = Console.ReadLine().Split();
            
            string[] second = Console.ReadLine().Split();
            CompareArrays(first, second, size);
        }
    }
}
