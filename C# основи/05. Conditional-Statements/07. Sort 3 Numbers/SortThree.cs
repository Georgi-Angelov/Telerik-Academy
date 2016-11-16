using System;

namespace _07.Sort_3_Numbers
{
    class SortThree
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ( a > b && a > c)
            {
                if ( b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else if ( c > b)
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else if (c > a)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }


            }
            else if (c > b && c > a)
            {
                if (a > b)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else if (b > a)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }

            }
            else
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
        }
    }
}
