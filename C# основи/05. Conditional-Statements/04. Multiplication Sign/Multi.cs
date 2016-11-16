using System;

namespace _04.Multiplication_Sign
{
    class Multi
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double multi = x * y * z;
            if ( multi > 0 )
            {
                Console.WriteLine("+");
            }
            else if (multi < 0 )
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
