using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            var boxCapacity = int.Parse(Console.ReadLine());

            var rackCapacity = boxCapacity;
            var racksCount = 1;

            var clothesOnRacks = new Stack<int>(clothes);

            while (clothesOnRacks.Any())
            {
                var currentPieceOfClothing = clothesOnRacks.Pop();
                rackCapacity -= currentPieceOfClothing;

                if (rackCapacity < 0)
                {
                    racksCount++;
                    rackCapacity = boxCapacity - currentPieceOfClothing;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
