using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var uniqueElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();

                for (int j = 0; j < line.Length; j++)
                {
                    uniqueElements.Add(line[j]);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
