Stack<int> intsToSum = new(Console.ReadLine().Split().Select(int.Parse));
string input = "";
while((input = Console.ReadLine().ToLower()) != "end")
{
    string[] analyzer = input.Split();
    if (analyzer[0] == "add")
    {
        intsToSum.Push(int.Parse(analyzer[1]));
        intsToSum.Push(int.Parse(analyzer[2]));
    }
    else if (analyzer[0] == "remove")
    {
        int count = int.Parse(analyzer[1]);
        if (count <= intsToSum.Count)
        {
            for (int i = 0; i < count; i++)
            {
                intsToSum.Pop();
            }
        }
    }
}
Console.WriteLine("Sum: " + intsToSum.Sum());