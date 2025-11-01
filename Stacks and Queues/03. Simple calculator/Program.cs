Stack<string> stack = new(Console.ReadLine().Split().Reverse());
int result = int.Parse(stack.Pop());
for(int i = 0; i < stack.Count;)
{
    string operation = stack.Pop();
    int number = int.Parse(stack.Pop());
    if (operation == "+")
    {
        result += number;
    }
    else
    {
        result -= number;
    }
}
Console.WriteLine(result);