int n = int.Parse(Console.ReadLine());
Stack<int> stack = new();
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    if (input[0] == '1')
    {
        stack.Push(int.Parse(input.Split()[1]));
    }
    else if (input[0] == '2')
    {
        if (stack.Count > 0)
        {
            stack.Pop();
        }
    }
    else if (input[0] == '3')
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Max());
        }
    }
    else if (input[0] == '4')
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Min());
        }
    }
}
Console.WriteLine(string.Join(", ", stack));