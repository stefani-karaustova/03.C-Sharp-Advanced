using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodForTheDay = int.Parse(Console.ReadLine());

            int[] quantityOfOrder = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var orders = new Queue<int>(quantityOfOrder);

            bool thereIsMoreFood = true;

            if (orders.Any())
            {
                Console.WriteLine(orders.Max());
            }

            for (int i = 0; i < quantityOfOrder.Length; i++)
            {
                var currentOrder = quantityOfOrder[i];

                if (currentOrder <= foodForTheDay)
                {
                    orders.Dequeue();
                    foodForTheDay -= currentOrder;
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    thereIsMoreFood = false;
                    break;
                }
            }

            if (thereIsMoreFood)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
