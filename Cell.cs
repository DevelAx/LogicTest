using System;

namespace Logic
{
    public class Cell
    {
        private readonly int value;
        private readonly int x, y;
        private bool isBusy = false;

        internal Cell(int x, int y, int value)
        {
            this.value = value;
            this.x = x;
            this.y = y;
        }

        internal Result findLargestAdjacentCellsProduct(Cell[,] cells, TableSize tableSize, int tailCount, bool startPoint)
        {
            Debug($"[{4 - tailCount}]: {{{this.x}, {this.y}}}");
            this.isBusy = true;
            var result = new Result();
            var thirdResult;

            if (tailCount > 1)
            {
                for (int y = this.y - 1; y <= this.y + 1; y++)
                {
                    if (y < 0)
                        continue; // out of the range of Y axis

                    if (y == tableSize.Y)
                        break; // out of the range of Y axis

                    for (int x = this.x - 1; x <= this.x + 1; x++)
                    {
                        if (y == this.y && x == this.x)
                            continue; // skipp the current cell position (center of the orbit)
                        else if (x == tableSize.X)
                            break;
                        else if (x < 0)
                            continue;

                        Cell nextCell = cells[y, x];

                        if (nextCell.isBusy)
                            continue;

                        Result newResult = nextCell.findLargestAdjacentCellsProduct(cells, tableSize, tailCount - 1, false);

                        if (newResult.ProductValue > result.ProductValue)
                        {
                            result = newResult;
                            Debug($"+{result.ProductValue}");
                        }
                    }
                }

                result.ProductValue *= this.value;
            }
            else
            {
                result.ProductValue = this.value;
            }

            //Console.WriteLine();

            this.isBusy = false;
            result.Cells.AddFirst(new CellPosition(this.x, this.y));
            return result;
        }

        private static void Debug(string text)
        {
            Console.WriteLine(text);
        }
    }
}

