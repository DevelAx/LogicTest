using System;

namespace Logic
{
    public class Cell
    {
        private readonly int value;
        private readonly int x, y;
        private bool isAllowed = true;

        internal Cell(int x, int y, int value)
        {
            this.value = value;
            this.x = x;
            this.y = y;
        }

        internal Result findLargestFactorChain(Cell[,] cells, TableSize tableSize, int chainCount, bool startPoint)
        {
            //Console.Write($"[{this.y}, {this.x}] => ");
            var result = new Result();

            if (chainCount > 1)
            {
                // Обход всегда происходит по часовой стрелке.
                // Запрещены шаги на клетки:
                //  1). которые были корнем проверки;
                //  2). шаги назад (на клетку, из которой только что пришли);

                for (int dy = -1; dy < 2; dy++)
                {
                    int y = this.y + dy;

                    if (y < 0)
                        continue; // out of the range of Y axis

                    if (y == tableSize.Y)
                        break; // out of the range of Y axis

                    for (int dx = 1; dx > -2; dx--)
                    {
                        int x = this.x + dx;

                        if (dy == 0 && dx == 0)
                            continue; // skipping the current cell position
                        else if (x == tableSize.X)
                            continue; // out of the range of X axis
                        else if (x < 0)
                            break; // out of the range of X axis

                        Cell nextCell = cells[y, x];

                        if (!nextCell.isAllowed)
                            continue; // It's a previous step cell or it has been a start point once.

                        this.isAllowed = false;
                        Result newResult = cells[y, x].findLargestFactorChain(cells, tableSize, chainCount - 1, false);
                        this.isAllowed = true;

                        if (newResult.ProductValue > result.ProductValue)
                            result = newResult;
                    }
                }
            }
            else
            {
                // Apply this cell values.S
                result.ProductValue = 1;
            }

            //Console.WriteLine();

            this.isAllowed = !startPoint; // If it's a start point it's check and will never be allowed.
            result.ProductValue *= this.value;
            result.Cells.AddFirst(new CellPosition(this.x, this.y));
            return result;
        }
    }
}

