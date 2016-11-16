using System;

namespace _06.Four_Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
        int digit = int.Parse(Console.ReadLine());
        int a = ((digit / 1000) % 10);
        int b = ((digit / 100) % 10);
        int c = ((digit / 10) % 10);
        int d = digit % 10;

        int sumDigit = a + b + c + d;
        Console.WriteLine(sumDigit);
        Console.WriteLine("{0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
            /*
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            int sum = 0;
            if ( num >= 1000 && num <= 9999 )
            {
                while ( num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                Console.WriteLine(sum);
                
                
                while (num != 0)
                {
                    int rem = num % 10;
                    result = (result * 10) + rem;
                    num = num / 10;
                }
                Console.WriteLine(result);
                    
                
            
            }
            else
            {
                Console.WriteLine("false");
            }
           */
   


