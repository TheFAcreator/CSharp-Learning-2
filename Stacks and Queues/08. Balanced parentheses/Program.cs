string input = Console.ReadLine();
Stack<char> stack = new();
bool isBalanced = true;
for (int i = 0; i < input.Length; i++)
{
    if(input[i] == '(' || input[i] == '[' || input[i] == '{')
    {
        stack.Push(input[i]);
    }
    else if (input[i] == ')')
    {
        if (stack.Count == 0 || stack.Peek() != '(')
        {
            Console.WriteLine("NO");
            isBalanced = false;
            break;
        }
        stack.Pop();
    }
    else if (input[i] == ']')
    {
        if (stack.Count == 0 || stack.Peek() != '[')
        {
            Console.WriteLine("NO");
            isBalanced = false;
            break;
        }
        stack.Pop();
    }
    else if (input[i] == '}')
    {
        if (stack.Count == 0 || stack.Peek() != '{')
        {
            Console.WriteLine("NO");
            isBalanced = false;
            break;
        }
        stack.Pop();
    }
}
if (isBalanced && stack.Count == 0)
{
    Console.WriteLine("YES");
}