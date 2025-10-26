int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] analyzer = Console.ReadLine().Split();
    if (long.Parse(analyzer[0]) > long.Parse(analyzer[1]))
    {
        int sum = 0;
        for (int j = 0; j < analyzer[0].Length; j++)
        {
            char a = analyzer[0][j];
            if (a != '-')
            {
                sum += int.Parse(a.ToString());
            }
        }
        Console.WriteLine(sum);
    }
    else
    {
        int sum = 0;
        for (int j = 0; j < analyzer[1].Length; j++)
        {
            char a = analyzer[1][j];
            if (a != '-')
            {
                sum += int.Parse(a.ToString());
            }
        }
        Console.WriteLine(sum);
    }
}