namespace Shapes;

public class StartUp
{
    public static void Main(string[] args)
    {
        IDrawable circle = new Circle(5);
        IDrawable rectangle = new Rectangle(10, 20);
        circle.Draw();
        rectangle.Draw();
    }
}