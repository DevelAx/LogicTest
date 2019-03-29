using System;
using System.Diagnostics;
using System.Linq;

namespace Logic
{
    internal static class Test
    {
        private static readonly Random random = new Random(Environment.TickCount);

        public static void ProcessCustomArrays()
        {
            while (true)
            {
                Console.WriteLine("\n***********************");
                Console.WriteLine("Specify the dimension of the array...");
                uint maxY = ReadInt("rows");
                uint maxX = ReadInt("columns");

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

            uint ReadInt(string dimension)
            {
                uint rowsCount;
                string rowsCountStr = null;

                do
                {
                    if (rowsCountStr != null)
                    {
                        Console.WriteLine("ERROR: the entered value is not a positive integer.\n");
                    }

                    Console.Write($"Input number of {dimension}: ");
                    rowsCountStr = Console.ReadLine();
                } while (!uint.TryParse(rowsCountStr, out rowsCount));

                return rowsCount;
            }
        }

        public static void ProcessPredefinedArrays()
        {
            Console.Write("\n***********************\n*  Predefined Arrays: *\n***********************\n");

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

            {

                int[,] array =
                {
                    {9, 0, 9},
                    {2, 1, 1},
                    {9, 1, 1}
                };

                ProcessArray(array, 4);
            }
            {

                int[,] array =
                {
                    {9, 0, 1, 1},
                    {2, 1, 9, 1},
                    {9, 1, 9, 1},
                    {9, 1, 1, 9}
                };

                ProcessArray(array, 4);
            }
            {

                int[,] array =
                {
                    {9, 0, 1, 1},
                    {2, 1, 2, 1},
                    {3, 1, 9, 1},
                    {4, 1, 1, 9}
                };

                ProcessArray(array, 4);
            }

            {
                int[,] array =
                {
                    {1, 0, 1, 1, 7, 0, 1, 1},
                    {2, 0, 1, 1, 5, 0, 1, 1},
                    {3, 0, 1, 1, 3, 0, 1, 1},
                    {4, 0, 1, 1, 9, 0, 1, 1},
                    {2, 1, 2, 1, 3, 0, 1, 1},
                    {3, 1, 9, 1, 2, 0, 1, 1},
                    {4, 1, 1, 9, 9, 0, 1, 1}
                };

                ProcessArray(array, 4);
            }
        }

        public static void ProcessRandomArrays()
        {
            Console.Write("\n\n***********************\n*  Random Arrays:     *\n***********************\n");
            int maxArraySize = 30;
            int minArraySize = 3;

            for (int i = 0; i < 5; i++)
            {
                int maxY = random.Next(minArraySize, maxArraySize);
                int maxX = random.Next(minArraySize, maxArraySize);
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

        #region Private Methods

        private static void ProcessArray(int[,] array, int cellChainLength)
        {
            Table table = new Table(array);

            Stopwatch timer = Stopwatch.StartNew();
            Result result = table.findLargestAdjacentCellsProduct(cellChainLength);
            timer.Stop();

            ShowResult(array, result, timer.ElapsedMilliseconds);
        }

        private static void ShowResult(int[,] array, Result result, long elapsedTime)
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
            Console.WriteLine($"Array: [{maxY}, {maxX}]");
            Console.WriteLine($"Product: {string.Join(" + ", result.Cells.Select(c => c.Value))} = {result.Product}");
            Console.WriteLine($"Steps: {result.Steps}");
            Console.WriteLine($"Elapsed time: {(double)elapsedTime / 1000} second(s)");

            for (int y = 0; y < maxY; y++)
            {
                for (int x = 0; x < maxX; x++)
                {
                    char marker = (chainCells[y, x] ? '*' : ' ');
                    Console.Write("{0, 3}", $"{marker}{array[y, x]}");
                }

                Console.WriteLine();
            }
        }

        #endregion Private Methods
    }
}
