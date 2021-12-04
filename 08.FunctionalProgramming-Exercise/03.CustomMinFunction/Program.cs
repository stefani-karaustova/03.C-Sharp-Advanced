using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> minNumberFunc = numbers =>
            {
                int minNumber = int.MaxValue;

                foreach (var number in numbers)
                {
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                }

                return minNumber;
            };

            Console.WriteLine(minNumberFunc(input));
        }
    }
}
