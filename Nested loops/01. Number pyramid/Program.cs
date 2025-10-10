int n = int.Parse(Console.ReadLine());
bool flag = true;
int num = 1;
for (int i = 1; flag; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (num == n + 1)
        {
            flag = false;
            break;
        }
        Console.Write(num);
        if (num != n + 2) Console.Write(" ");
        num++;
    }
    if (flag) Console.WriteLine();
}