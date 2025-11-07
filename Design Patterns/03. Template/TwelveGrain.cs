namespace Template
{
    public class TwelveGrain : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Mixing twelve different grains and seeds for the Twelve Grain bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Twelve Grain bread at 350 degrees Fahrenheit for 30 minutes.");
        }
    }
}
