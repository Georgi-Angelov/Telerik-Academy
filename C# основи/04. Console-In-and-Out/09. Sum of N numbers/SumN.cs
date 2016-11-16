using System;


namespace _09.Sum_of_N_numbers
{
    class SumN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());

                sum += numbers;
                Console.WriteLine(sum);
            }
        }
    }
}
