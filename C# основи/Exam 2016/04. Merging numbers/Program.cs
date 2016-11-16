using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Merging_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int tempNumber = 0;
            int lastDigit = 0;
            int firstDigit = 0;
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                lastDigit = arr1[i] % 10;
                tempNumber = arr1[i + 1];
                while (tempNumber >= 10)
                {
                    tempNumber /= 10;
                }
                firstDigit = tempNumber;
                Console.Write("{0}{1} ", lastDigit, firstDigit);




            }
            Console.WriteLine();
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("{0} ", arr1[i] + arr1[i + 1]);
            }

        }
    }
}
