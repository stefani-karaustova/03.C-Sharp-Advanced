using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];

                if (number % 2 == 0)
                {
                    queue.Enqueue(number);
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
