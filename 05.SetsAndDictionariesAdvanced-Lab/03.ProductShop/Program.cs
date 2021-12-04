using System;
using System.Collections.Generic;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var information = new SortedDictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                var line = input.Split(", ");
                var shop = line[0];
                var product = line[1];
                var price = double.Parse(line[2]);

                if (!information.ContainsKey(shop))
                {
                    information.Add(shop, new Dictionary<string, double>());
                }

                information[shop].Add(product, price);

                input = Console.ReadLine();
            }

            foreach (var shop in information)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
