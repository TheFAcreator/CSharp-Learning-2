int age = int.Parse(Console.ReadLine());
double price = double.Parse(Console.ReadLine());
int price1 = int.Parse(Console.ReadLine());
int money = 10;
int saved = 0;
for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        saved += money - 1;
        money += 10;
    }
    else saved += price1;
}
if (saved >= price)
{
    Console.WriteLine($"Yes! {saved - price:f2}");
}
else Console.WriteLine($"No! {price - saved:f2}");