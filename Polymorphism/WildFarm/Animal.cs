namespace WildFarm
{
    public abstract class Animal
    {
        protected string Name { get; set; }
        public double Weight { get; set; }
        protected int FoodEaten { get; set; }

        public abstract string ProduceSound();
        public abstract void Eat(Food food);

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
