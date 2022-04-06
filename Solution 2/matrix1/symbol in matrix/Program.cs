using System;
using System.Linq;

namespace symbol_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            long maxSum = long.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    var SquareSum = matrix[row, col] +
                                    matrix[row + 1, col] +
                                    matrix[row, col + 1] +
                                    matrix[row + 1, col + 1];
                    if (SquareSum > maxSum)
                    {
                        maxSum= SquareSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                   
                }
            }
             for (int row = maxSumRow; row < maxSumRow+2; row++)
            {
                for (int col = maxSumCol; col < maxSumCol+2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
           

        }
    }
}
