using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }

        public override void Eat(Food food)
        {
            if (food is Fruit || food is Vegetable)
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * 0.10;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
