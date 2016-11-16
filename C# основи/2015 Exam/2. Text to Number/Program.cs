using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Text_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            long result = 0;

            for (int i = 0; i < input.Length; i++)
			{
                char ch = input[i];
                if (ch == '@')
                {
                    break;
                }
                else if ( '0' <= ch && ch <= '9')
                {
                    result *= (ch - '0');
                }
                else if ( 'a' <= ch && ch <= 'z')
                {
                    result += (ch - 'a');
                }
                else if ('A' <= ch && ch <= 'Z')
                {
                    result += (ch - 'A');
                }
                else
                {
                    result %= m;
                }
			}
            Console.WriteLine(result);
            
        }
    }
}
