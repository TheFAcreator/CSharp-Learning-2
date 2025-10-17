double change = double.Parse(Console.ReadLine());
int count = 0;
int cents = (int)(change * 100);

while (cents > 0)
{
    if (cents >= 200)  // 2 dollars = 200 cents
    {
        count++;
        cents -= 200;
    }
    else if (cents >= 100)  // 1 dollar = 100 cents
    {
        count++;
        cents -= 100;
    }
    else if (cents >= 50)  // 50 cents
    {
        count++;
        cents -= 50;
    }
    else if (cents >= 20)  // 20 cents
    {
        count++;
        cents -= 20;
    }
    else if (cents >= 10)  // 10 cents
    {
        count++;
        cents -= 10;
    }
    else if (cents >= 5)  // 5 cents
    {
        count++;
        cents -= 5;
    }
    else if (cents >= 2)  // 2 cents
    {
        count++;
        cents -= 2;
    }
    else  // 1 cent
    {
        count++;
        cents -= 1;
    }
}

Console.WriteLine(count);
