int min = int.MaxValue;
while (true)
{
    string txt = Console.ReadLine();
    if (txt == "Stop") break;
    int num = int.Parse(txt);
    if (num < min) min = num;
}
Console.WriteLine(min);