using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class Result
    {
        private readonly Stack<Cell> _cells;
        private readonly int _capacity;

        internal Result(int capacity = 0)
        {
            _capacity = capacity;
            _cells = new Stack<Cell>(capacity);
        }

        internal Result(Result result)
        {
            _cells = new Stack<Cell>(result.Cells);
            _capacity = _cells.Count;
        }

        public int Product
        {
            get
            {
                if (_cells.Count == 0)
                    return 0;

                return _cells.Aggregate(1, (p, nextCell) => p * nextCell.Value);
            }
        }

        public void AddCell(Cell cell)
        {
            if (_capacity == _cells.Count)
                throw new InvalidOperationException("The required number of cells has already been added.");

            _cells.Push(cell);
        }

        public void RemoveCell()
        {
            _cells.Pop();
        }

        public bool IsCompleted
        {
            get { return _cells.Count == _capacity; }
        }

        public IEnumerable<Cell> Cells
        {
            get { return _cells; }
        }

        public int Steps { get; set; }
    }
}
