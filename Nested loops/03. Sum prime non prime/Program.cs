int sum1 = 0;
int sum2 = 0;
while (true)
{
    string input = Console.ReadLine();
    if (input == "stop")
    {
        Console.WriteLine("Sum of all prime numbers is: " + sum1);
        Console.WriteLine("Sum of all non prime numbers is: " + sum2);
        break;
    }
    int num = int.Parse(input);
    if (num < 0) Console.WriteLine("Number is negative.");
    else if (num == 2) sum1 += num;
    else if (num == 3) sum1 += num;
    else if (num == 5) sum1 += num;
    else if (num == 7) sum1 += num;
    else if (num % 2 != 0)
    {
        if (num % 3 != 0)
        {
            if (num % 5 != 0)
            {
                if (num % 7 != 0)
                {
                    if (num % 9 != 0) sum1 += num;
                    else sum2 += num;
                }
                else sum2 += num;
            }
            else sum2 += num;
        }
        else sum2 += num;
    }
    else sum2 += num;
}