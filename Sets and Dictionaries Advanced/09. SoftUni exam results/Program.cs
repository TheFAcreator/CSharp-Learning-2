Dictionary<string, int> students = new();
Dictionary<string, int> courses = new();

string input = "";

while((input = Console.ReadLine()) != "exam finished")
{
    string[] analyzer = input.Split('-');
    string username = analyzer[0];
    string course = analyzer[1];
    if (analyzer.Length == 3)
    {
        int points = int.Parse(analyzer[2]);
        if (!students.ContainsKey(username))
        {
            students[username] = 0;
        }
        if (!courses.ContainsKey(course))
        {
            courses[course] = 0;
        }
        courses[course]++;
        if (students[username] < points)
        {
            students[username] = points;
        }
    }
    else
    {
        if (students.ContainsKey(username))
        {
            students.Remove(username);
        }
    }
}

Console.WriteLine("Results:");
foreach(var kvp in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{kvp.Key} | {kvp.Value}");
}

Console.WriteLine("Submissions:");
foreach (var kvp in courses.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
}