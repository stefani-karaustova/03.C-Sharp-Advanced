using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                var box = new Box<string>(Console.ReadLine());
                boxes.Add(box);
            }

            var element = Console.ReadLine();
            var comparableBox = new Box<string>(element);

            var count = CountOfElements(boxes, comparableBox);
            Console.WriteLine(count);
        }

        private static int CountOfElements<T>(List<Box<T>> boxes, Box<T> box)
            where T : IComparable
        {
            var count = 0;

            foreach (var item in boxes)
            {
                if (item.Value.CompareTo(box.Value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
