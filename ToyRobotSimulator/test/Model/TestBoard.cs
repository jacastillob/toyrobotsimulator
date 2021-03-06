using System;
using NUnit.Framework;
using ToyRobotSimulator.src.Extras;
using ToyRobotSimulator.src.Model;


namespace ToyRobotSimulator.test.Model
{
    [TestFixture]
    public class TestBoard
    {
        [Test]
        [TestCase(5, 5, 25)]
        //[TestCase(10, 10, 100)]
        public void InitializeBoard(int w, int h, int expectedPosition)
        {
            // GIVEN
            Board boardToBeInitialized = new Board();
            // WHEN
            boardToBeInitialized.Initialize(w, h);
            // ASSERT
            Assert.True(expectedPosition == boardToBeInitialized.GetPositions().Length);
        }
        [Test]
        [TestCase(5,5,4, 4, Utils.DirectionCode.SOUTH)]
        //[TestCase(10, 10, Utils.DirectionCode.NORTH)]
        public void Place(int w, int h,int x, int y, Utils.DirectionCode direction)
        {   
            // GIVEN
            Board myboard = new Board();
            myboard.Initialize(w, h);
            // WHEN
            var value = myboard.Place(x, y, direction);
            // ASSERT
            Assert.True(value);
        }
        [Test]
        [TestCase(5,5,4, 4, Utils.DirectionCode.SOUTH, new int[] { 3, 4})]
        [TestCase(5,5,0, 4, Utils.DirectionCode.NORTH, new int[] { 1, 4 })]
        public void Move(int w,int h,int x, int y, Utils.DirectionCode direction,int[] newExpectedPosition)
        {
            // GIVEN
            Board myboard = new Board();
            myboard.Initialize(w, h);
            myboard.Place(x, y, direction);
            // WHEN
            int[] position = myboard.Move();
            // ASSERT
            Assert.True(Array.Exists(position, e => e == newExpectedPosition[0]));
            Assert.True(Array.Exists(position, e => e == newExpectedPosition[1]));
        }
        [Test]
        [TestCase(5, 5, 4, 4, Utils.DirectionCode.SOUTH, Utils.DirectionCode.EAST)]
        [TestCase(5, 5, 0, 4, Utils.DirectionCode.NORTH, Utils.DirectionCode.WEST)]
        public void Left(int w, int h, int x, int y, Utils.DirectionCode direction, Utils.DirectionCode expectedDirection)
        {
            // GIVEN
            Board myboard = new Board();
            myboard.Initialize(w, h);
            myboard.Place(x, y, direction);
            // WHEN
            Utils.DirectionCode value = myboard.Left();
            // ASSERT
            Assert.True(value==expectedDirection);
        }
        [Test]
        [TestCase(5, 5, 4, 4, Utils.DirectionCode.EAST, Utils.DirectionCode.SOUTH)]
        [TestCase(5, 5, 0, 4, Utils.DirectionCode.NORTH, Utils.DirectionCode.EAST)]
        public void Right(int w, int h, int x, int y, Utils.DirectionCode direction, Utils.DirectionCode expectedDirection)
        {
            // GIVEN
            Board myboard = new Board();
            myboard.Initialize(w, h);
            myboard.Place(x, y, direction);
            // WHEN
            Utils.DirectionCode value = myboard.Right();
            // ASSERT
            Assert.True(value == expectedDirection);
        }
    }
}
