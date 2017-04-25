using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Field
    {
        Cell[,] _cells = new Cell[26, 26];
        public Cell this[int x, int y]
        {
            get { return _cells[x, y];}
        }
        public Field()
        {
            for (int i = 1; i < 26; i++)
                for (int j = 1; j < 26; j++)
                    _cells[i, j] = new Cell(TypeOfCell.Empty);
            for (int i = 1; i < 26; i++)
            {
                _cells[1, i] = new Cell(TypeOfCell.HWall);
                _cells[25, i] = new Cell(TypeOfCell.HWall);
                _cells[i, 1] = new Cell(TypeOfCell.WWall);
                _cells[i, 25] = new Cell(TypeOfCell.WWall);
            }
        }
        
    }
}
