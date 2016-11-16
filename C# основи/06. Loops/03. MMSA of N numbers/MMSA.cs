using System;

namespace _03.MMSA_of_N_numbers
{
    class MMSA
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            double[] doubleNumbers = new double[num];
            for (int i = 0; i < doubleNumbers.Length; i++)
            {
                doubleNumbers[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("min={0,0:F2}", doubleNumbers.Min());
            Console.WriteLine("max={0,0:F2}", doubleNumbers.Max());
            Console.WriteLine("sum={0,0:F2}", doubleNumbers.Sum());
            Console.WriteLine("avg={0,0:F2}", doubleNumbers.Average());      
        }
    }
}
