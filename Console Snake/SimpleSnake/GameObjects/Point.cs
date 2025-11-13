using System;

namespace SimpleSnake.GameObjects
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw(char s)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(s);
        }
        public void Draw(char s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
    }
}
