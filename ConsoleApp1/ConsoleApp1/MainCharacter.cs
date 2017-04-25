using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MainCharacter : Person
    {
        int autority = 0;
        int power = 0;
        public MainCharacter(Coordinate coordinates) : base (coordinates)
        {
            int _x = coordinates.x;
            int _y = coordinates.y;
        }
        public string Show(Coordinate coord)
        {
            var str = String.Format($"Текущие координаты ({coord.x}: {coord.y})");
            return str;
        }

    }
}
