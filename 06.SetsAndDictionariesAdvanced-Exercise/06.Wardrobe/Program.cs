using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                var color = line[0];
                string[] clothes = line.Skip(1).ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                Dictionary<string, int> currentClothing = wardrobe[color];

                foreach (var item in clothes)
                {
                    if (!currentClothing.ContainsKey(item))
                    {
                        currentClothing.Add(item, 0);
                    }

                    currentClothing[item]++;
                }
            }

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach ((var color, Dictionary<string, int> data) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach ((var clothing, var count) in data)
                {
                    if (input[0] == color && input[1] == clothing)
                    {
                        Console.WriteLine($"* {clothing} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing} - {count}");
                    }
                }
            }
        }
    }
}
