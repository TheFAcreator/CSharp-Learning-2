namespace BirthdayCelebrations;

public class StartUp
{
    public static void Main()
    {
        var citizens = new List<IIdentifiable>();
        var pets = new List<IIdentifiable>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] analyzer = input.Split();

            if (analyzer[0] == "Citizen")
            {
                citizens.Add(new Citizen(analyzer[1], int.Parse(analyzer[2]), analyzer[3], analyzer[4]));
            }
            else if (analyzer[0] == "Pet")
            {
                pets.Add(new Pet(analyzer[1], analyzer[2]));
            }
        }

        string yearToCheck = Console.ReadLine();
        foreach (var citizen in citizens.Where(c => c.Birthdate.EndsWith(yearToCheck)))
        {
            Console.WriteLine(citizen.Birthdate);
        }

        foreach (var pet in pets.Where(p => p.Birthdate.EndsWith(yearToCheck)))
        {
            Console.WriteLine(pet.Birthdate);
        }
    }
}