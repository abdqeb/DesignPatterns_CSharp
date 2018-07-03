namespace DesignPatterns.Strategy
{
    public class Dog : Animal
    {
        public Dog()
        {
            Sound = "Bark";
            //This determines how a dog will react to "TryToFly" 
            flyingType = new AnimalDoesNotFly();
        }

        //Assume this is a function unique to dogs
        public string DigHole()
        {
            return "Dog is Digging a hole";
        }
    }
}
