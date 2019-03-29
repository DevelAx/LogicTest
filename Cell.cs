using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class Cell
    {
        public readonly int Value;
        public readonly int X, Y;
        public bool IsBusy;

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
    }
}

