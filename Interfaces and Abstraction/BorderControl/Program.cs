namespace BorderControl;

public class StartUp
{
    public static void Main()
    {
        List<IIdentifiable> entities = new List<IIdentifiable>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] analyzer = input.Split();

            if (analyzer.Length == 3) // Citizen
            {
                string name = analyzer[0];
                int age = int.Parse(analyzer[1]);
                string id = analyzer[2];

                entities.Add(new Citizen(name, age, id));
            }
            else if (analyzer.Length == 2) // Robot
            {
                string model = analyzer[0];
                string id = analyzer[1];

                entities.Add(new Robot(model, id));
            }
        }

        string fakeIdEnding = Console.ReadLine();
        foreach (var entity in entities.Where(e => e.Id.EndsWith(fakeIdEnding)))
        {
            Console.WriteLine(entity.Id);
        }
    }
}