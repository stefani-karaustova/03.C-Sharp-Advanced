using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var countValues = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!countValues.ContainsKey(numbers[i]))
                {
                    countValues.Add(numbers[i], 0);
                }

                countValues[numbers[i]]++;
            }

            foreach (var item in countValues)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
