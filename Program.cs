using System;
using System.Linq;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[,] array =
                {
                    {2, 2, 1},
                    {2, 2, 1},
                    {1, 1, 1}
                };

                ProcessArray(array, 4);
            }
            {

                int[,] array =
                {
                    {2, 2, 2},
                    {1, 2, 1},
                    {1, 1, 1}
                };

                ProcessArray(array, 4);
            }
            {

                int[,] array =
                {
                    {2, 0, 2},
                    {2, 2, 1},
                    {1, 1, 1}
                };

                ProcessArray(array, 4);
            }
            {

                int[,] array =
                {
                    {2, 0, 1},
                    {2, 2, 1},
                    {1, 1, 2}
                };

                ProcessArray(array, 4);
            }
            {

                int[,] array =
                {
                    {2, 0, 1},
                    {1, 2, 2},
                    {2, 1, 1}
                };

                ProcessArray(array, 4);
            }
            {

                int[,] array =
                {
                    {9, 0, 1},
                    {2, 1, 9},
                    {9, 1, 1}
                };

                ProcessArray(array, 4);
            }

            return;

            // Random arrays show:
            var random = new Random(Environment.TickCount);
            int maxArraySize = 2;

            for (int i = 0; i < 5; i++)
            {
                int maxY = random.Next(maxArraySize) + 1;
                int maxX = random.Next(maxArraySize) + 1;
                int[,] array = new int[maxY, maxX];

                for (int y = 0; y < maxY; y++)
                {
                    for (int x = 0; x < maxX; x++)
                    {
                        array[y, x] = random.Next(10);
                    }
                }

                ProcessArray(array, 4);
            }
        }

        private static void ProcessArray(int[,] array, int cellChainLength)
        {
            Table table = new Table(array);
            Result result = table.findLargestFactorChain(cellChainLength);
            ShowResult(array, result);
        }

        private static void ShowResult(int[,] array, Result result)
        {
            // Prepare to display results:
            int maxY = array.GetLength(0);
            int maxX = array.GetLength(1);
            bool[,] chainCells = new bool[maxY, maxX];

            foreach (var cell in result.Cells)
            {
                chainCells[cell.Y, cell.X] = true;
            }

            // Display results:
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Product result: {result.ProductValue}");

            for (int y = 0; y < maxY; y++)
            {
                for (int x = 0; x < maxX; x++)
                {
                    char marker = (chainCells[y, x] ? '+' : ' ');
                    Console.Write("{0, 4}", $"{marker}{array[y, x]}");
                }

                Console.WriteLine();
            }

            return;
        }
    }
}
