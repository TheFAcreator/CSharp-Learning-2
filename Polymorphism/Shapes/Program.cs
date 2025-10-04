namespace Shapes;

public class StartUp
{
    static void Main(string[] args)
    {
        //Sample usage of the Shape classes

        Shape rectangle = new Rectangle(10, 20);
        Circle circle = new Circle(5);

        Console.WriteLine(rectangle.Draw());
        Console.WriteLine($"Area: {rectangle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");

        Console.WriteLine(circle.Draw());
        Console.WriteLine($"Area: {circle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");
    }
}