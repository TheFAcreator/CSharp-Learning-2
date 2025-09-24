int groups = int.Parse(Console.ReadLine());
int mus = 0;
int mon = 0;
int kil = 0;
int k2 = 0;
int eve = 0;
int all = 0;
for (int i = 0; i < groups; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (n <= 5)
    {
        mus += n;
        all += n;
    }
    else if (n <= 12)
    {
        mon += n;
        all += n;
    }
    else if (n <= 25)
    {
        kil += n;
        all += n;
    }
    else if (n <= 40)
    {
        k2 += n;
        all += n;
    }
    else
    {
        eve += n;
        all += n;
    }
}
Console.WriteLine($"{(double)mus / all * 100:f2}%");
Console.WriteLine($"{(double)mon / all * 100:f2}%");
Console.WriteLine($"{(double)kil / all * 100:f2}%");
Console.WriteLine($"{(double)k2 / all * 100:f2}%");
Console.WriteLine($"{(double)eve / all * 100:f2}%");