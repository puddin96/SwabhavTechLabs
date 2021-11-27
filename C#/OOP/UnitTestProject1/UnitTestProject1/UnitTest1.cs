using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using AurionProMathCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorldCore.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
        private const string Expected = "Hello World!";
        private readonly object HelloWorldCore;
    }
}
