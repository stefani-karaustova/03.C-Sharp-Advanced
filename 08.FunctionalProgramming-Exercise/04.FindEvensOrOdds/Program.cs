using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var start = range[0];
            var end = range[1];

            var numbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            var command = Console.ReadLine();

            Func<int, bool> filter = Filter(command);

            var result = numbers.Where(filter).ToList();

            Console.WriteLine(string.Join(" ", result));
        }

        private static Func<int, bool> Filter(string command)
        {
            if (command == "odd")
            {
                return x => x % 2 != 0;
            }
            else if (command == "even")
            {
                return x => x % 2 == 0;
            }
            else
            {
                return x => true;
            }
        }
    }
}
