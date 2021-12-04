using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            Dictionary<int, int> evenTimes = numbers.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(evenTimes.First().Key);
        }
    }
}
