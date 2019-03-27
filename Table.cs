using System;
using System.Collections.Generic;

namespace Logic
{
    public class Table
    {
        private readonly Cell[,] _cells;
        private readonly TableSize _size;

        public Table(int[,] array)
        {
            _size = new TableSize(array.GetLength(0), array.GetLength(1));
            _cells = new Cell[_size.Y, _size.X];

            for (int y = 0; y < _size.Y; y++)
            {
                for (int x = 0; x < _size.X; x++)
                {
                    _cells[y, x] = new Cell(x, y, array[y, x]);
                }
            }
        }

        public Result findLargestFactorChain(int chainCount)
        {
            var largestResult = new Result();

            for (int y = 0; y < _size.Y; y++)
            {
                for (int x = 0; x < _size.X; x++)
                {
                    //Console.WriteLine("----------------------------");
                    //Console.Write($"({++counter}): ");
                    Result newResult = _cells[y, x].findLargestAdjacentCellsProduct(_cells, _size, chainCount, true);

                    if (largestResult.ProductValue < newResult.ProductValue)
                    {
                        largestResult = newResult;
                    }

                    //Console.WriteLine($"Mult = {newResult.ProductValue}");
                }
            }

            return largestResult;
        }
    }
}
