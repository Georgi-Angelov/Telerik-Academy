using System;

namespace _08.Numbers_from_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < x; i++)
            {
                Console.WriteLine(i);
                
            }
        }
    }
}
