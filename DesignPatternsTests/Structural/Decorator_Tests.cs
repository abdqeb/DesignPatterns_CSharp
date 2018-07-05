using NUnit.Framework;
using DesignPatterns.Structural.Decorator;

namespace DesignPatternsTests
{
    [TestFixture]
    public class Decorator_Tests
    {
        [Test]
        public void Using_PizzaDecorator()
        {
            //The innner most pizza must be PlainPizza
            IPizza pizzaOrder = new MozzarellaTopping(new MozzarellaTopping(new ChickenTopping(new SauceTopping(new PlainPizza()))));

            Assert.AreEqual(pizzaOrder.GetPrice(), 13);
        }

        [Test]
        public void Using_A_Decorator()
        {
            //	case 1: a = new A(); //A
            //	case 2: a = new B(); //AB
            //	case 3: a = new C(); //AC
            //	case 4: a = new BC(); //ABC
            //	case 5: a = new CB(); //ACB

            IText abcText = new A();
            Assert.AreEqual(abcText.Text(), "A");

            abcText = new B(new A());
            Assert.AreEqual(abcText.Text(), "AB");

            abcText = new C(new A());
            Assert.AreEqual(abcText.Text(), "AC");

            abcText = new C(new B(new A()));
            Assert.AreEqual(abcText.Text(), "ABC");

            abcText = new B(new C(new A()));
            Assert.AreEqual(abcText.Text(), "ACB");
        }
    }
}