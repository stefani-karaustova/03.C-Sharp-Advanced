using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(input);
            var count = 0;

            while (queue.Count > 1)
            {
                count++;
                var kid = queue.Dequeue();

                if (count == n)
                {
                    count = 0;
                    Console.WriteLine($"Removed {kid}");
                }
                else
                {
                    queue.Enqueue(kid);
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
