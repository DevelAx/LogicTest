using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class Cell
    {
        public readonly int Value;
        public readonly int X, Y;
        public bool Checked = false;
        public bool IsBusy = false;

        public Cell(int x, int y, int value)
        {
            Value = value;
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{Value}]: {{{X}, {Y}}}";
        }

        // internal Result findLargestAdjacentCellsProduct(Cell[,] cells, TableSize tableSize, int tailCount, bool startPoint)
        // {
        //     this.isBusy = true;
        //     var result = new Result();

        //     if
        // }

        // public Result findLargestAdjacentCellsProduct2(Cell[,] cells, TableSize tableSize, int tailCount, bool startPoint)
        // {
        //     Debug($"[{5 - tailCount}]: {{{this.x}, {this.y}}}");
        //     this.isBusy = true;
        //     var result = new Result();
        //     var largestNeighbours = new List<Cell>(tailCount);

        //     if (tailCount > 1)
        //     {
        //         for (int y = this.y - 1; y <= this.y + 1; y++)
        //         {
        //             if (y < 0)
        //                 continue; // out of the range of Y axis

        //             if (y == tableSize.Y)
        //                 break; // out of the range of Y axis

        //             for (int x = this.x - 1; x <= this.x + 1; x++)
        //             {
        //                 if (y == this.y && x == this.x)
        //                     continue; // skip the current cell position (center of the orbit)
        //                 else if (x == tableSize.X)
        //                     break;
        //                 else if (x < 0)
        //                     continue;

        //                 Cell nextCell = cells[y, x];

        //                 if (nextCell.isBusy)
        //                     continue;

        //                 if (largestNeighbours.Count < tailCount)
        //                 {
        //                     largestNeighbours.Add(nextCell);
        //                 }
        //                 else
        //                 {
        //                     for (int i = 0; i < largestNeighbours.Count; i++)
        //                     {
        //                         if (largestNeighbours[i].value < nextCell.value)
        //                             largestNeighbours[i] = nextCell;
        //                     }
        //                 }

        //                 Result newResult = nextCell.findLargestAdjacentCellsProduct(cells, tableSize, tailCount - 1, false);

        //                 if (newResult.Product > result.Product)
        //                 {
        //                     result = newResult;
        //                     Debug($"+{result.Product}");
        //                 }
        //             }
        //         }


        //         if (largestNeighbours.Count > 0 && largestNeighbours.Count == tailCount - 1)
        //         {
        //             int largestNeighboursProduct = largestNeighbours.Aggregate(1, (product, nextCell) => nextCell.value * product);

        //             if (largestNeighboursProduct > result.Product)
        //             {
        //                 result.Product = largestNeighboursProduct;
        //                 result.Cells = new LinkedList<CellPosition>(largestNeighbours.Select(cell => new CellPosition(cell.x, cell.y)));
        //             }
        //         }

        //         result.Product *= this.value;
        //     }
        //     else
        //     {
        //         result.Product = this.value;
        //     }

        //     this.isBusy = false;
        //     result.Cells.AddFirst(new CellPosition(this.x, this.y));
        //     return result;
        // }

        private static void Debug(string text)
        {
            //Console.WriteLine(text);
        }
    }
}

