using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeCoverage;

namespace TestCodeCoverageTests
{
    [TestClass]
    public class Class1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c = new Class1();

            Assert.AreEqual(0, c.Method1(true, "foo"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Class1 c = new Class1();

            Assert.AreEqual(2, c.Method1(true, "bar"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Class1 c = new Class1();

            Assert.AreEqual(3, c.Method1(true, "qix"));
        }
    }
}
