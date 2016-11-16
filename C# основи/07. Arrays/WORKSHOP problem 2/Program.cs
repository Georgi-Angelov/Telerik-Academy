using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORKSHOP_problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int groups = 0;
            int groupSpeed = int.MaxValue;
            for (int i = 0; i < count; i++)
            {
                int busSpeed = int.Parse(Console.ReadLine());

                if (busSpeed <= groupSpeed)
                {
                    groups++;
                    groupSpeed = busSpeed;
                }

            }

            Console.WriteLine(groups);
        }
    }
}
