using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            var pumps = int.Parse(Console.ReadLine());
            var pumpsData = new Queue<string>();

            for (int i = 0; i < pumps; i++)
            {
                pumpsData.Enqueue(Console.ReadLine());
            }

            for (int i = 0; i < pumps; i++)
            {
                var currentAmaunt = 0;
                bool isSuccessfull = true;

                for (int j = 0; j < pumps; j++)
                {
                    var dataString = pumpsData.Dequeue();

                    int[] data = dataString.Split()
                        .Select(int.Parse)
                        .ToArray();

                    pumpsData.Enqueue(dataString);

                    currentAmaunt += data[0];
                    currentAmaunt -= data[1];

                    if (currentAmaunt < 0)
                    {
                        isSuccessfull = false;
                    }
                }

                if (isSuccessfull)
                {
                    Console.WriteLine(i);
                    break;
                }

                var temp = pumpsData.Dequeue();
                pumpsData.Enqueue(temp);
            }
        }
    }
}
