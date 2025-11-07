namespace Template
{
    public class WholeWheat : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Mixing whole wheat flour, water, salt, and yeast for the Whole Wheat bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Whole Wheat bread at 375 degrees Fahrenheit for 35 minutes.");
        }
    }
}
