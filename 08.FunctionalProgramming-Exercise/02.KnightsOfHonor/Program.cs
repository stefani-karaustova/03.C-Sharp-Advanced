using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string> print = x => Console.WriteLine($"Sir {x}");

            input.ToList().ForEach(x => print(x));
        }
    }
}
