using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LSPSolution.Model;

namespace LSPSolutionTest
{
    [TestClass]
    public class UnitTest1
    {
        Rectangle R1 = new Rectangle(20, 30);

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual<int>(20, R1.Width);
            Assert.AreEqual<int>(30, R1.Height);
            //R1.Height = 80;
            R1.Height = R1.Height + 10;
            Assert.AreEqual<int>(40, R1.Height);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual<int>(R1.CalculateArea(), 600);
        }
    }
}
