using System;
using NUnit.Framework;
using ToyRobotSimulator.src.model;
using ToyRobotSimulator.src;

namespace ToyRobotSimulator.test.Model
{
    [TestFixture]
    public class TestBoard
    {
        public Board myboard = new Board();

        [Test]
        [TestCase(5, 5, 25)]
        [TestCase(10, 10, 100)]
        public void InitializeBoard(int w, int h, int expectedPosition)
        {
            // GIVEN

            // WHEN
            myboard.Initialize(w, h);

            // ASSERT
            Assert.True(expectedPosition == myboard.GetPositions().Length);

        }

        [Test]
        [TestCase(5, 5, Utils.DirectionCode.SOUTH)]
        [TestCase(10, 10, Utils.DirectionCode.NORTH)]
        public void Place(int x, int y, Utils.DirectionCode direction)
        {
            // GIVEN

            // WHEN
            var value = myboard.Place(x, y, direction);

            // ASSERT
            Assert.True(value);
        }

        [Test]
        [TestCase(5, 5, Utils.DirectionCode.SOUTH, new int[]{4,5})]
        [TestCase(0, 5, Utils.DirectionCode.NORTH, new int[] { 1, 5 })]
        public void Move(int x, int y, Utils.DirectionCode direction,int[] newExpectedPosition)
        {
            // GIVEN
            myboard.Place(x, y, direction);

            // WHEN
            int[] position = myboard.Move();

            // ASSERT
            Assert.True(Array.Exists(position, e => e == newExpectedPosition[0]));
            Assert.True(Array.Exists(position, e => e == newExpectedPosition[1]));


        }
    }
}
