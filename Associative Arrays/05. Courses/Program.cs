using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string input = "";
        Dictionary<string, List<string>> courses = new();
        while ((input = Console.ReadLine()) != "end")
        {
            string[] analyzer = input.Split(" : ");
            if (!courses.ContainsKey(analyzer[0]))
                courses[analyzer[0]] = new();
            courses[analyzer[0]].Add(analyzer[1]);
        }
        foreach (KeyValuePair<string, List<string>> kvp in courses)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value.Count);
            foreach (string student in kvp.Value)
                Console.WriteLine("-- " + student);
        }
    }
}