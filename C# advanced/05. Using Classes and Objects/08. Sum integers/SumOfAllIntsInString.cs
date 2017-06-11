using System;

namespace _08.Sum_Integers
{
    class SumOfAllIntsInStringusing
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int sum = 0;
            foreach (string number in numbers)
            {
                int tempNumber = int.Parse(number);
                sum += tempNumber;

            }
            Console.WriteLine(sum);
        }
    }
}
