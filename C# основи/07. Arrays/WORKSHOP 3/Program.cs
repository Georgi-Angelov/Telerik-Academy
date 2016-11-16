using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORKSHOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());
            int n = 0, a = 1, digN, powN;
            
            for ( digN = 1, powN = 10 ; a*10 <= D ; powN *= 10, digN++)
            {
                a = (powN  - powN / 10);
                n += a;
                D -= a * digN;
            }
            n += D / digN;
            Console.WriteLine(n);
        }
    }
}
