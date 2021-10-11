using System;
using NUnit.Framework;
using ToyRobotSimulator.src.Extras;
using ToyRobotSimulator.src.Model;

namespace ToyRobotSimulator.test.Extras
{
    [TestFixture]
    public class TestBoardOutputter
    {
        [Test]
        [TestCase(5, 5, 4, 4, Utils.DirectionCode.SOUTH, "Output: 4,4,SOUTH")]
        public void STRING(int w, int h, int x, int y, Utils.DirectionCode direction,string expected)
        {
            // GIVEN
            Board myboard = new Board();
            myboard.Initialize(w, h);
            myboard.Place(x, y, direction);
            BoardOutputter boardOut = new BoardOutputter(myboard);
        
            // WHEN
            var value = boardOut.STRING();
            // ASSERT
            Assert.True(value.Equals(expected));

        }
    }
}
