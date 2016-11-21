using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Say_Hello
{
    class Greeting
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
        static void PrintName(string s)
        {
            Console.WriteLine("Hello, {0}!", s);
        }
    }
}
