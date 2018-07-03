using NUnit.Framework;
using DesignPatterns.Strategy;

namespace DesignPatternsTests
{
    [TestFixture]
    public class Strategy_Tests
    {
        [Test]
        public void Using_Strategy()
        {
            Animal sparky = new Dog();
            //Dogs cant fly
            Assert.IsFalse(sparky.TryToFly().Contains("fly"));
            //Give dog the ability to fly and try again
            sparky.SetFlyingAbility(new AnimalFlysHigh());
            Assert.IsTrue(sparky.TryToFly().Contains("fly"));

            Animal tweety = new Bird();
            //Birds can fly
            Assert.IsTrue(tweety.TryToFly().Contains("fly"));
        }
    }
}