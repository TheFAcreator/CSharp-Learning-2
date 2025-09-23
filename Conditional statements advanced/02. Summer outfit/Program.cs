int celsius = int.Parse(Console.ReadLine());
string day = Console.ReadLine();
string shoes = "";
string clothing = "";
if (celsius >= 10 && celsius <= 18)
{
    switch (day)
    {
        case "Morning":
            clothing = "Sweatshirt";
            shoes = "Sneakers";
            break;
        case "Afternoon":
            clothing = "Shirt";
            shoes = "Moccasins";
            break;
        case "Evening":
            clothing = "Shirt";
            shoes = "Moccasins";
            break;
    }
}
else if (celsius > 18 && celsius <= 24)
{
    switch (day)
    {
        case "Morning":
            clothing = "Shirt";
            shoes = "Moccasins";
            break;
        case "Afternoon":
            clothing = "T-Shirt";
            shoes = "Sandals";
            break;
        case "Evening":
            clothing = "Shirt";
            shoes = "Moccasins";
            break;
    }
}
else
{
    switch (day)
    {
        case "Morning":
            clothing = "T-Shirt";
            shoes = "Sandals";
            break;
        case "Afternoon":
            clothing = "Swim Suit";
            shoes = "Barefoot";
            break;
        case "Evening":
            clothing = "Shirt";
            shoes = "Moccasins";
            break;
    }
}
Console.WriteLine($"It's {celsius} degrees, get your {clothing} and {shoes}.");