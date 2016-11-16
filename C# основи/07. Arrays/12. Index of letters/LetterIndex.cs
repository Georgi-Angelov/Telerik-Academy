using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Index_of_letters
{
    class LetterIndex
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string input = Console.ReadLine();
            foreach (char letter in input)
            {
                Console.WriteLine(alphabet.IndexOf(letter));
            }
            
            
        }
    }
}
