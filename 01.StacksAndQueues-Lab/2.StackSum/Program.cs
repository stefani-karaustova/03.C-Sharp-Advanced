using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            var stack = new Stack<int>(input);

            var command = Console.ReadLine();

            while (command != "end")
            {
                if (command.Contains("add"))
                {
                    var split = command.Split();
                    stack.Push(int.Parse(split[1]));
                    stack.Push(int.Parse(split[2]));
                }

                if (command.Contains("remove"))
                {
                    var split = command.Split();
                    var count = int.Parse(split[1]);

                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
