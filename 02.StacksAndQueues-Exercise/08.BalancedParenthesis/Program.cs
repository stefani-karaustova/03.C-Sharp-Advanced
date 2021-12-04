using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            foreach (var item in input)
            {
                if (stack.Any())
                {
                    var symbol = stack.Peek();

                    if (symbol == '{' && item == '}')
                    {
                        stack.Pop();
                        continue;
                    }

                    else if (symbol == '[' && item == ']')
                    {
                        stack.Pop();
                        continue;
                    }

                    else if (symbol == '(' && item == ')')
                    {
                        stack.Pop();
                        continue;
                    }
                }

                stack.Push(item);
            }

            if (!stack.Any())
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
