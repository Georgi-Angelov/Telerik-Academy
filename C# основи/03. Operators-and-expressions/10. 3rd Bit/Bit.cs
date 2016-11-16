using System;

namespace _11._3rd_Bit
{
    class Bit
    {
        static void Main(string[] args)
        {
            int bit = int.Parse(Console.ReadLine());
            int mask = 1 << 3;    
            int bitAndMask = bit & mask;
            int shifted = bitAndMask >> 3;
            Console.WriteLine(shifted);
        }
    }
}
