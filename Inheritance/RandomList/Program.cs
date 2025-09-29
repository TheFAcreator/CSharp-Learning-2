namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            int index = new Random().Next(0, this.Count);

            string randomElement = this[index];

            this.Remove(randomElement);

            return randomElement;
        }
    }

    public class StartUp
    {
        public static void Main(string[] args)
        {
            
        }
    }
}