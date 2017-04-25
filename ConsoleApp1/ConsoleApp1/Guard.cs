using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Guard : Person
    {

        int _stepCount;
        int localStepCount;
        int _vectorX, _vectorY;

        public Guard(Coordinate coordinates, int stepCount, int vectorX, int vectorY)
            : base(coordinates)
        {
            // Проверка аргументов
            if (stepCount < 0)
                throw new ArgumentException();

            _stepCount = stepCount;
            _vectorX = vectorX;
            _vectorY = vectorY;
            localStepCount = _stepCount;
        }

        public Coordinate Coordinates => _coordinates; 

        public void Update()
        {
            Move();
        }

        void Move()
        {
            _coordinates.x += _vectorX;
            _coordinates.y += _vectorY;
            if (localStepCount == 0)
            {
                localStepCount = _stepCount;
                _vectorX *= -1;
                _vectorY *= -1;
            }
        }
    }
}
