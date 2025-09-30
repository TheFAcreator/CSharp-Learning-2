namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public Dough Dough
        {
            get => dough;
            set => dough = value;
        }

        public int Toppings => toppings.Count;

        public double Calories => TotalCalories();

        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count >= 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }

            toppings.Add(topping);
        }

        public double TotalCalories()
        {
            double totalCalories = dough.CaloriesPerGram * dough.Grams;

            foreach (var topping in toppings)
            {
                totalCalories += topping.CaloriesPerGram * topping.Grams;
            }

            return totalCalories;
        }
    }
}
