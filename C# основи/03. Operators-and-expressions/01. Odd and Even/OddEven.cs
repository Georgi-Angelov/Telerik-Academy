using System;

namespace _01.Odd_and_Even
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int value;
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Input was not an integer.");
                return;
            }

            if ( value % 2 == 0  ) 
            {
                Console.WriteLine("even" + " " + value);
            }
            else
            {
                Console.WriteLine("odd" + " " + value);
            }
            
        }
    }
}
