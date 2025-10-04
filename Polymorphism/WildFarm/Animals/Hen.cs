namespace WildFarm.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
        {
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }

        public override void Eat(Food food)
        {
            FoodEaten += food.Quantity;
            Weight += food.Quantity * 0.35;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
