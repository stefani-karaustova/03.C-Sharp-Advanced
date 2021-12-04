using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            var firstSetLenght = input[0];
            var secondSetLenght = input[1];

            var firstSetElements = new HashSet<int>();
            var secondSetElements = new HashSet<int>();

            for (int i = 0; i < firstSetLenght; i++)
            {
                firstSetElements.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < secondSetLenght; i++)
            {
                secondSetElements.Add(int.Parse(Console.ReadLine()));
            }

            firstSetElements.IntersectWith(secondSetElements);

            Console.WriteLine(string.Join(" ", firstSetElements));
        }
    }
}
