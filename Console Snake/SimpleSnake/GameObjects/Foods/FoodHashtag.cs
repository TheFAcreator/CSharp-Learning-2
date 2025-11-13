namespace SimpleSnake.GameObjects.Foods
{
    public class FoodHashtag : Food
    {
        private const char foodSymbol = '#';
        private const int foodPoints = 3;

        public FoodHashtag(Wall wall) : base(wall, foodSymbol, foodPoints)
        {
        }
    }
}
