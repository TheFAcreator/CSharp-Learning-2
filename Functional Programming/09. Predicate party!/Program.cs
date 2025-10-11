List<string> people = Console.ReadLine().Split().ToList();

string input;
while((input = Console.ReadLine()) != "Party!")
{
    string[] analyzer = input.Split();
    string command = analyzer[0];
    string condition = analyzer[1];
    string value = analyzer[2];

    Predicate<string> predicate = null;
    switch(condition)
    {
        case "StartsWith":
            predicate = name => name.StartsWith(value);
            break;
        case "EndsWith":
            predicate = name => name.EndsWith(value);
            break;
        case "Length":
            predicate = name => name.Length == int.Parse(value);
            break;
    }

    if(command == "Remove")
    {
        people.RemoveAll(predicate);
    }
    else // "Double"
    {
        int[] indices = people.Where(n => predicate(n)).Select(n => people.IndexOf(n)).ToArray();

        for(int i = 0; i < indices.Length; i++)
        {
            people.Insert(indices[i], people[indices[i]]);
        }
    }
}

if(people.Count > 0)
{
    Console.WriteLine(string.Join(", ", people) + " are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}