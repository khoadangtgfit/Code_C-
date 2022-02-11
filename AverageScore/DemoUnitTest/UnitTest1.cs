using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DemoUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 5;
            double b = 3;
            double reality = AverageScore.AverageScore.averageScore(a, b);
            double expect = 4;
            Assert.AreEqual(expect, reality);
        }
    }
}
