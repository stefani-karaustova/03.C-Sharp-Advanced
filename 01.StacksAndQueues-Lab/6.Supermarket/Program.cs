using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = Console.ReadLine();
            var queue = new Queue<string>();

            while (customer != "End")
            {
                if (customer == "Paid")
                {
                    while (queue.Any())
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(customer);
                }

                customer = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
