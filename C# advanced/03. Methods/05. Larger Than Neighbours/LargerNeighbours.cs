using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Larger_Than_Neighbours
{
    class LargerNeighbours
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            string[] vafla = Console.ReadLine().Split();
            int[] intVafla = new int[vafla.Length];
            
            LargersNeighboursNow(vafla, intVafla, counter);
        }
        static void LargersNeighboursNow(string[] vafla2, int[] intVafla2, int counter2)
        {
            for (int i = 0; i < vafla2.Length; i++)
            {
                intVafla2[i] = int.Parse(vafla2[i]);
            }
            for (int i = 1; i < intVafla2.Length - 1; i++)
            {
                if (intVafla2[i] > intVafla2[i - 1] && intVafla2[i] > intVafla2[i+1])
                {
                    counter2++;
                }
            }
            Console.WriteLine(counter2);
        }
    }
}
