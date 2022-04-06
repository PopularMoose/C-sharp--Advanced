using System;
using System.Linq;

namespace matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int a = int.Parse(array[0]);
            int b = int.Parse(array[1]);
            int c = int.Parse(array[2]);
            sum = a + b + c;
            if (sum % 2 ==0)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("even");
            }

        }
    }
}
