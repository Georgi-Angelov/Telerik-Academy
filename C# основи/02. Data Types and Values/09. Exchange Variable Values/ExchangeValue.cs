using System;

namespace _09.Exchange_Variable_Values
{
    class ExchangeValue
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = a; 
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
                        
        }
    }
}
