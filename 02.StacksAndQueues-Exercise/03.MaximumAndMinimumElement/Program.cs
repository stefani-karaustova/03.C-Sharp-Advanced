using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfQueries = int.Parse(Console.ReadLine());

            var numbers = new Stack<string>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                string[] querie = Console.ReadLine().Split();
                var command = querie[0];

                if (command == "1")
                {
                    var element = querie[1];
                    numbers.Push(element);
                }
                if (command == "2" && numbers.Any())
                {
                    numbers.Pop();
                }
                if (command == "3" && numbers.Any())
                {
                    Console.WriteLine(numbers.Max());
                }
                if (command == "4" && numbers.Any())
                {
                    Console.WriteLine(numbers.Min());
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
