using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem_2
{
    class NaKupon
    {
        static void Main(string[] args)
        {
            string directions = Console.ReadLine();
            int counter = 0;
            int currentValue = 0;

            for (int i = 0; i < directions.Length; i++)
            {
                char ch = directions[counter];
                if (ch == '^')
                {
                    break;
                }
                else if ('a' <= ch && ch <= 'z')
                {
                    currentValue += (ch - 'a' + 1);
                }
                else if ('A' <= ch && ch <= 'Z')
                {
                    currentValue -= (ch - 'A' + 1);
                }
                counter += currentValue;
                
                if (counter < 0 || counter > directions.Length )
                {
                    Console.WriteLine("Djor and Djano are lost at {0}!", counter);
                    break;
                }
                
                currentValue = 0;
            } 
            if (counter >= 0 && counter <= directions.Length)
            {
            Console.WriteLine("Djor and Djano are at the party at {0}!", counter);
                
            }
        }
    }
}
