﻿using System;
using System.Linq;

namespace Squares_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];

                }
            }
            int counter = 0;
          
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (
                                matrix[row, col] == matrix[row + 1, col] &&
                                   matrix[row, col] == matrix[row, col + 1] &&
                                 matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                   
                }

            }
            Console.WriteLine(counter);
        }
    }
}
