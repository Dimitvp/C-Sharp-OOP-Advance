using System;
using NUnit.Framework;

namespace Skeleton.Test
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilyAfterAttack()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);
            //Assert
            Assert.AreEqual(9, axe.DurabilityPoints);
        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            //Arrange
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }
    }
}
