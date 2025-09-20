double money = double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double prices = double.Parse(Console.ReadLine());
double decor = money * 0.1;
double clothing = statists * prices;
if (statists > 150) clothing -= clothing * 0.1;
if (decor + clothing <= money)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {money - (decor + clothing):f2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {decor + clothing - money:f2} leva more.");
}