﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_Search
{
    class BinSearch
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            int x = int.Parse(Console.ReadLine());
            
            int index = Array.BinarySearch(array, x);
            if (index < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(index);
            }


        }
    }
}
