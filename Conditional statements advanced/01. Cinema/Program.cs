string type = Console.ReadLine();
int row = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());
double num = 0;
switch (type)
{
    case "Premiere":
        num = row * col * 12;
        break;
    case "Normal":
        num = row * col * 7.5;
        break;
    case "Discount":
        num = row * col * 5;
        break;
}
Console.WriteLine($"{num:f2}");