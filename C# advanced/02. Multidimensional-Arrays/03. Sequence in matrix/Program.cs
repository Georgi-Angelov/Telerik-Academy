using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sequence_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int a = int.Parse(tokens[0]); // parse first number
            int b = int.Parse(tokens[1]); // parse second number
            int currentCount = 0;
            int maxCount = 0;
            int[,] matrix = new int[a, b]; // allocate array
            for (int row = 0; row < a; row++)
            {
                var values = (Console.ReadLine().Split(' ')); // input row and split numbers
                for (int column = 0; column < b; column++)
                {
                    matrix[row, column] = int.Parse(values[column]); // parse numbers for column
                }
            }
            for (int row = 0; row < a; row++)
            {
                for (int col = 0; col < b; col++)
                {
                   
                }
            }
            
            Console.WriteLine(maxCount);
            
        }
    }
}
