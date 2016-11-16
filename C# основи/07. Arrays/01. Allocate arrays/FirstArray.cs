using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Allocate_arrays
{
    class FirstArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int multiplier = 1;
            for (int i = 0; i < array.Length; i++)
            {
                multiplier = i * 5;
                Console.WriteLine(multiplier);
            }
        }
    }
}
