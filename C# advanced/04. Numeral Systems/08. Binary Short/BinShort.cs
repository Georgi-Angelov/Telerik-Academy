using System;

namespace _08.Short_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            short value = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(value, 2).PadLeft(16, '0'));
        }
    }
}
