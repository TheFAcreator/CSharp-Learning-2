int num1 = int.Parse(Console.ReadLine());
string operation = Console.ReadLine();
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(Calculate(num1, num2, operation));
static int Calculate(int num1, int num2, string operation)
{
    switch (operation)
    {
        case "+":
            return num1 + num2;
        case "-":
            return num1 - num2;
        case "*":
            return num1 * num2;
        case "/":
            return num1 / num2;
    }
    return 0;
}