using System.Collections.Generic;
using System.Drawing;

namespace Logic
{
    public class CellPosition
    {
        public readonly int X;
        public readonly int Y;

        internal CellPosition(int x, int y){
            X = x;
            Y = y;
        }
    }
}
