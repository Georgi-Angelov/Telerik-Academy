using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 6;
            string result = a != b++ ? a != b ? "yes" : "no" : "maybe";
            Console.WriteLine(result);
        }
    }
}
