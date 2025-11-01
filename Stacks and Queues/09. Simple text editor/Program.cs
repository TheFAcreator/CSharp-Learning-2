int n = int.Parse(Console.ReadLine());
string str = "";
Stack<string> stack = new();
stack.Push(str);
for (int i = 0; i < n; i++)
{
    string[] analyzer = Console.ReadLine().Split();
    switch (int.Parse(analyzer[0]))
    {
        case 1:
            str += analyzer[1];
            stack.Push(str);
            break;
        case 2:
            int count = int.Parse(analyzer[1]);
            if (count >= str.Length)
            {
                str = "";
            }
            else
            {
                str = str.Substring(0, str.Length - count);
            }
            stack.Push(str);
            break;
        case 3:
            Console.WriteLine(str[int.Parse(analyzer[1]) - 1]);
            break;
        case 4:
            stack.Pop();
            str = stack.Peek();
            break;
    }
}