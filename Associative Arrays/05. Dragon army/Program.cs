public class Dragon
{
    public string Name { get; set; }
    public int Damage = 45;
    public int Health = 250;
    public int Armor = 10;
}
public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<Dragon>> dragons = new();
        for (int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split();
            string type = analyzer[0];
            string name = analyzer[1];
            string damage = analyzer[2];
            string health = analyzer[3];
            string armor = analyzer[4];
            if (!dragons.ContainsKey(type))
            {
                dragons[type] = new List<Dragon>();
            }
            Dragon dragon = new Dragon();
            dragon.Name = name;
            if (!(damage == "null")) dragon.Damage = int.Parse(damage);
            if (!(health == "null")) dragon.Health = int.Parse(health);
            if (!(armor == "null")) dragon.Armor = int.Parse(armor);
            if (dragons[type].Any(d => d.Name == name))
            {
                dragons[type].Remove(dragons[type].First(d => d.Name == name));
            }
            dragons[type].Add(dragon);
        }
        foreach (var kvp in dragons)
        {
            string type = kvp.Key;
            List<Dragon> dragonList = kvp.Value;
            double averageDamage = dragonList.Average(d => d.Damage);
            double averageHealth = dragonList.Average(d => d.Health);
            double averageArmor = dragonList.Average(d => d.Armor);
            Console.WriteLine($"{type}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
            foreach (var dragon in dragonList.OrderBy(d => d.Name))
            {
                Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
            }
        }
    }
}