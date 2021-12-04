using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double[][] matrix = new double[n][];

            for (int row = 0; row < n; row++)
            {
                double[] data = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                matrix[row] = data;
            }

            for (int row = 0; row < n - 1; row++)
            {
                double[] first = matrix[row];
                double[] second = matrix[row + 1];

                if (first.Length == second.Length)
                {
                    matrix[row] = first.Select(x => x * 2).ToArray();
                    matrix[row + 1] = second.Select(x => x * 2).ToArray();
                }
                else
                {
                    matrix[row] = first.Select(x => x / 2).ToArray();
                    matrix[row + 1] = second.Select(x => x / 2).ToArray();
                }
            }

            var input = Console.ReadLine();

            while (input != "End")
            {
                string[] line = input.Split();
                var command = line[0];
                var rowIndex = int.Parse(line[1]);
                var colIndex = int.Parse(line[2]);
                var value = int.Parse(line[3]);

                bool isValid = rowIndex >= 0 && rowIndex < n
                        && colIndex >= 0 && colIndex < matrix[rowIndex].Length;

                if (!isValid)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (command == "Add")
                {
                    matrix[rowIndex][colIndex] += value;

                }
                else if (command == "Subtract")
                {
                    matrix[rowIndex][colIndex] -= value;
                }

                input = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }
    }
}
