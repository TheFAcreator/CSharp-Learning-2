string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());
double price1 = 0;
double price2 = 0;
switch (month)
{
    case "May":
    case "October":
        price1 = nights * 50;
        price2 = nights * 65;
        if (nights > 7 && nights <= 14) price1 -= price1 * 0.05;
        else if (nights > 14)
        {
            price1 -= price1 * 0.3;
            price2 -= price2 * 0.1;
        }
        break;
    case "June":
    case "September":
        price1 = nights * 75.2;
        price2 = nights * 68.7;
        if (nights > 14)
        {
            price1 -= price1 * 0.2;
            price2 -= price2 * 0.1;
        }
        break;
    case "July":
    case "August":
        price1 = nights * 76;
        price2 = nights * 77;
        if (nights > 14) price2 -= price2 * 0.1;
        break;
}
Console.WriteLine($"Apartment: {price2:f2} lv.");
Console.WriteLine($"Studio: {price1:f2} lv.");