int count = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string day = Console.ReadLine();
double price = 0;
switch (type)
{
    case "Students":
        if (day == "Friday") price = 8.45 * count;
        else if (day == "Saturday") price = 9.8 * count;
        else price = 10.46 * count;
        if (count >= 30) price -= price * 0.15;
        break;
    case "Business":
        if (day == "Friday") { price = 10.9 * count; if (count >= 100) price -= 10 * 10.9; }
        else if (day == "Saturday") { price = 15.6 * count; if (count >= 100) price -= 10 * 15.6; }
        else { price = 16 * count; if (count >= 100) price -= 10 * 16; }
        break;
    case "Regular":
        if (day == "Friday") price = 15 * count;
        else if (day == "Saturday") price = 20 * count;
        else price = 22.5 * count;
        if (count >= 10 && count <= 20) price -= price * 0.05;
        break;
}
Console.WriteLine($"Total price: {price:f2}");