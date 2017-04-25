using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Field
    {
        Cell[,] _cells = new Cell[25, 25];
        public Cell this[int x, int y]
        {
            get { return _cells[x, y];}
        }
        public Field()
        {
            for (int i = 0; i < 25; i++)
                for (int j = 0; j < 25; j++)
                    _cells[i, j] = new Cell(TypeOfCell.Empty);
        }
        
    }
}
