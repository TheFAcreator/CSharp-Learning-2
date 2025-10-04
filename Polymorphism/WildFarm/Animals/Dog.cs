using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }

        public override void Eat(Food food)
        {
            if(food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * 0.40;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
