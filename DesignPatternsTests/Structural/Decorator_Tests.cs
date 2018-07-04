using NUnit.Framework;
using DesignPatterns.Structural.Decorator;

namespace DesignPatternsTests
{
    [TestFixture]
    public class Decorator_Tests
    {
        [Test]
        public void Using_Decorator()
        {
            //The innner most pizza must be PlainPizza
            IPizza pizzaOrder = new MozzarellaTopping(new MozzarellaTopping(new ChickenTopping(new SauceTopping(new PlainPizza()))));

            Assert.AreEqual(pizzaOrder.GetPrice(), 13);
        }
    }
}