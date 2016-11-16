using System;

namespace _12.N_th_bit
{
    class Nth
    {
        static void Main(string[] args)
        {
            long pos = long.Parse(Console.ReadLine());
            byte num = byte.Parse(Console.ReadLine());
            if ( num < 55 && pos >= 0 && pos <= Math.Pow(2,55))
            {
                long mask = 1 << num;
                long posAndMask = pos & mask;
                long output = posAndMask >> num;
                Console.WriteLine(output);
            }
        }
    }
}
