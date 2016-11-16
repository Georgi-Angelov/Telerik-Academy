using System;

class MaxEqualElementsSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int maxCount = 0;
        int currentCount = 1;
        int sequenceStart = 0;
        int counter = 0;
        for (int i = 0; i < n; i++)
        {

            arr[i] = int.Parse(Console.ReadLine());
            if (i != 0)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    sequenceStart = i + 1 - maxCount;
                }
            }
        }


        for (int i = sequenceStart; i < sequenceStart + maxCount; i++)
        {
            counter++;
        }
        Console.Write(counter);
    }
}