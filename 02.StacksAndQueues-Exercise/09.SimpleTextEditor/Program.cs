using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfOperations = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();

            var text = string.Empty;

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] input = Console.ReadLine().Split();
                var command = input[0];

                if (command == "1")
                {
                    var someString = input[1];
                    text += someString;
                    stack.Push(text);
                }
                else if (command == "2")
                {
                    var count = int.Parse(input[1]);
                    text = text.Substring(0, text.Length - count);
                    stack.Push(text);
                }
                else if (command == "3")
                {
                    var index = int.Parse(input[1]);
                    var currentChar = text[index - 1];

                    Console.WriteLine(currentChar);
                }
                else
                {
                    stack.Pop();

                    if (stack.Any())
                    {
                        text = stack.Peek();
                    }
                    else
                    {
                        text = string.Empty;
                    }
                }
            }
        }
    }
}
