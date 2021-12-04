using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var n = input[0];
            var s = input[1];
            var x = input[2];

            var numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Push(inputNumbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
            }

            bool isFound = numbers.Contains(x);

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else if (!numbers.Any())
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
