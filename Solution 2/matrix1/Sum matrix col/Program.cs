using System;
using System.Linq;

namespace Sum_matrix_col
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0;  col < matrix.GetLength(1);  col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
 
           

            for (int row = 0; row < matrix.GetLength(1); row++)
            { 
               int sum = 0;
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    sum += matrix[col, row];
                }
                Console.WriteLine(sum);
            }

           
        }
    }
}
