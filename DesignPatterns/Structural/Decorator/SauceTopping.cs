using System;

namespace DesignPatterns.Structural.Decorator
{
    public class SauceTopping : PizzaToppingDecorator, IPizza
    {
        public SauceTopping(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Sauce");
        }

        public string GetDescription()
        {
            return _pizza.GetDescription() + ", Sauce";
        }

        public decimal GetPrice()
        {
            return _pizza.GetPrice() + 1;
        }
    }
}
