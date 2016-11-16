using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.String_and_Objects
{
    class StingAndObj
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            string helloWorld = hello + "" + world;
            object helloWorldString = helloWorld.ToString();
            Console.WriteLine(helloWorldString);
        }
    }
}
