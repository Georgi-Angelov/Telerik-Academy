using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class NumberReverse
    {
        static void Main(string[] args)
        {
            string normalNumber = (Console.ReadLine());
            Console.WriteLine(ReverseString(normalNumber));
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
