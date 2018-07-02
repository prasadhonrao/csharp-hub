using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learn.CSharp.Language.DataTypes.Tests
{
    [TestClass]
    public class BooleanTests
    {
        [TestMethod]
        public void Boolean_True_Test()
        {
            bool trueValue = true;
            Assert.IsTrue(trueValue);
        }

        [TestMethod]
        public void Boolean_False_Test()
        {
            bool falseValue = false;
            Assert.IsFalse(falseValue);
        }

        [TestMethod]
        public void Boolean_Expression_Test()
        {
            bool isTen = 5 + 5 == 10;
            Assert.IsTrue(isTen);
        }

        [TestMethod]
        public void Boolean_And_Operator_Test()
        {
            bool result = true && false;
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Boolean_Or_Operator_Test()
        {
            bool result = true || false;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Boolean_Not_Operator_Test()
        {
            bool result = !true;
            Assert.IsFalse(result);
        }
    }
}
