int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
double price = 0;
switch (season)
{
    case "Spring":
        price = 3000;
        break;
    case "Summer":
    case "Autumn":
        price = 4200;
        break;
    case "Winter":
        price = 2600;
        break;
}
if (count <= 6) price -= price * 0.1;
else if (count > 7 && count <= 11) price -= price * 0.15;
else if (count >= 12) price -= price * 0.25;
if (count % 2 == 0 && season != "Autumn") price -= price * 0.05;
if (budget >= price) Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
else Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");