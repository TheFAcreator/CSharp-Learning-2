static void Add(int num1, int num2)
{
    Console.WriteLine(num1 + num2);
}
static void Subtract(int num1, int num2)
{
    Console.WriteLine(num1 - num2);
}
static void Multiply(int num1, int num2)
{
    Console.WriteLine(num1 * num2);
}
static void Divide(int num1, int num2)
{
    Console.WriteLine(num1 / num2);
}
string operation = Console.ReadLine();
int num = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
switch (operation)
{
    case "add":
        Add(num, num2);
        break;
    case "subtract":
        Subtract(num, num2);
        break;
    case "multiply":
        Multiply(num, num2);
        break;
    case "divide":
        Divide(num, num2);
        break;
}