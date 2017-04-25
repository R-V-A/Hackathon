using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        protected int _power;
        protected int _authority;
        public struct Coordinate
        {
            public int x;
            public int y;
        }

        public Coordinate _coordinates;
        
        protected Person(Coordinate coordinates)
        {
            _coordinates = coordinates;
        }
    }
}
