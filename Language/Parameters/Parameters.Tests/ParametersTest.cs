using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learn.CSharp.Language
{
    [TestClass]
    public class ParametersTest
    {
        [TestMethod]
        public void ReferenceType_PassByValue_Test()
        {
            var srt = new Player() { Id = 1, Name = "Sachin Tendulkar" };
            int age = 30;

            UpdateInfo(srt, age);

            Assert.IsTrue(srt.Id == 2);
            Assert.IsTrue(age == 30);
        }
        private void UpdateInfo(Player player, int age)
        {
            player.Id = 2;
            age = 32;
        }

        [TestMethod]
        public void ValueType_PassByValue_Test()
        {
            int jerseyNumber = 30;
            UpdateJerseyNumber(jerseyNumber);
            Assert.IsTrue(jerseyNumber == 30);
        }

        private void UpdateJerseyNumber(int jersey)
        {
            jersey++;
        }

        [TestMethod]
        public void PassByValueTestNewInstance()
        {
            var player = new Player() { Id = 1, Name = "Prasad Honrao" };
            int age = 30;
            UpdatePassByValueTestNewInstance(player, age);

            Assert.IsTrue(player.Id == 1);
            Assert.IsTrue(age == 30);
        }

        private void UpdatePassByValueTestNewInstance(Player player, int age)
        {
            player = new Player();
            player.Id = 2;
            age = 32;
        }

        [TestMethod]
        public void PassByReferenceTest()
        {
            var player = new Player() { Id = 1, Name = "Prasad Honrao" };
            int age = 30;
            UpdatePassByReference(ref player, ref age);

            Assert.IsTrue(player.Id == 2);
            Assert.IsTrue(age == 32);
        }

        private void UpdatePassByReference(ref Player player, ref int age)
        {
            // Even though new instance is created, it will still refer to original reference type
            player = new Player();
            player.Id = 2;
            age = 32;
        }

        [TestMethod]
        public void OutParameterTest()
        {
            var player = new Player() { Id = 1, Name = "Prasad Honrao" };
            int age;

            UpdateOutParameter(player, out age);

            Assert.IsTrue(player.Id == 2);
            Assert.IsTrue(age == 32);
        }

        private void UpdateOutParameter(Player player, out int age)
        {
            player.Id = 2;
            age = 32;
        }
    }
}
