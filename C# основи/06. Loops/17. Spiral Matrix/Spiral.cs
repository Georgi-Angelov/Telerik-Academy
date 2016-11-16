using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Spiral_Matrix
{
    class Spiral
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint[,] mx = new uint[100,100];
            char direction = 'r';
            uint row = 0;
            uint column = 0;

            for (uint i = 0; i < n * n; i++)
            {
                mx[row, column] = i + 1;
                switch (direction)
                {
                    case 'r':
                        if (column >= n - 1 || mx[row, column + 1] != 0) direction = 'd';
                        break;
                    case 'd':
                        if (row >= n - 1 || mx[row + 1, column] != 0) direction = 'l';
                        break;
                    case 'l':
                        if (column <= 0 || mx[row, column - 1] != 0) direction = 'u';
                        break;
                    case 'u':
                        if (row <= 0 || mx[row - 1, column] != 0) direction = 'r';
                        break;
                }
                switch (direction)
                {
                    case 'r':
                        column++;
                        break;
                    case 'd':
                        row++;
                        break;
                    case 'l':
                        column--;
                        break;
                    case 'u':
                        row--;
                        break;
                }
            }

            for (uint i = 0; i < n; i++)
            {
                for (uint j = 0; j < n; j++)
                {
                    Console.Write("{0} ", mx[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}