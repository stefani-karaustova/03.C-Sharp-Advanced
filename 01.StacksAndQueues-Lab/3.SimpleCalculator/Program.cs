using System;
using System.Collections.Generic;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var stack = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 1)
            {
                var left = int.Parse(stack.Pop());
                var sign = stack.Pop();
                var right = int.Parse(stack.Pop());

                switch (sign)
                {
                    case "+":
                        stack.Push((left + right).ToString());
                        break;
                    case "-":
                        stack.Push((left - right).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
