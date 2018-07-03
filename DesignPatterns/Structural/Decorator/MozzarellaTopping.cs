using System;

namespace DesignPatterns.Structural.Decorator
{
    public class MozzarellaTopping : PizzaToppingDecorator
    {
        public MozzarellaTopping(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Mozzarella");
        }

        public string GetDescription()
        {
            return _pizza.GetDescription() + ", Mozzarella";
        }

        public decimal GetPrice()
        {
            return _pizza.GetPrice() + 3;
        }
    }
}
