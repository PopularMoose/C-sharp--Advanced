using System;
using System.Collections.Generic;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<char> print = new Stack<char>();

            foreach (var ch in input)
            {
                print.Push(ch);
            }

            while (print.Count != 0)
            {
                Console.Write(print.Pop());
            }
            Console.WriteLine();
        }
    }
}
