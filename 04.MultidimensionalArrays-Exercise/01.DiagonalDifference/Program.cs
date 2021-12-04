using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] data = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            var primary = 0;
            var secondary = 0;
            var counter = n - 1;

            for (int row = 0; row < n; row++)
            {
                primary += matrix[row, row];
                secondary += matrix[row, counter];
                counter--;
            }

            var diff = Math.Abs(primary - secondary);
            Console.WriteLine(diff);
        }
    }
}
