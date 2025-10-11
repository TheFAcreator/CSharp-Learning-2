string[] analyzer = Console.ReadLine().Split();
int start = int.Parse(analyzer[0]);
int end = int.Parse(analyzer[1]);
string command = Console.ReadLine();

Predicate<int> check;
if (command == "even")
{
    check = n => n % 2 == 0;
}
else // "odd"
{
    check = n => n % 2 != 0;
}

List<int> numbers = new List<int>();
for (int i = start; i <= end; i++)
{
    if (check(i))
    {
        numbers.Add(i);
    }
}

Console.WriteLine(string.Join(" ", numbers));