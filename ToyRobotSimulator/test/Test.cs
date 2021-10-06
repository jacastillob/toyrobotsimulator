using NUnit.Framework;
using System;
namespace ToyRobotSimulator
{   
    [TestFixture()]
    public class TestProgram
    {
        Program p = new Program();
        [Test()]
        public void Test0()
        {
            Assert.True(p.cont++ == 0);
        }
        
    }
}
