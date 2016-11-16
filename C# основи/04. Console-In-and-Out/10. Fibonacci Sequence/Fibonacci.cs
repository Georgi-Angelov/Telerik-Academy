using System;


namespace _09.Sum_of_N_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            long a = 0;
            long b = 1;
            long temp = 0;
            if (n >= 1 && n <= 50)
            {

                if (n == 1)
                {
                    Console.WriteLine(a);
                }
                else if (n == 2)
                {
                    Console.WriteLine("{0}, {1}", a, b);
                }
                else if (n > 2)
                {
                    Console.Write("{0}, {1}, ", a, b);
                    for (int i = 1; i <= n - 2; i++)
                    {
                        temp = a + b;
                        a = b;
                        b = temp;
                        if (n - 2 == i)
                        {
                            Console.Write(temp);
                        }
                        else
                        {
                            Console.Write(temp + ", ");
                        }
                    }
                }
            }
        }
    }
}
