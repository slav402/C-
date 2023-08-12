using Newtonsoft.Json.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AXEGettersTest()
        {
            Axe axe = new Axe(10, 10);

            Assert.AreEqual(10, axe.AttackPoints);
            Assert.AreEqual(10, axe.DurabilityPoints);
        }

        [Test]
        public void AxeAttakShuldDropDurability()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);

            //Asset
            Assert.AreEqual(9, axe.DurabilityPoints, "Axe durability doesn't change after attack.");
        }

        [Test]
        public void TestAttackingWithBrokenWeapon()
        {
            //Arrange
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);

            //Act
            //Asset
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}