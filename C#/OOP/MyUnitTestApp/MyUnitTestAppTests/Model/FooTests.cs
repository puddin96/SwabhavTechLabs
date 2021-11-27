using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyUnitTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace MyUnitTestApp.Model.Tests
{
    [TestClass()]
    public class FooTests
    {
        [TestMethod()]
        public void F1Test()
        {
            Assert.Fail();
        }
    }
}