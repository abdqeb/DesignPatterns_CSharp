namespace DesignPatterns.Strategy
{
    public class Bird : Animal
    {
        public Bird()
        {
            flyingType = new AnimalFlys();
            Sound = "Tweet";
        }
    }
}
