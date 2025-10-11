using System.Collections.Generic;

List<string> invitations = Console.ReadLine().Split().ToList();
Dictionary<string, Predicate<string>> filters = new();

string input;
while((input = Console.ReadLine()) != "Print")
{
    string[] analyzer = input.Split(';');
    string command = analyzer[0];
    string type = analyzer[1];
    string value = analyzer[2];

    if(command == "Add filter")
    {
        switch(type)
        {
            case "Starts with":
                filters.Add(type + value, name => name.StartsWith(value));
                break;
            case "Ends with":
                filters.Add(type + value, name => name.EndsWith(value));
                break;
            case "Length":
                filters.Add(type + value, name => name.Length == int.Parse(value));
                break;
            case "Contains":
                filters.Add(type + value, name => name.Contains(value));
                break;
        }
    }
    else // "Remove filter"
    {
        switch(type)
        {
            case "Starts with":
                filters.Remove(type + value);
                break;
            case "Ends with":
                filters.Remove(type + value);
                break;
            case "Length":
                filters.Remove(type + value);
                break;
            case "Contains":
                filters.Remove(type + value);
                break;
        }
    }
}

foreach (string name in invitations)
{
    if (!filters.Values.Any(f => f(name)))
    {
        Console.Write(name + " ");
    }
}