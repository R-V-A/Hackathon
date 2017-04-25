using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Coordinate
    {
        public int x;
        public int y;
    }

    public class Person
    {
        public int _power;
        protected int _authority;
        protected Coordinate _coordinates;

        public Person(Coordinate coordinates)
        {
            _coordinates = coordinates;
        }
    }    
}
