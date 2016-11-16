using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    class BinarySearch
    {
        static int Binary(int[] arr, int value)
        {
            int start = 0;
            int end = arr.Length - 1;
            int middle = start + (end - start) / 2;
            while (start <= end)
            {
                if (arr[middle] < value)
                {
                    start = middle + 1;
                }
                else if (arr[middle] > value)
                {
                    end = middle - 1;
                }
                else
                {
                    return middle;
                }

                middle = start + (end - start) / 2;

            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 10, 11, 15, 20, 68, 115, 125 };
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                int indexOfN = Binary(numbers, n);
                Console.WriteLine(n + " " + indexOfN);
            }
        }
    }
}
