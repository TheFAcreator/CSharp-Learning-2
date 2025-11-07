namespace Prototype
{
    public class Sandwich : SandwichPrototype
    {
        private string breadType;
        private string meatType;
        private string cheeseType;
        private string veggiesType;

        public Sandwich(string breadType, string meatType, string cheeseType, string veggiesType)
        {
            this.breadType = breadType;
            this.meatType = meatType;
            this.cheeseType = cheeseType;
            this.veggiesType = veggiesType;
        }

        public override SandwichPrototype Clone()
        {
            Console.WriteLine("Cloning sandwich with ingredients:");
            Console.WriteLine($"Bread: {breadType}");
            Console.WriteLine($"Meat: {meatType}");
            Console.WriteLine($"Cheese: {cheeseType}");
            Console.WriteLine($"Veggies: {veggiesType}");
            Console.WriteLine();

            return MemberwiseClone() as SandwichPrototype;
        }
    }
}
