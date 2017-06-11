using System;

namespace _05.Triangle_surface_by_three_sides
{
    class SurfaceByAllSides
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2; // half of perimether of triangle
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("{0:F2}", area);
        }
    }
}
