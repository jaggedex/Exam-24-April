using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MultipliedTargetedCell
{
    static void Main()
    {
        var rowsCols = Console.ReadLine().Split().Select(int.Parse).ToList();
        int rows = rowsCols[0];
        int cols = rowsCols[1];
        long[,] matrix = new long[rows, cols];

        for (int r = 0; r < rows; r++)
        {
            var rowNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int c = 0; c < cols; c++)
            {
                matrix[r, c] = rowNumbers[c];
            }
        }

        var targetCellCoords = Console.ReadLine().Split().Select(int.Parse).ToList();
        long targetRow = targetCellCoords[0];
        long targetCol = targetCellCoords[1];

        long targetCellValue = matrix[targetRow, targetCol];

        long neighboursSum = matrix[targetRow - 1, targetCol - 1] +
                                matrix[targetRow - 1, targetCol] +
                                matrix[targetRow - 1, targetCol + 1] +
                                matrix[targetRow, targetCol - 1] +
                                matrix[targetRow, targetCol + 1] +
                                matrix[targetRow + 1, targetCol - 1] +
                                matrix[targetRow + 1, targetCol] +
                                matrix[targetRow + 1, targetCol + 1];

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (r == targetRow && c == targetCol) 
                {
                    Console.Write("{0} ", matrix[r,c]* neighboursSum);
                }
                else if (r == targetRow - 1 && c == targetCol - 1)
                {
                    Console.Write("{0} ", matrix[r,c]*matrix[targetRow,targetCol]);
                }
                else if (r == targetRow - 1 && c == targetCol)
                {
                    Console.Write("{0} ", matrix[r, c] * matrix[targetRow, targetCol]);
                }
                else if (r == targetRow - 1 && c == targetCol + 1)
                {
                    Console.Write("{0} ", matrix[r, c] * matrix[targetRow, targetCol]);
                }
                else if (r == targetRow  && c == targetCol - 1)
                {
                    Console.Write("{0} ", matrix[r, c] * matrix[targetRow, targetCol]);
                }
                else if (r == targetRow && c == targetCol +1)
                {
                    Console.Write("{0} ", matrix[r, c] * matrix[targetRow, targetCol]);
                }
                else if (r == targetRow + 1 && c == targetCol - 1)
                {
                    Console.Write("{0} ", matrix[r, c] * matrix[targetRow, targetCol]);
                }
                else if (r == targetRow + 1 && c == targetCol )
                {
                    Console.Write("{0} ", matrix[r, c] * matrix[targetRow, targetCol]);
                }
                else if (r == targetRow + 1 && c == targetCol + 1)
                {
                    Console.Write("{0} ", matrix[r, c] * matrix[targetRow, targetCol]);
                }
                else
                {
                    Console.Write("{0} ", matrix[r,c]);
                }
            }
            Console.WriteLine();
        }
    }
}

