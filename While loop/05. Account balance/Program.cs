double sum = 0;
while (true)
{
    string txt = Console.ReadLine();
    double num = 0;
    if (txt == "NoMoreMoney") break;
    else num = double.Parse(txt);
    if (num < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    else
    {
        sum += num;
        Console.WriteLine($"Increase: {num:f2}");
    }
}
Console.WriteLine($"Total: {sum:f2}");