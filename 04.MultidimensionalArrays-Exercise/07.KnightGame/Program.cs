﻿using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            byte[,] canAtack = new byte[size, size];
            byte[,] canBeAttacked = new byte[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = Console.ReadLine();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            var counter = 0;

            int[] maxCoordinates = UpdateMatrices(matrix, canAtack, canBeAttacked);

            while (maxCoordinates != null)
            {
                matrix[maxCoordinates[0], maxCoordinates[1]] = '0';
                canAtack = new byte[size, size];
                canBeAttacked = new byte[size, size];
                maxCoordinates = UpdateMatrices(matrix, canAtack, canBeAttacked);
                counter++;
            }

            Console.WriteLine(counter);
        }

        private static int[] UpdateMatrices(char[,] matrix, byte[,] canAtack, byte[,] canBeAttacked)
        {
            var size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] == 'K')
                    {

                        if (i > 1)
                        {
                            if (j > 0)
                            {
                                if (matrix[i - 2, j - 1] == 'K')
                                {
                                    canAtack[i, j]++;
                                    canBeAttacked[i - 2, j - 1]++;
                                }
                            }

                            if (j < size - 1)
                            {
                                if (matrix[i - 2, j + 1] == 'K')
                                {
                                    canAtack[i, j]++;
                                    canBeAttacked[i - 2, j + 1]++;
                                }
                            }
                        }

                        if (i < size - 2)
                        {
                            if (j > 0)
                            {
                                if (matrix[i + 2, j - 1] == 'K')
                                {
                                    canAtack[i, j]++;
                                    canBeAttacked[i + 2, j - 1]++;
                                }
                            }

                            if (j < size - 1)
                            {
                                if (matrix[i + 2, j + 1] == 'K')
                                {
                                    canAtack[i, j]++;
                                    canBeAttacked[i + 2, j + 1]++;
                                }
                            }
                        }

                        if (j > 1)
                        {
                            if (i > 0)
                            {
                                if (matrix[i - 1, j - 2] == 'K')
                                {
                                    canAtack[i, j]++;
                                    canBeAttacked[i - 1, j - 2]++;
                                }
                            }

                            if (i < size - 1)
                            {
                                if (matrix[i + 1, j - 2] == 'K')
                                {
                                    canAtack[i, j]++;
                                    canBeAttacked[i + 1, j - 2]++;
                                }
                            }
                        }

                        if (j < size - 2)
                        {
                            if (i > 0)
                            {
                                if (matrix[i - 1, j + 2] == 'K')
                                {
                                    canAtack[i, j]++;
                                    canBeAttacked[i - 1, j + 2]++;
                                }
                            }

                            if (i < size - 1)
                            {
                                if (matrix[i + 1, j + 2] == 'K')
                                {
                                    canAtack[i, j]++;
                                    canBeAttacked[i + 1, j + 2]++;
                                }
                            }
                        }
                    }
                }
            }

            int[] maxCoordinates = null;
            var maxSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var sum = (byte)(canAtack[i, j] + canBeAttacked[i, j]);

                    if (sum > maxSum)
                    {
                        maxCoordinates = new int[] { i, j };
                        maxSum = sum;
                    }
                }
            }

            return maxCoordinates;
        }

        private static void PrintMatrix(byte[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}