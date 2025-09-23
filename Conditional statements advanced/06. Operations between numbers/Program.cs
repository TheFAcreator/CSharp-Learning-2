int num = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
string operator1 = Console.ReadLine();
switch (operator1)
{
    case "+":
        if ((num + num2) % 2 == 0) Console.WriteLine($"{num} {operator1} {num2} = {num + num2} - even");
        else Console.WriteLine($"{num} {operator1} {num2} = {num + num2} - odd");
        break;
    case "-":
        if ((num - num2) % 2 == 0) Console.WriteLine($"{num} {operator1} {num2} = {num - num2} - even");
        else Console.WriteLine($"{num} {operator1} {num2} = {num - num2} - odd");
        break;
    case "*":
        if ((num * num2) % 2 == 0) Console.WriteLine($"{num} {operator1} {num2} = {num * num2} - even");
        else Console.WriteLine($"{num} {operator1} {num2} = {num * num2} - odd");
        break;
    case "/":
        if (num2 != 0) Console.WriteLine($"{num} / {num2} = {(double)num / num2:f2}");
        else Console.WriteLine($"Cannot divide {num} by zero");
        break;
    case "%":
        if (num2 != 0) Console.WriteLine($"{num} % {num2} = {num % num2}");
        else Console.WriteLine($"Cannot divide {num} by zero");
        break;
}