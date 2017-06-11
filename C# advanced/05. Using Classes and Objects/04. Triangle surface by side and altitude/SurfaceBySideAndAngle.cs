using System;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class SurfaceBySideAndAngle
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", (side * height) / 2);
        }
    }
}
