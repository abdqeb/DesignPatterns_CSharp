namespace DesignPatterns.Structural.Decorator
{
    public abstract class PizzaToppingDecorator : IPizza
    {
        protected IPizza _pizza; 

        public PizzaToppingDecorator(IPizza newPizza)
        {
            _pizza = newPizza;
        }

        string IPizza.GetDescription()
        {
            return _pizza.GetDescription();
        }

        decimal IPizza.GetPrice()
        {
            return _pizza.GetPrice();
        }
    }
}
