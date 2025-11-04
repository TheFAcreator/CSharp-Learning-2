int n = int.Parse(Console.ReadLine());
List<string> usernames = new List<string>();

for(int i = 0; i < n; i++)
{
    string username = Console.ReadLine();
    if (!usernames.Contains(username))
    {
        usernames.Add(username);
    }
}

foreach (var username in usernames)
{
    Console.WriteLine(username);
}