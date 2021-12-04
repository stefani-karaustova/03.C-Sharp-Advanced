using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = input[0];
            var cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] data = Console.ReadLine().Split();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            var command = Console.ReadLine();

            while (command != "END")
            {
                string[] data = command.Split();

                if (data.Length != 5 || data[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                var firstRow = int.Parse(data[1]);
                var firstCol = int.Parse(data[2]);
                var secondRow = int.Parse(data[3]);
                var secondCol = int.Parse(data[4]);

                bool firstIsValid = firstRow >= 0 && firstRow < rows &&
                                    firstCol >= 0 && firstCol < cols;
                bool secondIsValid = secondRow >= 0 && secondRow <= rows &&
                                     secondCol >= 0 && secondCol <= cols;
                bool notValid = firstRow < 0 || firstRow >= rows ||
                                firstCol < 0 || firstCol >= cols;

                if (!firstIsValid || !secondIsValid)
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                var firstValue = matrix[firstRow, firstCol];
                var secondValue = matrix[secondRow, secondCol];

                matrix[firstRow, firstCol] = secondValue;
                matrix[secondRow, secondCol] = firstValue;

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write($"{matrix[row, col]} ");
                    }

                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }
        }
    }
}
