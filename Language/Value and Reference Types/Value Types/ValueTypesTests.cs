using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueTypes
{
    [TestClass]
    public class ValueTypeTest
    {
        [TestMethod]
        public void TwoIntsTest()
        {
            int x = 5;
            int y = 10;
            Assert.IsFalse(x == y);
        }

        [TestMethod]
        public void TwoIntsWithSameValueTest()
        {
            int x = 5;
            int y = 5;
            Assert.IsTrue(x == y);
        }

        [TestMethod]
        public void TwoIntsWithSameValueAndIncrementerTest()
        {
            int x = 5;
            int y = x++;
            Assert.IsTrue(y == 5);
            Assert.IsTrue(x == 6);
        }

        [TestMethod]
        public void TwoIntAssignmentTest()
        {
            int x = 5;
            int y = 10;
            x = y;
            Assert.IsTrue(x == y);
        }

        [TestMethod]
        public void IntHoldsValueTest()
        {
            int x = 5;
            int y = x;
            y = 10; // does not change value of x, which would have been if int was a reference type
            Assert.AreNotEqual(x, y);
            Assert.IsTrue(x == 5);
            Assert.IsTrue(y == 10);
        }

        [TestMethod]
        public void IntwithReferenceTypeTest()
        {
            int x = 1;
            Employee emp1 = new Employee() { Id = 1, Name = "Prasad Honrao", Role = "Developer" };
            Assert.IsTrue(x == emp1.Id);
            Assert.IsFalse((object)x == emp1);
        }
    }
}
