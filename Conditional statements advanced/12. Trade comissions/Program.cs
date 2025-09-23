string city = Console.ReadLine();
double num = double.Parse(Console.ReadLine());
double n = 0;
switch (city)
{
    case "Sofia":
        if (num >= 0 && num <= 500) n = num * 0.05;
        else if (num > 500 && num <= 1000) n = num * 0.07;
        else if (num > 1000 && num <= 10000) n = num * 0.08;
        else if (num > 10000) n = num * 0.12;
        else Console.WriteLine("error");
        break;
    case "Varna":
        if (num >= 0 && num <= 500) n = num * 0.045;
        else if (num > 500 && num <= 1000) n = num * 0.075;
        else if (num > 1000 && num <= 10000) n = num * 0.1;
        else if (num > 10000) n = num * 0.13;
        else Console.WriteLine("error");
        break;
    case "Plovdiv":
        if (num >= 0 && num <= 500) n = num * 0.055;
        else if (num > 500 && num <= 1000) n = num * 0.08;
        else if (num > 1000 && num <= 10000) n = num * 0.12;
        else if (num > 10000) n = num * 0.145;
        else Console.WriteLine("error");
        break;
    default:
        Console.WriteLine("error");
        break;
}
if (n != 0) Console.WriteLine($"{n:f2}");