double avr = 0;
int count = 0;
double avr1 = 0;
int count1 = 0;
int judges = int.Parse(Console.ReadLine());
while (true)
{
    string input = Console.ReadLine();
    if (input == "Finish")
    {
        Console.WriteLine($"Student's final assessment is {avr / count:f2}.");
        break;
    }
    else
    {
        string name = input;
        for (int i = 0; i < judges; i++)
        {
            double mark = double.Parse(Console.ReadLine());
            count++;
            count1++;
            avr += mark;
            avr1 += mark;
        }
        Console.WriteLine($"{name} - {avr1 / count1:f2}.");
        avr1 = 0;
        count1 = 0;
    }
}