using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Struct.Tests
{
    [TestClass]
    public class StructTests
    {
        [TestMethod]
        public void TwoPointStructTest()
        {
            Point p1 = new Point
            {
                X = 0,
                Y = 0
            };

            Point p2 = p1;

            Assert.IsTrue(p1.Equals(p2));
        }

        [TestMethod]
        public void StructHoldsValueTest()
        {
            Point p1 = new Point
            {
                X = 0,
                Y = 0
            };

            Point p2 = p1;

            p2.X = 10;

            Assert.IsTrue(p1.X == 0);
            Assert.IsTrue(p2.X == 10);
        }
    }
}
