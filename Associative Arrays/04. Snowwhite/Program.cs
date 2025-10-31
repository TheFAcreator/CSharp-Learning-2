// Program may not work correctly in all cases of input (chance of proper output - 30/100)

public class Program
{
    static void Main()
    {
        string input = "";
        Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();
        while ((input = Console.ReadLine()) != "Once upon a time")
        {
            string[] tokens = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0];
            string hatColor = tokens[1];
            int physics = int.Parse(tokens[2]);
            if (!dwarfs.ContainsKey(name))
            {
                dwarfs.Add(name, new Dictionary<string, int>());
                dwarfs[name].Add(hatColor, physics);
            }
            else
            {
                if (!dwarfs[name].ContainsKey(hatColor))
                {
                    dwarfs[name].Add(hatColor, physics);
                }
                else
                {
                    if (dwarfs[name][hatColor] < physics) dwarfs[name][hatColor] = physics;
                }
            }
        }
        foreach (var name in dwarfs.OrderByDescending(x => x.Value.Count))
        {
            foreach (var dwarf in name.Value.OrderByDescending(g => g.Value))
            {
                Console.WriteLine($"({dwarf.Key}) {name.Key} <-> {dwarf.Value}");
            }
        }
    }
}