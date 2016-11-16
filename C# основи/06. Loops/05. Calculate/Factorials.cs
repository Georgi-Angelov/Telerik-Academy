using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate
{
    class Factorials
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1;
            double fact = 1;
            
            for (int i = 1; i <= n; i++)
            {
                
                fact *= i;
                
                sum += fact / (Math.Pow(x,i));
            }
            
            
            Console.WriteLine("{0:F5}",sum);
            
        }
    }
}
