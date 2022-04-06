using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersAsString = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            string[] numberList = numbersAsString.Split(' ');

            foreach (var item in numberList)
            {
                stack.Push(int.Parse(item));
            }
            while (true)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(' ');
                string command = lineParts[0].ToLower();
                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    stack.Push(int.Parse(lineParts[1]));
                    stack.Push(int.Parse(lineParts[2]));
                }
                else if (command == "remove")
                {
                    var numbersOfElements = int.Parse(lineParts[1]);
                    if (numbersOfElements <= stack.Count)
                    {
                        for (int i = 0; i < numbersOfElements; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            int sum = 0;
            while (stack.Count > 0)
            {
                int number = stack.Pop();
                sum += number;

            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
