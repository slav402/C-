using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttackedTest()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);

            //Act
            dummy.TakeAttack(5);

            //Asset
            Assert.AreEqual(5, dummy.Health);
        }

        [Test]
        public void DeadDummyThrowsAnExceptionIfAttackedTest()
        {
            //Arrange
            Dummy dummy = new Dummy(0, 10);

            //Act
            //Asset
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(5));
        }

        [Test]
        public void DeadDummyCanGiveXPTest()
        {
            //Arrange
            Dummy dummy = new Dummy(0, 10);

            //Act
            int exp = dummy.GiveExperience();

            //Asset
            Assert.AreEqual(10, exp);
        }

        [Test]
        public void AliveDummyCanNotGiveXPTest()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);

            //Act
            //Asset
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}