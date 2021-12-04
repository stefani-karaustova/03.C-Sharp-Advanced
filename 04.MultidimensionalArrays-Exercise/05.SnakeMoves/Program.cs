using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];
            var capacity = rows * cols;

            var snake = Console.ReadLine();

            char[,] matrix = new char[rows, cols];
            var queue = new Queue<char>();

            var count = 0;

            for (int i = 0; i < snake.Length; i++)
            {
                queue.Enqueue(snake[i]);
                count++;

                if (count == capacity)
                {
                    break;
                }

                if (i == snake.Length - 1)
                {
                    i = -1;
                }
            }

            for (int j = 0; j < rows; j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < cols; i++)
                    {
                        matrix[j, i] = queue.Dequeue();
                    }
                }
                else if (j % 2 != 0)
                {
                    for (int k = cols - 1; k > -1; k--)
                    {
                        matrix[j, k] = queue.Dequeue();
                    }
                }

            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}
