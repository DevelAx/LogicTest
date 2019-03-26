using System.Collections.Generic;

namespace Logic
{
    public class Result
    {
        public LinkedList<CellPosition> Cells { get; set; } = new LinkedList<CellPosition>();
        public int ProductValue { get; set; }
    }
}
