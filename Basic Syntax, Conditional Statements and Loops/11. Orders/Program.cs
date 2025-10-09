int n = int.Parse(Console.ReadLine());
double sum = 00;
for (int i = 0; i < n; i++)
{
    double pricePC = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int count = int.Parse(Console.ReadLine());
    double price = pricePC * days * count;
    sum += price;
    Console.WriteLine($"The price for the coffee is: ${price:f2}");
}
Console.WriteLine($"Total: ${sum:f2}");