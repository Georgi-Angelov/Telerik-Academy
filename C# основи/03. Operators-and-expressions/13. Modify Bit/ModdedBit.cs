using System;

namespace _13.Modify_Bit
{
    class ModdedBit
    {
        static void Main(string[] args)
        {
            ulong Number = ulong.Parse(Console.ReadLine());
            int Position = int.Parse(Console.ReadLine());
            int Value = int.Parse(Console.ReadLine());
            ulong newNumber = 0;
            if (Value == 0)
            {
                newNumber = Number & (ulong)(~(1 << Position)) ;
                Console.WriteLine(newNumber);
            }
            else
            {
                newNumber =   Number | (ulong)(1 << Position);
                Console.WriteLine(newNumber);
            }
        }
    }
}
