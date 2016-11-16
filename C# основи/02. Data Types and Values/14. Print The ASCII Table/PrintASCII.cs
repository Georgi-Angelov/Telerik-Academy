using System;

namespace _14.Print_The_ASCII_Table
{
    class PrintASCII
    {
        static void Main()
        {
           for (var i = 33; i <= 126; i++)
           {
               char symbol = (char)i;
               Console.WriteLine(symbol);
           }
        }
    }
}
