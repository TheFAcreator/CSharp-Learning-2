int num = int.Parse(Console.ReadLine());
int divider = 0;
if (num % 2 == 0)
{
    divider = 2;
}
if (num % 3 == 0)
{
    divider = 3;
}
if (num % 6 == 0)
{
    divider = 6;
}
if (num % 7 == 0)
{
    divider = 7;
}
if (num % 10 == 0)
{
    divider = 10;
}
if (divider != 0)
{
    Console.WriteLine("The number is divisible by " + divider);
}
else
{
    Console.WriteLine("Not divisible");
}