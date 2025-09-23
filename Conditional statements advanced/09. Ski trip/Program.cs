int nights = int.Parse(Console.ReadLine());
string room = Console.ReadLine();
string feed = Console.ReadLine();
double price = 0;
nights--;
switch (room)
{
    case "room for one person":
        price = nights * 18;
        break;
    case "apartment":
        price = nights * 25;
        if (nights < 10) price -= price * 0.3;
        else if (nights <= 15) price -= price * 0.35;
        else price -= price * 0.5;
        break;
    case "president apartment":
        price = nights * 35;
        if (nights < 10) price -= price * 0.1;
        else if (nights <= 15) price -= price * 0.15;
        else price -= price * 0.2;
        break;
}
if (feed == "positive") price += price * 0.25;
else price -= price * 0.1;
Console.WriteLine($"{price:f2}");