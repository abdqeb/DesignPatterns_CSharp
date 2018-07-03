namespace DesignPatterns.Strategy
{
    public class Animal
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public int Weight { get; set; }
        public string FavFood { get; set; }
        public double Speed { get; set; }
        public string Sound { get; set; }

        protected IFly flyingType;

        public void SetFlyingAbility(IFly newFlyingType)
        {
            flyingType = newFlyingType;
        }

        public string TryToFly()
        {
            return flyingType.Fly();
        }

        public Animal()
        {
            //Is it a good idea to set a default at the parent?
            flyingType = new AnimalDoesNotFly();
        }
    }
}
