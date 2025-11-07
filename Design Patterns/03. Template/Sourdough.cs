namespace Template
{
    public class Sourdough : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Mixing flour, water, salt, and sourdough starter for the Sourdough bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Sourdough bread at 450 degrees Fahrenheit for 25 minutes.");
        }
    }
}
