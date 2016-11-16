using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int counter = 1;
        int result = 1;

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i + 1] - array[i] >= 1 )
            {
                counter++;
                if (counter > result)
                {
                    result = counter;
                }
            }
            else
            {
                counter = 1;
            }
        }
        Console.WriteLine(result);
    }
}