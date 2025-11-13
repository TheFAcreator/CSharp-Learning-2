namespace SimpleSnake
{
    using SimpleSnake.Core;
    using SimpleSnake.GameObjects;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            Wall wall = new(120, 40);
            Snake snake = new(wall);

            Engine engine = new(wall, snake);
            engine.Run();
        }
    }
}
