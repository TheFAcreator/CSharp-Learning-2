namespace ExplicitInterfaces;

public class StartUp
{
    public static void Main()
    {
        List<Citizen> citizens = new List<Citizen>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] analyzer = input.Split();
            string name = analyzer[0];
            string country = analyzer[1];
            int age = int.Parse(analyzer[2]);

            Citizen citizen = new Citizen(name, country, age);

            citizens.Add(citizen);
        }

        foreach (var citizen in citizens)
        {
            Console.WriteLine(((IPerson)citizen).GetName());
            Console.WriteLine(((IResident)citizen).GetName());
        }
    }
}