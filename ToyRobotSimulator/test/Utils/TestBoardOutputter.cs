using System;
using NUnit.Framework;
using ToyRobotSimulator.src.Extras;
using ToyRobotSimulator.src.model;

namespace ToyRobotSimulator.test.Extras
{
    [TestFixture]
    public class TestBoardOutputter
    {
        [Test]
        [TestCase(5, 5, 4, 4, Utils.DirectionCode.SOUTH,"Output:4,4,SOUTH")]
        private void STRING(int w, int h, int x, int y, Utils.DirectionCode direction,string expected)
        {
            // GIVEN
            Board myboard = new Board();
            myboard.Initialize(w, h);
            BoardOutputter boardOut = new BoardOutputter(myboard);
            myboard.Place(x, y, direction);
            // WHEN
            var value = boardOut.STRING();
            // ASSERT
            Assert.True(value.Equals(expected));

        }
    }
}
