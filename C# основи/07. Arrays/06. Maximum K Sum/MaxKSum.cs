using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Maximum_K_Sum
{
    class MaxKSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
			{
                array[i] = int.Parse(Console.ReadLine());
			}
            Array.Sort(array);
            Array.Reverse(array);

            for (int i = 0; i < k; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
