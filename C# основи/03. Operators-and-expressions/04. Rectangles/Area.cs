using System;

namespace _04.Rectangles
{
    class Area
    {
        static void Main()
        {
            
            double intWidth = double.Parse(Console.ReadLine());

            double intHeight = double.Parse(Console.ReadLine());
            double area = intWidth * intHeight;
            double perimether = (intWidth + intHeight) * 2;
            Console.WriteLine("{0} {1}" ,area.ToString("F2"), perimether.ToString("F2"));
            
        }
    }
}
