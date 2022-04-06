using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] triangle = new int[n][];

            for (int i = 0; i < n; i++)
            {
                triangle[i] = new int[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                triangle[i][0] = 1;
                triangle[i][triangle[i].Length - 1] = 1;
                for (int j = 1; j < triangle[i].Length - 1 ; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];

                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", (triangle[i])));
            }
        }
    }
}
