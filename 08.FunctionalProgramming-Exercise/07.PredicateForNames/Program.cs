using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());

            Func<string, bool> filter = x => x.Length <= length;

            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(filter)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
