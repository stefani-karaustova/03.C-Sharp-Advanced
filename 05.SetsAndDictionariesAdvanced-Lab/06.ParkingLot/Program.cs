using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var parking = new HashSet<string>();

            while (input != "END")
            {
                string[] line = input.Split(", ");
                var direction = line[0];
                var carNumber = line[1];

                if (direction == "IN")
                {
                    parking.Add(carNumber);
                }
                else
                {
                    if (parking.Contains(carNumber))
                    {
                        parking.Remove(carNumber);
                    }
                }

                input = Console.ReadLine();
            }

            if (parking.Count > 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
