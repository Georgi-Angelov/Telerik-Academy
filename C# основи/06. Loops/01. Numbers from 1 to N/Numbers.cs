using System;

namespace _01.Numbers_from_1_to_N
{
    class Numbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;                 
            while (number < n )
            {
                number++;
                Console.Write("{0} ", number);
            }
 
        }
    }
}
