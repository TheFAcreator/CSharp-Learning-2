string[] analyzer = Console.ReadLine().Split();
int add = int.Parse(analyzer[0]);
int pop = int.Parse(analyzer[1]);
int check = int.Parse(analyzer[2]);
string[] numbers = Console.ReadLine().Split();
Stack<int> stack = new();
for (int i = 0; i < add; i++)
{
    stack.Push(int.Parse(numbers[i]));
}
for (int i = 0; i < pop; i++)
{
    if (stack.Count > 0)
    {
        stack.Pop();
    }
}
if(stack.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    if (stack.Contains(check))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine(stack.Min());
    }
}