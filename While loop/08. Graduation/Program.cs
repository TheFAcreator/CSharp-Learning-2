string name = Console.ReadLine();
int grade = 1;
int files = 0;
double sum = 0;
while (grade <= 12)
{
    double grade1 = double.Parse(Console.ReadLine());
    if (grade1 < 4) files++;
    else
    {
        grade++;
        sum += grade1;
    }
    if (files == 2)
    {
        Console.WriteLine($"{name} has been excluded at {grade} grade");
        break;
    }
}
if (files != 2)
{
    double avg = sum / 12;
    Console.WriteLine($"{name} graduated. Average grade: {avg:f2}");
}