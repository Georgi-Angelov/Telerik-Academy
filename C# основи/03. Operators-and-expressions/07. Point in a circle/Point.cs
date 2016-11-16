using System;


class Point
{
  
    static void Main()
    {
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        float radius = 2;

        if (x >= -1000 && x <= 1000 && y >= -1000 && y <= 1000)
        {
            bool inCircle = (x - 0) * (x - 0) + (y - 0) * (y - 0) <= radius * radius;
            float distance = (float)Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0));

            if (inCircle == true)
            {
                Console.WriteLine("yes {0:0.00}", distance);
            }
            else
                Console.WriteLine("no {0:0.00}", distance);
        }
    }
}