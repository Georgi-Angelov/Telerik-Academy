using System;

namespace _04.Formatting_Numbers
{
    class FormatNum
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            string hexA = a.ToString("X");
            string binaryA = Convert.ToString(a, 2).ToString();

            if ( a >= 0 && a <= 500 )
            {
                Console.WriteLine(String.Format("{0,-10} |{1:00000000}| {2:0.00,10} |{3:0.000,5} |", hexA, binaryA, b, c));
            }
        }
    }
}
