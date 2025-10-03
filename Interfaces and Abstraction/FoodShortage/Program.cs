namespace FoodShortage;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<Citizen> citizens = new();
        List<Rebel> rebels = new();

        for (int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split();

            if (analyzer.Length == 4)
            {
                string name = analyzer[0];
                int age = int.Parse(analyzer[1]);
                string id = analyzer[2];
                string birthdate = analyzer[3];

                citizens.Add(new Citizen(name, age, id, birthdate));
            }
            else
            {
                string name = analyzer[0];
                int age = int.Parse(analyzer[1]);
                string group = analyzer[2];

                rebels.Add(new Rebel(name, age, group));
            }
        }

        int totalFood = 0;

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            if(citizens.Any(c => c.Name == input))
            {
                var citizen = citizens.First(c => c.Name == input);
                citizen.Food += 10;
                totalFood += 10;
            }
            else if (rebels.Any(r => r.Name == input))
            {
                var rebel = rebels.First(r => r.Name == input);
                rebel.Food += 5;
                totalFood += 5;
            }
        }

        Console.WriteLine(totalFood);
    }
}