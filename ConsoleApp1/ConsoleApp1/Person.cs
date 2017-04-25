﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Coordinates
    {
        public int x;
        public int y;
    }

    public class Person
    {
        int _credits;
        int _power;
        int _authority;
        Coordinates _coordinates;

        public Person(int credits, int power, int authority, Coordinates coordinates)
        {
            _credits = credits;
            _power = power;
            _authority = authority;
            _coordinates = coordinates;
        }
    }
}