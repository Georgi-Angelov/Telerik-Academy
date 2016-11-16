using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Evening_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int tomatoAmount = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            int cucamberAmount = int.Parse(Console.ReadLine());
            int cucamberArea = int.Parse(Console.ReadLine());
            int potatoAmount = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carrotAmount = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            int cabbageAmount = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beanAmount = int.Parse(Console.ReadLine());
            double sum = tomatoAmount * 0.5 + cucamberAmount * 0.4 + potatoAmount * 0.25 + carrotAmount * 0.6 + cabbageAmount * 0.3 + beanAmount * 0.4;
            Console.WriteLine("Total costs: {0:F2}", sum);
            int totalArea = 250;
            double sumArea = tomatoArea + cucamberArea + potatoArea + carrotArea + cabbageArea;
            if ( totalArea - sumArea > 0)
            {
                Console.WriteLine("Beans area: {0}", totalArea - sumArea);
            }
            else if ( totalArea == sumArea )
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
