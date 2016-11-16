using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maximum_SUm
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(); 

            int a = int.Parse(tokens[0]); // parse first number

            int b = int.Parse(tokens[1]); // parse second number

            int[,] matrix = new int[a, b]; // allocate array
            for (int row = 0; row < a; row++)
            {
                var values = (Console.ReadLine().Split(' ')); // input row and split numbers
                for (int column = 0; column < b; column++)
                {
                    matrix[row, column] = int.Parse(values[column]); // parse numbers for column
                }
            }
            
            int bestSum = int.MinValue; // get best value
            for (int row = 0; row < matrix.GetLength(0) - 2; row++) // target a 3 rows
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++) // target 3 corresponding columns 
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + // row 1
                              matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + // row 2 
                              matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2]; // row 3
                    if (sum > bestSum) // find maximum value and if current value is bigger = new max
                        bestSum = sum;
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}
