using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learn.CSharp.Language
{
    [TestClass]
    public class ReferenceTypesTests
    {
        [TestMethod]
        public void InstanceRefersToItSelfTest()
        {
            Employee emp = new Employee() { Id = 1, Name = "Prasad Honrao", Role = "Developer" };
            Assert.IsTrue(emp == emp);
        }

        [TestMethod]
        public void TwoDifferentInstancesTest()
        {
            Employee emp1 = new Employee() { Id = 1, Name = "Prasad Honrao", Role = "Developer" };
            Employee emp2 = new Employee() { Id = 2, Name = "Colin Gray", Role = "Architect" };

            Assert.IsTrue(emp1 != emp2);
        }
                

        [TestMethod]
        public void InstanceNullTest()
        {
            Employee emp1 = new Employee() { Id = 1, Role = "Developer" };
            Assert.IsNotNull(emp1);
            Assert.IsNull(emp1.Name);
        }

        [TestMethod]
        public void TwoInstancesWithSameValueIdentityTest()
        {
            Employee emp1 = new Employee() { Id = 1, Name = "Prasad Honrao", Role = "Developer" };
            Employee emp2 = new Employee() { Id = 1, Name = "Prasad Honrao", Role = "Developer" };
            Assert.IsTrue(emp1 != emp2);
        }

        [TestMethod]
        public void TwoInstancesSameMemoryLocationTest()
        {
            Employee emp1 = new Employee() { Id = 1, Name = "Prasad Honrao", Role = "Developer" };
            Employee emp2 = emp1;

            Assert.IsTrue(emp1 == emp2);
            Assert.IsTrue(emp1.Name == emp2.Name);
            Assert.IsTrue(emp2.Name == "Prasad Honrao");
        }

        [TestMethod]
        public void TwoInstancesSameMemoryLocationValueChangeTest()
        {
            Employee emp1 = new Employee() { Id = 1, Name = "Prasad Honrao", Role = "Developer" };
            Employee emp2 = new Employee() { Id = 2, Name = "Colin Gray", Role = "Architect" };

            emp1 = emp2;
            emp1.Id = 10;

            Assert.IsTrue(emp1 == emp2);
            Assert.IsTrue(emp1.Id == 10);
            Assert.IsTrue(emp2.Id == 10);
        }
    }
}
