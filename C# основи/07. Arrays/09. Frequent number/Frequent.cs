using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Frequent_number
{
    class Frequent
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int tempCounter = 1;
            int maxCounter = 1;
            int mostFrequentNumber = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(array);

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    tempCounter++;
                }
                else
                {
                    if (tempCounter > maxCounter)
                    {
                        maxCounter = tempCounter;
                        mostFrequentNumber = array[i];
                        tempCounter = 1;
                    }
                    else
                    {
                        tempCounter = 1;
                    }
                }
            }
            if (tempCounter > maxCounter)
            {
                maxCounter = tempCounter;
                mostFrequentNumber = array[array.Length- 1];
            }

            Console.WriteLine("{0} ({1} times)", mostFrequentNumber, maxCounter);
			
        }
    }
}
