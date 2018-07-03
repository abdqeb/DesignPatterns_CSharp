using System;

namespace DesignPatterns.Structural.Decorator
{
    public class PlainPizza : IPizza
    {
        public PlainPizza()
        {
            Console.WriteLine("Adding Dough");
        }

        string IPizza.GetDescription()
        {
            return "Plain Pizza";
        }

        decimal IPizza.GetPrice()
        {
            return 4;
        }
    }
}
