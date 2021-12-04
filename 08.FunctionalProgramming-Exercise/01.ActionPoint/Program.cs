using System;
using System.Linq;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string> print = x => Console.WriteLine(x);

            input.ToList().ForEach(x => print(x));
        }
    }
}
