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
        [TestCase(5, 5, "SOUTH")]
        [TestCase(10, 10, "NORTH")]
        public void Place(int x, int y, string direction)
        {
            // GIVEN

            // WHEN
            var value = myboard.Place(x, y, Utils.GetDirection(direction));

            // ASSERT
            Assert.True(value);
        }

        [Test]
        [TestCase(5, 5, "SOUTH",  new int[]{4,5})]
        [TestCase(0, 5, "NORTH", new int[] { 1, 5 })]
        public void Move(int x, int y, string direction,int[] newExpectedPosition)
        {
            // GIVEN
            myboard.Place(x, y, Utils.GetDirection(direction));

            // WHEN
            int[] position = myboard.Move();

            // ASSERT
            Assert.True(Array.Exists(position, e => e == newExpectedPosition[0]));
            Assert.True(Array.Exists(position, e => e == newExpectedPosition[1]));


        }
    }
}
