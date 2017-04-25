using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace ConsoleApp1Test
{
    [TestClass]
    public class GuardTest
    {
        [TestMethod]
        public void Move_TestMoving_ShouldReturnToStartPosition()
        {
            //arrange
            Person.Coordinate coor = new Person.Coordinate { x = 2, y = 3 };
            int vecX = 1;
            int vecY = 1;
            int steps = 10;
            Guard guard = new Guard(coor, steps, vecX, vecY);
            //act
            for (int i = 0; i < 2 * steps; i++)
            {
                guard.Update();
            }
            Person.Coordinate resultCoordinate = guard.Coordinates;
            //assert
            Assert.AreEqual(coor, resultCoordinate);
        }
    }
}
