int beg = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int num = int.Parse(Console.ReadLine());
bool flag = false;
int count = 0;
for (int i = beg; i <= end; i++)
{
    for (int j = beg; j <= end; j++)
    {
        count++;
        if (i + j == num)
        {
            Console.WriteLine($"Combination N:{count} ({i} + {j} = {num})");
            flag = true;
            break;
        }
    }
    if (flag) break;
}
if (flag == false) Console.WriteLine($"{count} combinations - neither equals {num}");