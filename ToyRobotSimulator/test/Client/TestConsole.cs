using System;
using NUnit.Framework;
using ToyRobotSimulator.src.Engine;

namespace ToyRobotSimulator
{
    [TestFixture]
    public class TestConsole
    {
        public Engine myengine = new Engine();

        [Test()]
        [TestCase("PLACE 0,0,NORTH\nMOVE\nREPORT\n", "0,1,NORTH")]
        [TestCase("PLACE 0,0,NORTH\nLEFT\nREPORT\n", "0,0,WEST")]
        [TestCase("PLACE 1,2,EAST\nMOVE\nMOVE\nLEFT\nMOVE\nREPORT\n", "3,3,NORTH")]
        public void TestCommand(String command, String expected)
        {
            ///GIVEN

            //WHEN
            string value = myengine.RunCommand(command);

            //ASSERT
            Assert.True(expected == value);
        }

    }
}
