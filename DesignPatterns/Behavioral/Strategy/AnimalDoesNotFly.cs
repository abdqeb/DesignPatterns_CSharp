namespace DesignPatterns.Strategy
{
    public class AnimalDoesNotFly : IFly
    {
        public string Fly()
        {
            return "This animal is walking";
        }
    }
}