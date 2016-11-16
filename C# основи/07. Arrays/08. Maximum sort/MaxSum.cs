using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Maximum_sort
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int maxSum = int.MinValue;
            int sum = 0;
            int tmpStart = 0;
            int end = n;
            int start = 0;

            for (int j = 0; j != n; ++j)
            {
                sum += array[j];
                end = j;

                if (sum > maxSum || (sum == maxSum && (j - tmpStart) > (end - start)))
                {
                    maxSum = sum;
                    start = tmpStart;
                }

                if (sum < 0)
                {
                    sum = 0;
                    tmpStart = j + 1;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
