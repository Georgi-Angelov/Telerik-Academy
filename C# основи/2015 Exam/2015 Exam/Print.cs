using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_Exam
{
    class Print
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double totalSheets = (double)(n * s);
            double ream = (double)(totalSheets / 500.0);
            Console.WriteLine("{0:F2}" , ream*p);
        }
    }
}
