using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            var command = Console.ReadLine();

            while (command != "END")
            {
                var line = command.Split();
                var row = int.Parse(line[1]);
                var col = int.Parse(line[2]);
                var value = int.Parse(line[3]);

                if (row >= 0 && col >= 0 && row < n && col < n)
                {
                    if (line[0] == "Add")
                    {
                        matrix[row, col] += value;
                    }
                    if (line[0] == "Subtract")
                    {
                        matrix[row, col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
