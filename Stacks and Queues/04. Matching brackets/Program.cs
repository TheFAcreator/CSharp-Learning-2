string input = Console.ReadLine();
Stack<int> brackets = new();
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        brackets.Push(i);
    }
    else if (input[i] == ')')
    {
        int start = brackets.Pop();
        Console.WriteLine(input.Substring(start, i - start + 1));
    }
}