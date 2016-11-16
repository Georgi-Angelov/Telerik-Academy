using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Drunken_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            int v = 0; 
            for (int i = 0; i < n; i++)
            {
                int roundInfo = int.Parse(Console.ReadLine());
                if ( roundInfo < 0)
                {
                    roundInfo = roundInfo * -1;
                }
                int digits = 0;
                int tempRoungInfo = roundInfo;
                while (tempRoungInfo > 0)
                {
                    tempRoungInfo /= 10;
                    digits++;
                }
                if (digits % 2 == 0)
                {
                    for (int j = 0; j < digits / 2; j++)
                    {
                        v += (roundInfo % 10);
                        roundInfo /= 10;
                    }
                    for (int j = 0; j < digits / 2; j++)
                    {
                        m += (roundInfo % 10);
                        roundInfo /= 10;
                    }
                }
                else
                {
                    for (int j = 0; j < digits / 2; j++)
                    {
                        v += (roundInfo % 10);
                        roundInfo /= 10;
                    }
                    int middle = roundInfo % 10;
                    v += middle;
                    m += middle;
                    roundInfo /= 10;
                    for (int j = 0; j < digits / 2; j++)
                    {
                        m += (roundInfo % 10);
                        roundInfo /= 10;
                    }
                }

            }
            if ( m > v)
	        {
                Console.WriteLine("M {0}", m - v);
	        }
            else if ( m < v )
            {
                Console.WriteLine("V {0}", v - m);
            }
            else
            {
                Console.WriteLine("No {0}", m + v);
            }

        }
    }
}
