using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
        }

        public override void Eat(Food food)
        {
            if(food is Meat || food is Vegetable)
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * 0.30;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
