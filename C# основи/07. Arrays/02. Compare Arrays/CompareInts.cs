using System;
using System.Linq;

namespace _02.Compare_Arrays
{
    class CompareInts
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = int.Parse(Console.ReadLine());
            }
            int[] second = new int[n];
            for (int i = 0; i < second.Length; i++)
            {
                second[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(first.SequenceEqual(second) ? "Equal" : "Not equal"); 
     
        }
    }
}
