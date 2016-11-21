using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class InSearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int counter = 0;
            string[] vafla = Console.ReadLine().Split();
            
            string searchedNumber = Console.ReadLine();
            SearchingForAtlantis(vafla, searchedNumber, counter );
        }
        static void SearchingForAtlantis(string[] vafla, string searchedNumber,int counter)
        {
            for (int i = 0; i < vafla.Length; i++)
            {
                if (searchedNumber == vafla[i])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }


    }
}
