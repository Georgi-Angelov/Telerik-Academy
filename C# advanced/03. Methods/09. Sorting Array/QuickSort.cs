using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSort
{
    class Program
    {

        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                {
                    left++;
                }
                while (numbers[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static public void QuickSort_Recursive(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort_Recursive(arr, left, pivot - 1);
                }
                    
                if (pivot + 1 < right)
                {
                    QuickSort_Recursive(arr, pivot + 1, right);
                }
            }
        }


        static void Print(int[] numbers, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (i + 1 == size)
                {
                    Console.Write(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int start = 0; 
            int size = int.Parse(Console.ReadLine());
            string[] num = Console.ReadLine().Split(); 
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(num[i]);
            }

            QuickSort_Recursive(numbers, start, size - 1);

            Print(numbers, size);

        }
    }
}