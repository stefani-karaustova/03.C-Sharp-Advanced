using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var information = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                var continent = line[0];
                var country = line[1];
                var city = line[2];

                if (!information.ContainsKey(continent))
                {
                    information.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!information[continent].ContainsKey(country))
                {
                    information[continent].Add(country, new List<string>());
                }

                information[continent][country].Add(city);
            }

            foreach (var continent in information)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var county in continent.Value)
                {
                    Console.Write($"{county.Key} -> ");

                    for (int i = 0; i < county.Value.Count; i++)
                    {
                        if (i != 0)
                        {
                            Console.Write(", ");
                        }

                        Console.Write($"{county.Value[i]}");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
