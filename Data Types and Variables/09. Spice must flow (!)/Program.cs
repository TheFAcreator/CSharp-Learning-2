int num = int.Parse(Console.ReadLine());
int harvest = 0;
int days = 0;
while (num >= 100)
{
    harvest += num;
    if (harvest > 26) harvest -= 26;
    else harvest = 0;
    num -= 10;
    days++;
}
if (harvest > 26) harvest -= 26;
else harvest = 0;
Console.WriteLine(days);
Console.WriteLine(harvest);