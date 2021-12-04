using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", numbers
                .Where(x => x % n != 0)));
        }
    }
}
