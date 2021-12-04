using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            var occurrences = new SortedDictionary<char, int>();

            foreach (var item in input)
            {
                if (!occurrences.ContainsKey(item))
                {
                    occurrences.Add(item, 0);
                }

                occurrences[item]++;
            }

            foreach (var pair in occurrences)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
