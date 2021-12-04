using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                var box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(box);
            }

            var element = double.Parse(Console.ReadLine());
            var comparableBox = new Box<double>(element);

            var count = CountOfElements(boxes, comparableBox);
            Console.WriteLine(count);
        }

        private static double CountOfElements<T>(List<Box<T>> boxes, Box<T> box)
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
