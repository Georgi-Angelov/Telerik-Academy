using System;

namespace _10.Point__Circle__Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double radius = 1.5;
            int cx = 1;
            int cy = 1;
            /// the rectangle corners with offset are: (-1, 1; 1, 5; -1, -1; -1, 5) x axis is ( -1, 5) y axis ( -1, 1 ) 

            if ( x >= -1000 && x <= 1000 && y >= -1000 && y <= 1000)
            {
                bool inCircle = (x - cx) * (x - cx) + (y - cy) * (y - cy) <= radius * radius; // x^2 + y^2 = r^2 Formula for every point in a circle with offset correction
                bool isRectangle = x >= -1 && x <= 5 && y >= -1 && y <= 1; // -1 <= x <= 5 ; -1 <= y <= 1 this is the rectangle with the offset 
                if (inCircle == true )
                {
                    if (isRectangle == true)
                    {
                        Console.WriteLine("inside circle inside rectangle");
                    }
                    else
                    {
                        Console.WriteLine("inside circle outside rectangle");
                    }
                }
                else
                {
                    if (isRectangle == true)
                    {
                        Console.WriteLine("outside circle inside rectangle");
                    }
                    else
                    {
                        Console.WriteLine("outside circle outside rectangle");
                    }
                }
                    
            }
            else
	            {
                    Console.WriteLine("NEIN!");
	            }
        }
    }
}
