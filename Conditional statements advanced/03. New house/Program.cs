string flowers = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double price = 0;
switch (flowers)
{
    case "Roses":
        price = count * 5;
        if (count > 80) price -= price * 0.1;
        break;
    case "Dahlias":
        price = count * 3.8;
        if (count > 90) price -= price * 0.15;
        break;
    case "Tulips":
        price = count * 2.8;
        if (count > 80) price -= price * 0.15;
        break;
    case "Narcissus":
        price = count * 3;
        if (count < 120) price += price * 0.15;
        break;
    case "Gladiolus":
        price = count * 2.5;
        if (count < 80) price += price * 0.2;
        break;
}
if (budget >= price)
{
    Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {budget - price:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
}