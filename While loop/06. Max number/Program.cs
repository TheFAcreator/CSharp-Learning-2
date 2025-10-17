int max = int.MinValue;
while (true)
{
    string txt = Console.ReadLine();
    if (txt == "Stop") break;
    int num = int.Parse(txt);
    if (num > max) max = num;
}
Console.WriteLine(max);