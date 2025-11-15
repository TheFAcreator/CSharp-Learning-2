class MyClass
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        int lootPerDay = int.Parse(Console.ReadLine());
        double expected = double.Parse(Console.ReadLine());
        double loot = 0;
        for (int i = 1; i <= days; i++)
        {
            loot += lootPerDay;
            if (i % 3 == 0)
            {
                loot += lootPerDay * 0.5;
                if (i % 5 == 0)
                {
                    loot -= loot * 0.3;
                }
            }
            else if (i % 5 == 0)
            {
                loot -= loot * 0.3;
            }
        }
        if (loot >= expected) Console.WriteLine($"Ahoy! {loot:f2} plunder gained.");
        else Console.WriteLine($"Collected only {loot / expected * 100:f2}% of the plunder.");
    }
}