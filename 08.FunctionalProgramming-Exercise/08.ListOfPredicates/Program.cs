using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = int.Parse(Console.ReadLine());

            var dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var numbers = new List<int>();

            for (int i = 1; i <= range; i++)
            {
                numbers.Add(i);
            }

            foreach (var item in dividers)
            {
                Func<int, bool> filter = x => x % item == 0;

                numbers = numbers.Where(filter).ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
