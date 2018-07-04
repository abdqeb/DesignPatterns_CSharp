using System;

namespace DesignPatterns.Structural.Decorator
{
    public class ChickenTopping : PizzaToppingDecorator, IPizza
    {
        public ChickenTopping(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Chicken");
        }

        public string GetDescription()
        {
            return _pizza.GetDescription() + ", Chicken";
        }

        public decimal GetPrice()
        {
            return _pizza.GetPrice() + 2;
        }
    }
}
