using System;


namespace _09.Trapezoid
{
    class Trapez
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());
            decimal area;



            if (a > -500 && a < 500 && b > -500 && b < 500 && h > -500 && h < 500)
            {
                area = h * (a + b) / 2;
                Console.WriteLine("{0:F7}", area);
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
