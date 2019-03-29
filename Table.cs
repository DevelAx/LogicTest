using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class Table
    {
        private const bool _debug = false;
        private readonly Cell[,] _cells;
        private readonly TableSize _size;
        private Result _largestResult, _currentResult;
        private int _steps, _cellsCount;

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

        public Result findLargestAdjacentCellsProduct(int cellsCount)
        {
            _cellsCount = cellsCount;
            _largestResult = new Result();
            _currentResult = new Result(cellsCount);
            _steps = 0;

            for (int y = 0; y < _size.Y; y++)
            {
                for (int x = 0; x < _size.X; x++)
                {
                    int deltaX = Math.Min(_size.X - x, cellsCount);
                    int deltaY = Math.Min(_size.Y - y, cellsCount);

                    if (deltaX * deltaY < cellsCount)
                        continue; // not enough space for required number of cells

                    int endX = x + deltaX - 1;
                    int endY = y + deltaY - 1;
                    _largestResult.Steps += _steps;
                    _steps = 0;
                    find(x, y, endX, endY, cellsCount);
                }
            }

            return _largestResult;
        }

        private void find(int startX, int startY, int endX, int endY, int cellsCount)
        {
            for (int y = startY; y <= endY; y++)
            {
                for (int x = startX; x <= endX; x++)
                {
                    var cell = _cells[y, x];

                    if (cell.IsBusy  || _steps > 0 && !HasHeighbour(cell))
                        continue;

                    _steps++;
                    cell.IsBusy = true;
                    _currentResult.AddCell(cell);

                    if (cellsCount == 1)
                    {
                        if (_currentResult.Product > _largestResult.Product)
                        {
                            _largestResult = new Result(_currentResult);
                        }
                    }
                    else
                    {
                        find(startX, startY, endX, endY, cellsCount - 1);
                    }

                    cell.IsBusy = false;
                    _currentResult.RemoveCell();
                }
            }
        }

        private bool AllHeighbours(List<Cell> cells)
        {
            int count = cells.Count;

            for (int i = 0; i < count - 1; i++)
            {
                bool found = false;
                Cell cell = cells[i];

                for (int j = i + 1; j < count; j++)
                {
                    Cell cell2 = cells[j];
                    int dx = Math.Abs(cell2.X - cell.X);
                    int dy = Math.Abs(cell2.Y - cell.Y);

                    if (dx < 2 && dy < 2)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    return false;
            }

            return true;
        }

        private bool HasHeighbour(Cell cell)
        {
            for (int y = cell.Y - 1; y <= cell.Y + 1; y++)
            {
                if (y < 0)
                    continue;

                if (y == _size.Y)
                    break;

                for (int x = cell.X - 1; x <= cell.X + 1; x++)
                {
                    if (y == cell.Y && x == cell.X)
                        continue; // skip the current cell position
                    else if (x == _size.X)
                        break;
                    else if (x < 0)
                        continue;

                    if (_cells[y, x].IsBusy)
                        return true;
                }
            }

            return false;
        }
    }
}
