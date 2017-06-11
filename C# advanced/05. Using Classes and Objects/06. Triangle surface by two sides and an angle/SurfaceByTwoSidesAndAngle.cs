using System;

namespace _06.Triangle_surface_by_two_sides_and_an_angle
{
    class SurfaceByTwoSidesAndAngle
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            double area = (a * b * Math.Sin(angle / 180 * Math.PI) / 2);
            Console.WriteLine("{0:F2}", area);
        }
    }
}
