using System;
using System.Linq;

namespace _11.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Console.WriteLine(names
                .FirstOrDefault(x => x.ToCharArray()
                .Select(y => (int)y)
                .Sum() >= n));
        }
    }
}
