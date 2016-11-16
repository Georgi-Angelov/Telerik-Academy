using System;
using System.Linq;
class Program
{
    static void Main()
    {
        char[] firstCharArray = Console.ReadLine().ToCharArray();
        char[] secondCharArray = Console.ReadLine().ToCharArray();

        int biggerArray;

        if (firstCharArray.Length <= secondCharArray.Length)
        {
            biggerArray = secondCharArray.Length;
        }
        else
        {
            biggerArray = firstCharArray.Length;
        }

        for (int i = 0; i < biggerArray; i++)
        {
            if (firstCharArray[i] < secondCharArray[i])
            {
                Console.WriteLine("<");
                break;
            }
            else if (firstCharArray[i] > secondCharArray[i])
            {
                Console.WriteLine(">");
                break;
            }
            else if (firstCharArray.SequenceEqual(secondCharArray))
            {
                Console.WriteLine("=");
                break;
            }
            else if (secondCharArray.SequenceEqual(firstCharArray))
            {
                Console.WriteLine("=");
                break;
            }
        }
    }
}