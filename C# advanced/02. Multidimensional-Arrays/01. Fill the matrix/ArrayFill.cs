using System;
class FillTheMatrix
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char pattern = char.Parse(Console.ReadLine());
        int rows = 0;
        int columns = 0;
        char direction = 'd';
        int counter = 1;
        int[,] matrix = new int[size, size];
        int currentNumber = 1;
        if (Char.ToUpper(pattern).Equals('A'))
        {
            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;
                }
            }
        }
        else if (Char.ToUpper(pattern).Equals('B'))
        {
            for (int col = 0; col < size; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < size; row++)
                    {
                        matrix[row, col] = currentNumber;
                        currentNumber++;
                    }
                }
                else
                {
                    for (int row = size - 1; row >= 0; row--)
                    {
                        matrix[row, col] = currentNumber;
                        currentNumber++;
                    }
                }
            }
        }
        else if (Char.ToUpper(pattern).Equals('C'))
        {
            DiagonalMatrix(matrix, size, counter);
        }
        else if (Char.ToUpper(pattern).Equals('D'))
        {
            for (int i = 0; i < size * size; i++)
            {
                matrix[rows, columns] = i + 1;
                switch (direction)
                {
                    case 'd':
                        if (rows >= size - 1 || matrix[rows + 1, columns] != 0) direction = 'r'; 
                        break;
                    case 'r':
                        if (columns >= size - 1 || matrix[rows, columns + 1] != 0) direction = 'u';
                        break;
                    case 'u':
                        if (rows <= 0 || matrix[rows - 1, columns] != 0) direction = 'l';
                        break;
                    case 'l':
                        if (columns <= 0 || matrix[rows, columns - 1] != 0) direction = 'd';
                        break;
                }
                switch (direction)
	            {
		            case 'd':
                        rows++;
                        break;
                    case 'r':
                        columns++;
                        break;
                    case 'u':
                        rows--;
                        break;
                    case 'l':
                        columns--;
                        break;
	            }
            }
        }

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (col == (size - 1)) //last element without spacing 
                {
                    Console.Write(matrix[row, col]);
                }
                else //any other element, separated with spacing
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }
            Console.WriteLine(); 
        }
    }
    static void DiagonalMatrix(int[,] matrix, int matrixSize, int counter)
    {
        //first half of diagonal matrix
        for (int reversedRow = matrixSize - 1; reversedRow >= 0; reversedRow--)
        {
            for (int col = 0; col < (matrixSize - reversedRow); col++, counter++)
            {
                if (col == 0)
                {
                    matrix[reversedRow, col] = counter;
                }
                else
                {
                    matrix[(reversedRow + col), col] = counter;
                }
            }
        }
        //second half of diagonal matrix
        for (int col = 1; col <= matrixSize - 1; col++)
        {
            for (int row = 0; row < (matrixSize - col); row++, counter++)
            {
                if (row == 0)
                {
                    matrix[row, col] = counter;
                }
                else
                {
                    matrix[row, (col + row)] = counter;
                }
            }
        }
    }
}