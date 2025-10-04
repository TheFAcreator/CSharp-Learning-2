namespace Raiding;

public class StartUp
{
    static void Main(string[] args)
    {
        List<BaseHero> heroes = new List<BaseHero>();
        
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string heroName = Console.ReadLine();
            string heroType = Console.ReadLine();

            switch (heroType)
            {
                case "Druid":
                    heroes.Add(new Druid(heroName));
                    break;
                case "Paladin":
                    heroes.Add(new Paladin(heroName));
                    break;
                case "Rogue":
                    heroes.Add(new Rogue(heroName));
                    break;
                case "Warrior":
                    heroes.Add(new Warrior(heroName));
                    break;
                default:
                    Console.WriteLine("Invalid hero!");
                    i--; // Decrement i to repeat this iteration
                    break;
            }
        }
        foreach (var hero in heroes)
        {
            Console.WriteLine(hero.CastAbility());
        }

        int bossPower = int.Parse(Console.ReadLine());
        int totalPower = heroes.Sum(h => h.Power);

        if(totalPower >= bossPower)
        {
            Console.WriteLine("Victory!");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }
    }
}