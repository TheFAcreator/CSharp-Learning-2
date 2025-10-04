namespace WildFarm.Animals
{
    public abstract class Mammal : Animal
    {
        protected string LivingRegion { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
