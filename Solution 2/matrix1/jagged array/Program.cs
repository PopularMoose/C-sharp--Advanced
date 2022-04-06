using System;
using System.Linq;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];


            for (int row = 0; row < n; row++)
            {
                var line = Console.ReadLine();
                var lineParts = line.Split(" ");
                arr[row] = new int[lineParts.Length];

                for (int col = 0; col < lineParts.Length; col++)
                {
                   arr[row][col] = int.Parse(lineParts[col]);
                }
            }
            while (true)
            {


                var command = Console.ReadLine();
                var commandParts = command.Split(" ");
                var commandName = commandParts[0];

                 if (commandName == "END")
                {
                    break;

                }
                var rows = int.Parse(commandParts[1]);
                var cols = int.Parse(commandParts[2]);
                var value = int.Parse(commandParts[3]);

                if (rows < 0 || rows >= arr.Length ||
                    cols < 0 || cols >= arr[rows].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

              
                 if (commandName == "Add" )
                {
                    arr[rows][cols] += value;
                }
                else if (commandName == "Subtract")
                {
                    arr[rows][cols] -= value;
                }

            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        }
    }
