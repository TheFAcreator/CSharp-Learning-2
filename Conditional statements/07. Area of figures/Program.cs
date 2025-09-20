string shape = Console.ReadLine();
if (shape == "square")
{
    double side = double.Parse(Console.ReadLine());
    Console.WriteLine("{0:f3}", Math.Round(side * side, 3));
}
else if (shape == "rectangle")
{
    double side = double.Parse(Console.ReadLine());
    double side2 = double.Parse(Console.ReadLine());
    Console.WriteLine("{0:f3}", Math.Round(side * side2, 3));
}
else if (shape == "circle")
{
    double side = double.Parse(Console.ReadLine());
    Console.WriteLine("{0:f3}", Math.Round(side * side * Math.PI, 3));
}
else
{
    double side = double.Parse(Console.ReadLine());
    double side2 = double.Parse(Console.ReadLine());
    Console.WriteLine("{0:f3}", Math.Round((side * side2) / 2, 3));
}