using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum TypeOfCell { Empty, NotEmpty, Wall}
    public class Cell
    {
        TypeOfCell _cellType;
        public Cell(TypeOfCell cellType)
        {
            _cellType = cellType;
        }
        public TypeOfCell CellType
        {
            get { return _cellType; }
        }
        
    }
}
