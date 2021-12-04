using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsPassed = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            var command = Console.ReadLine();

            var count = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carsPassed; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
