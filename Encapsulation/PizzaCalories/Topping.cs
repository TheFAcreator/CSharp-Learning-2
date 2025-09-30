namespace PizzaCalories
{
    public class Topping
    {
        private const int _caloriesPerGram = 2;

        private string type;
        public string Type
        {
            get { return type; }
            private set
            {
                string valueLower = value.ToLower();
                if (valueLower != "meat" && valueLower != "veggies" && valueLower != "cheese" && valueLower != "sauce")
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }

        private int grams;
        public int Grams
        {
            get { return grams; }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{Type} weight should be in the range [1..50].");
                }

                grams = value;
            }
        }

        public double CaloriesPerGram => _caloriesPerGram * GetTypeModifier(Type);

        private static double GetTypeModifier(string type)
        {
            return type.ToLower() switch
            {
                "meat" => 1.2,
                "veggies" => 0.8,
                "cheese" => 1.1,
                "sauce" => 0.9,
                _ => 0
            };
        }

        public Topping(string type, int grams)
        {
            Type = type;
            Grams = grams;
        }
    }
}
