using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
        }

        public override void Eat(Food food)
        {
            if(food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * 1.00;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
