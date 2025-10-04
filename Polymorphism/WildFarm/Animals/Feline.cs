namespace WildFarm.Animals
{
    public abstract class Feline : Mammal
    {
        protected string Breed { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
