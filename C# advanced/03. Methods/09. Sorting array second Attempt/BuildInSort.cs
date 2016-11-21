using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_array_second_Attempt
{
    class BuildInSort
    {
        static void Minimum(int[] numbers)
        {
            int tempNumber = 0;
            int minNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                tempNumber = numbers[i];
                if (tempNumber < minNumber )
                {
                    minNumber = tempNumber;
                }
            }
            Console.WriteLine(minNumber);
        }
        static void Maximum(int[] numbers)
        {
            int tempNumber = 0;
            int maxNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                tempNumber = numbers[i] ;
                if (tempNumber > maxNumber)
                {
                    maxNumber = tempNumber;
                }
            }
            Console.WriteLine(maxNumber);
        }
        static void Average(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("{0:F}", sum / numbers.Length);
        }
        static void Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
        static void Product(int[] numbers)
        {
            int product = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine(product);
        }
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int[] numbers = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                numbers[i] = int.Parse(num[i]);
            }
            Minimum(numbers);
            Maximum(numbers);
            Average(numbers);
            Sum(numbers);
            Product(numbers);
        }

    }
}
