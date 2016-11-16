using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint head = uint.Parse(Console.ReadLine());
            uint c = uint.Parse(Console.ReadLine());
            
            uint bestComb = 0;
            int bestCount = 0;
            for (int i = 0; i < c; i++)
            {
                uint combs = uint.Parse(Console.ReadLine());
                if ((head & combs) == 0)
                {
                    int currentCount = 0;
                    for (int j = 0; j < 32; j++)
                    {
                        currentCount += (int)(combs >> j) & 1;

                    }
                    if (bestCount < currentCount)
                    {
                        bestCount = currentCount;
                        bestComb = combs;
                    }
                }
            }
            Console.WriteLine(bestComb);
           
        }
    }
}
