namespace Singleton
{
    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> _data = new();

        private static SingletonDataContainer instance = new SingletonDataContainer();

        public static SingletonDataContainer Instance => instance;

        private SingletonDataContainer()
        {
            Console.WriteLine("Initializing...");

            var elements = File.ReadAllLines("../../../Cities.txt");
            for (int i = 0; i < elements.Length; i++)
            {
                string[] parts = elements[i].Split(" - ");
                string name = parts[0].Trim();

                if (int.TryParse(parts[1].Trim(), out int population))
                {
                    _data[name] = population;
                }
                else
                {
                    throw new FormatException($"Invalid population format for {name}: {parts[1]}");
                }
            }
        }

        public int GetPopulation(string name)
        {
            return _data.TryGetValue(name, out int population) ? population : 0;
        }
    }
}
